# RestClient
#I have created this project using .net framework
#Set up steps:
**********************Set up***************************************
Install .Netframework 4.5/Core 2.0 (based of your choice)
https://dotnet.microsoft.com/download/dotnet-framework/net452 -4.5.2 framewrork
Download VsCode/Visual Studio community edition and follow the steps from the installer pack
https://visualstudio.microsoft.com/downloads/  -For Visual studio 2017
https://code.visualstudio.com/ - For VS code
************************End******************************************
Clone this repo using below command:
git clone https://github.com/iankurmalik/RestClient
it will ask for your git credentials. If you don't have a git account, create one and then try cloning this repo
once cloned, go to the folder and click on RestClient.sol. It will open the project in Visual studio

# I have chosen it to be a console app to keep it concise
# Didn't add DI for the sake of brevity. I like Ninject for DI to resolve the dependencies at runtime.

***************Unit Testing**************8
I have not included unit test cases just for the sake of brevity
My approaCH FOR UNIT TEST WILL BE MOCKING THE HTTPCLIENT CLASS and check getData methode in weather adater class

***********************Json manipulation/querying and filtering**************************8888
Preferred LINQ over Deserialization and using model classes to process the data. This is just a matter of personal choice. 
I could present one with the deserializing approach if needed.
User Newtonsoft.Json for this purpose

For Automation my pick is as below:

For Java: 

I use RestAssured to test API. It has brilliant support for Json

Karate is equally good and am currently using it for API testing

For C#:

RestSharp is there which provides a good interfacing with API.


