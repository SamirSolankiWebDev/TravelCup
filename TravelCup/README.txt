Program name:TravelCup
Program purpose: To review the components of an ASP.NET MVC application
Program suthor: Samir Solanki
Date Created: 2022-09-14 [ISO date format]

1050:FirstStep: Today I Created a new application of ASP.net MVC in .NET core 3.1 framework authentication - Individual Account.
Selected Razor runtime.. will this aactually work ! let us test this and see... [it didnt worked]

1100 - Let execute the application
1105 - Oh it didnt worked reason is This site can't be reached https://localhost:44370/
 Let us try to fix and see if it work
 - Let us open launchSetting.json../.. line no 7 ans comment
 // "sslPort":44370 //

 After done the comment on // "sslPort":44389 // this Line the code started running. I got the Welcome Screen on browser This link is
 http://localhost:46966/

 All done--
 
  1121: Kept the application running ... testing Razor compile...
 change some content..... index.cshtml - from "Welcome" to "Hello World"........
 VS19 didnt seem to push ... but refereshed the browser and new context displayed

 ...../////////************ Part 2 .. Doing new chnages as per the part 2 documents.. ********///////////

 - Adding new controller
 - Right click on "Controller" folder and add the new controller Given name "HelloWorldController.cs"
 - Now you can find the new controller "HelloWorldController.cs" inside "Controllers" Folder

 - In HelloWorldController I have added the new code ad per the documents..
 - Inside public class... added public string Index and return .."This is my default action..."

 - Added new Method Welcome...
 and added return "This is the Welcome action method..."

 - After running the code and calling the link http://localhost:34699/HelloWorld
  It didnt worked ...
  - Because i have not added the "using System.Text.Encodings.Web;" include in my "HelloWorldController.cs"....
  - After adding this code It worked and gave me output... "This is my default action..."

  - .. Added new code in HelloWorldController.cs
    .. added new 2 parameters in the line of code name and numTimes (Count) .. this code shows the number of count of browser refresh.


    - I replaced the parameter  from numTimes to ID
 public string Welcome(string name, int ID = 1)...
 and run the Code..
 Added this paramter in link .. http://localhost:46966/HelloWorld/Welcome?name=Samir&ID=14
 and got the output as ..Hello Samir, ID: 14..


 .......//////************. Part 3... To Add the View to ASP>NET MVC app... *********/////////////

 - Create a new Folder inside Views Folder.. and give the name as "HelloWorld"..
 - Cretae a new File insde.. View/HelloWorld Folder and select as RazorView Empty and give the name as "Index.cshtml"

 - Before creating the View Replace the Code in HelloWorldController.cs file

 public IActionResult Index()
{
    return View();
}

-Add the New Folder Inside Views and name it as "HelloWorld"

- Added the File As Index.cshtml
- Add the code inside the file
@{
    ViewData["Title"] = "Index";
}

<h2>Index</h2>

<p>Hello from our View Template!</p>

- Let us run the code and see the output......

- Let us Change in the Layout.cshtml, which is inside View/Shared/Layout.cshtml Folder.....

-Let us run the code...

- I cahanged the Title name to "Cup App"
 and also changed in footer class....

 - - Now we can see the Title have changed to what we have given as CupApp....

 --Done Changes in HelloWorldController.cs File

 -- Added the new file "Welcome.cshtml" inside View/HelloWorld/Welcome.cshtml

 -Let us Run the Code and run this link http://localhost:46966/HelloWorld/Welcome?name=Samir&numtimes=5

  After done this step commit the code and Go to next step to part 4.....


 ......///************ Part 4... To Add a Modelto an ASP>NET MVC app... **********///////

 - Added the "Cup.cs" Class Inside Models Folder..

 - Added the Datatype Field in this Class of Cup.cs

 -- Install the New Package
 Install-Package Microsoft.EntityFrameworkCore.SqlServer
 and run

 -Added the New Class MvcCupContext.cs Inside Data Folder.....

 Done Changes in Startup.cs

 - Done Changes in appsetting.json File ...
 - Lets Us Run the File

 -Every Time while running the ""Add-Migration InitialCreate"" I use to get ERROT Saying no DB found
 or i used to get more then one DB found

 - I RUN this following code
 dotnet ef migrations add InitConfigration -c ConfigurationDbContext -o Data/Migrations/IdentityServer/Configuration

 It started Running, It Worked for me and Migration tooked place.

 - Still my Code didnt worked because it was redirected to wrong directory.

 - Add-Migration InitialCreate -Context MvcTravelCupContext 
   After calling this line of code in my console, The code execute as per the documents and it got Initialise.

   - I updated the code by writing 
   -Update-Database -Context MvcTravelCupContext  and it databse got updated.


   -After InitialCreate Class I Debug the code and it didnt gave me error After lot of implementation.


    ......///************ Part 5...work with a database in an ASP.NET Core MVC app **********///////


   - Implemented the Seed data which has 10 static data for the table inside database.

   - Cretaed an SeedData.cs inside Models folder.

   - After creting SeedData I have Initialize it inside Program.cs

   - I then debug the code and run the application but fail to get the seed data by refreshing the code.

   - So i tested the application by adding some data inside the application. 


    ......///************ Part 6...Controller methods and views in ASP.NET Core **********///////

    - In this Step I have add the code inside the "TravelCup.cs" which is inside Models folder.

    In this step i have added code for Date and Decimal data type.

    -Added more changes according to the Documents in Models.

    - In this I have created a tablle which shows error when the field is empty.

        ......///************ Part 7...Add search to an ASP.NET Core MVC app **********///////

        -In this File i HVe changed the code in Controllers/TravelCupController.cs

        - public async Task<IActionResult> Index(string searchString)

        -Done Change in Startup.cs

        - Created the Search Bar on the top and tested the application. 

        -Made Two Search bar and done the changes in Index.cshtml File.

        - After changes tested the application. It showed the result as per the search.


         ......///************ Part 8...add a new field to an ASP.NET Core MVC app **********///////

         - In this Code i have added the Code for Rate in each and every field.s

           ......///************ Part 9...Add validation rules to the movie model **********///////

           Added Validation Code and tested the Application.
