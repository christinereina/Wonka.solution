# <h1 align = "center"> Christine's Chocolate Factory

<!-- <img align = "center">

![Preview](./Factory/wwwroot/) -->

##### <h4 align = "center">  Authentication with Identity, Indepedent Project for Epicodus, 08.14.2020

#### <h4 align = "center"> By _**Christine Augustine**_

## Description

Welcome to what was formerly known as Willy Wonka's Chocolate Factory...soon to be Christine's Chocolate Factory!

---

Her Chocolate Factory will require user authentication. Customers should be able to log in and log out. Only logged in Customers will have the ability to *create, update and delete* an order. 

All Customers should be able to have read functionality.

This project will contain a many-to-many relationship between **Treats** and **Flavors**. A treat can have many flavors (such as sweet, savory, spicy, or creamy) and a flavor can have many treats. For instance, the "sweet" flavor could include Scrumdidilyumptious Bar, Sizzler, a Triple Cream Cup, and so on. 

Once logged in the customer should be able to navigate to a splash page that lists all treats and flavors. 

Customers should be able to click on an individual treat or flavor to see all the treats/flavors that belong to it.


## Setup/Installation Requirements 

### 1. Install .NET Core 

Download .NET Core SDK from Microsoft Corp  (**[macOS](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.106-macos-x64-installer) | [Windows OS](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.203-windows-x64-installer)**)

### Install dotnet script

Enter the command `dotnet tool install -g dotnet-script` in Terminal 

### 2. Clone this [repository](https://github.com/christinereina/Wonka.Solution) from GitHub
```
cd desktop
git clone https://github.com/christinereina/Wonka.Solution
cd Wonka.Solution
```
### 3. Install the necessary dependencies to build the project, run the following commands in your Terminal:
```
dotnet restore
dotnet build
dotnet run
```
### 4. Create the database and project tables
```
dotnet ef migrations add Initial
dotnet ef database update
```
### 5. Starting the Server

Initialize a local server to run the project in your browser
```
dotnet watch run
```

If you are running the script locally, it will open the project in your browser window and shift the focus from the terminal to the browser. If not, you can copy and paste this address to view

```
http://127.0.0.1:5000
```


## Known Bugs

N/A as of 8.17.2020

## Support and contact details

Please feel free to contact the author through GitHub **[christinereina](https://github.com/christinereina)** with any feedback, questions or concerns.


## Technologies Used

* C# 
* .NET-Core 2.2
* ASP.NET Core MVC
* MySQL
* EF Core
* ASP.NET Core Identity
* Razor 2.2.0
* Visual Studio Code
* Git Version Control 
* GitHub

### License

This site is licensed under the [MIT](https://mit-license.org/) license.

Copyright (c) 2020 **Christine Augustine**