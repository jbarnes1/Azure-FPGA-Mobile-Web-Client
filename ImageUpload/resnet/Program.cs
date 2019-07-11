using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CSharpClient;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Newtonsoft.Json;
using Tensorflow.Serving;

namespace resnet
{
    internal class Program
    {
        private static readonly string errorMessage = "" + Environment.NewLine + "dotnet resnet.dll [url(without port)] [path/to/local/image] <use_ssl (true/false - false if absent)> <auth_key (use_ssl must be true)>";

        private static int Main(string[] args)
        {
            return MainAsync(args).Result;
        }

        private static async Task<int> MainAsync(string[] args)
        {
            //if (args.Length < 2)
            //{
            //    Console.WriteLine($"Use as {errorMessage}");
            //    return 1;
            //}

            var host = "40.117.228.157"; // args[0];
            var image = @"C:\\a_NCSU_Data\\FY19\\CSA_Lightning_Talks\\JB_Fun_With_FPGAs\\Sample_Images\\PirateShip.jpg"; // args[1];

            var useSSL = false;

            if (args.Length > 2)
            {
                var useSslString = args[2];
                var parsed = bool.TryParse(useSslString, out useSSL);
                Console.WriteLine(useSSL ? "Using SSL" : "Not using SSL");
            }

            string auth = null;
            if (args.Length > 3 && useSSL)
            {
                auth = args[3];
                Console.WriteLine(!string.IsNullOrEmpty(auth) ? "Using auth" : "Not using auth");
            }

            var client = new ScoringClient(host, useSSL ? 443 : 80, useSSL, auth, "jb-fpga-aks-service-3");
            string jbPredict = "";
            using (var content = File.OpenRead(image))
            {
                IScoringRequest request = new ImageRequest("Placeholder:0", content);
                var result = await client.PredictAsync<float[,]>(request);
                // var result = await client.PredictAsync<float[,,,,]>(request);

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
                        jbPredict = jbPredict + "{" + ((char)34) + GetLabel(kvp.Key).ToString() + ((char)34) + ":" + ((char)34) + (kvp.Value * 100).ToString() + ((char)34) + "}";
                        jb++;
                        if (jb >= 1)
                        {
                           jbPredict = jbPredict + ","; //ADD Commas when > 1 
                        }
                    }
                }
                return 0;
            }
        }
        private static Dictionary<int, string> _classes;

        private static string GetLabel(int classId)
        {
            if (_classes == null)
            {
                var assembly = typeof(Program).GetTypeInfo().Assembly;
                var result = assembly.GetManifestResourceStream("resnet.imagenet-classes.json");

                var streamReader = new StreamReader(result);
                var classesJson = streamReader.ReadToEnd();

                _classes = JsonConvert.DeserializeObject<Dictionary<int, string>>(classesJson);
            }

            return _classes[classId];
        }
    }
}