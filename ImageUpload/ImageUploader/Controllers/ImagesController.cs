using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using ImageUploader.Handler;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

using System.Text;
using Grpc.Core;
using CSharpClient;
using Tensorflow.Serving;
using System.Net.Http;
using System.Net;
using System.Diagnostics;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ImageUploader.Controllers
{
    [Route("api/images")]
    [EnableCors("AllowSpecificOrigin")]
    public class ImagesController : Controller
    {
        private readonly IImageHandler _imageHandler;

        public ImagesController(IImageHandler imageHandler)
        {
            _imageHandler = imageHandler;
        }
        /// <summary>
        /// Uplaods an image to the server.
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [EnableCors("AllowSpecificOrigin")]
        public async Task<string> UploadImage(IFormFile file)
        {
            if (file != null)
            {
                var watch = new Stopwatch();
                watch.Start();
                var channel = new Channel("40.117.228.157:80", ChannelCredentials.Insecure);
                var client = new ScoringClient("40.117.228.157", 80, false,null, "jb-fpga-aks-service-3");
                string jbPredict = "";
                try
                {
                    using (Stream content = file.OpenReadStream())
                    {
                        IScoringRequest request = new ImageRequest("Placeholder:0", content);
                        var result = await client.PredictAsync<float[,]>(request);

                        Dictionary<string, float[,]> reslt = await client.PredictAsync<float[,]>(request);
                        foreach (KeyValuePair<string, float[,]> rslt in reslt)
                        {
                            Console.WriteLine("Key: {0}, Value: {1}", rslt.Key, rslt.Value);
                            float[,] preds = rslt.Value;
                            var length = rslt.Value.GetLength(1);
                            var predResults = new Dictionary<int, float>();
                            for (int j = 0; j < length; j++)
                            {
                                predResults.Add(j, rslt.Value[0, j]);
                            }
                            //Return a CSV string with the ranked predictions 
                            var jb = 0;
                            foreach (var kvp in predResults.Where(x => x.Value > 0.001).OrderByDescending(x => x.Value).Take(5))
                            {
                               // jbPredict = jbPredict + "{" + ((char)34) + GetLabel(kvp.Key).ToString() + ((char)34) + ":" + ((char)34) + (kvp.Value * 100).ToString() + ((char)34) + "}";
                                jbPredict = jbPredict + GetLabel(kvp.Key).ToString() + ":" + (kvp.Value * 100).ToString() + " %";
                                jb++;
                                if (jb >= 1)
                                {
                                    jbPredict = jbPredict + "<br />";
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    jbPredict = jbPredict + "ERROR: " + ex.Message.ToString();
                }
                watch.Stop();
                var responseTimeForCompleteRequest = watch.ElapsedMilliseconds;
                jbPredict = jbPredict + "<br />" + "FPGA Response Time:" + responseTimeForCompleteRequest.ToString() + " ms";
                return jbPredict;
            }
            return "JBNotOK";
        }
        private static Dictionary<int, string> _classes;
        private static string GetLabel(int classId)
        {
            if (_classes == null)
            {
                var assembly = typeof(Program).GetTypeInfo().Assembly;
                var result = assembly.GetManifestResourceStream("ImageUploader.imagenet-classes.json");
                var streamReader = new StreamReader(result);
                var classesJson = streamReader.ReadToEnd();
                _classes = JsonConvert.DeserializeObject<Dictionary<int, string>>(classesJson);
            }
            return _classes[classId];
        }
    }
}