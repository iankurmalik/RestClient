# RestClient

I have created this project using .net framework

Set up steps:

#**********************Set up***************************************

Install .Netframework 4.5/Core 2.0 (based of your choice)

https://dotnet.microsoft.com/download/dotnet-framework/net452 -4.5.2 framewrork

Download VsCode/Visual Studio community edition and follow the steps from the installer pack

https://visualstudio.microsoft.com/downloads/  -For Visual studio 2017

https://code.visualstudio.com/ - For VS code

#************************End******************************************

Clone this repo using below command:

git clone https://github.com/iankurmalik/RestClient

it will ask for your git credentials. If you don't have a git account, create one and then try cloning this repo

Once cloned, go to the folder and click on RestClient.sln. It will open the project in Visual studio

# I have chosen it to be a console app to keep it concise

# Didn't add DI for the sake of brevity. I like Ninject for DI to resolve the dependencies at runtime.

***************Unit Testing**************
I have added sample unit test cases. 
**************End************************
Used Xunit framework to Arrange, Act and Assert
Moq to mock the dependencies
Unit test is just checking for the non empty reesult fornow.
#***********************Json manipulation/querying and filtering**************************

Preferred LINQ over Deserialization and using model classes to process the data. This is just a matter of personal choice. 

I could present one with the deserializing approach if needed.

User Newtonsoft.Json for this purpose

For Automation my pick is as below:

For Java: 

I use RestAssured to test API. It has brilliant support for Json

Karate is equally good and am currently using it for API testing

For C#:

RestSharp is there which provides a good interfacing with API.y.

Lastly, the weather API are not really REST compliant. It only provided the access for limited resource with historical data only. 

Hence, you may see a lot of if else which could have been avoided if APIs were  built well and provided the data in accordance.

I understand these are open source API, so no complaints :)

Cheers
Ankur




