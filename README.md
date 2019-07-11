# Fun with FPGAs!
![Image description](FPGA_Predict_1sm.png)

This working example seeks to extend the previous work that is referenced below to develop & deploy a Machine Learning Model (using a Databricks Python Notebook) to an Azure AKS Cluster that has specifically been provisioned with FPGA enabled Azure Virtual Machines (Standard PBS Family vCPU).  

This implementation seeks to take it a step further by enhancing the initial FPGA-Enabled Web Service
by adding a JQuery Mobile enabled Web client. The client can then be used to further test the ML Web Service by allowing the user to:
  * Visually select images (from any desktop or mobile device).
  * Submit the image to the ML web Service hosted on a FPGA-enabled AKS Cluster.
  * Receive up to (5) predictions (ordered by probability).
  * Prediction timing data for the FPGA Web Service Call. 

This repo contains extensions to previous work from these sources:  

 * Microsoft Azure Machine Learning Hardware Accelerated Models Powered by Project Brainwave
   https://github.com/Azure/aml-real-time-ai

 * Deploy a model as a web service on an FPGA with Azure Machine Learning service
   https://docs.microsoft.com/en-us/azure/machine-learning/service/how-to-deploy-fpga-web-service

Note that the Machine Learning model that is deployed to the Azure FPGA-enabled AKS Cluster is based upon a set of (1000) images that have been previously usied to train the model. You can see a list of these images at the URL below:
 * https://raw.githubusercontent.com/Lasagne/Recipes/master/examples/resnet50/imagenet_classes.txt



Below is a high-level overview of the Architecture and the (2) basic steps to create this solution:

![Image description](Architecture.png)

## Practical Uses
There are many commercial and consumer scenarios that can benefit from this type of fast image recognition/prediction capability.
For example, many people may not be able to distinguish between certain animal species, like poisonous snakes for example.


![Image description](FPGA_Predict_4_GarterSnake.png)  ![Image description](FPGA_Predict_3_GreenMamba.png)


