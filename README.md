# Fun with FPGAs
This repo contains extensions to previous work in this area - specifically from these sources:  

  Microsoft Azure Machine Learning Hardware Accelerated Models Powered by Project Brainwave
  https://github.com/Azure/aml-real-time-ai

  Deploy a model as a web service on an FPGA with Azure Machine Learning service
  https://docs.microsoft.com/en-us/azure/machine-learning/service/how-to-deploy-fpga-web-service

This working example seeks to extend the previous work that is outlined above to develop & deploy a Machine Learning Model (using a Databricks Python Notebook) to an Azure AKS Cluster that has specifically been provisioned with FPGA enabled Azure Virtual Machines (Standard PBS Family vCPU).

Here is a high-level overview of the Architecture and the (2) basic components::

![Image description](Architecture.png)
