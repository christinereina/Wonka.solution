# <h1 align = "center"> Christine & Chocolate Factory

<!-- <img align = "center">

![Preview](./Factory/wwwroot/) -->

##### <h4 align = "center">  Authentication with Identity, Indepedent Project for Epicodus, 08.14.2020

#### <h4 align = "center"> By _**Christine Augustine**_

## Description

Welcome to Willy Wonka's Chocolate Factory...soon to be Christine's Chocolate Factory!

The Chocolate Factory will require user authentication. Customers should be able to log in and log out. Only logged in Customers will have the ability to create, update and delete an order functionality. 

All Customers should be able to have read functionality.This project will contain a many-to-many relationship between Treats and Flavors. A treat can have many flavors (such as sweet, savory, spicy, or creamy) and a flavor can have many treats. For instance, the "sweet" flavor could include Scrumdidilyumptious Bar, Sizzler, a Triple Cream Cup, and so on. 

Once logged in the customer should be able to navigate to a splash page that lists all treats and flavors. Customers should be able to click on an individual treat or flavor to see all the treats/flavors that belong to it.


## Setup/Installation Requirements 

1. Clone this [repository](https://github.com/christinereina/Wonka.Solution) from GitHub
2. Open the downloaded directory in a text editor of your choice. (VSCode, Atom, etc.)
3. Once you have the directory open, navigate to the top level of the directory and create a `appsettings.json` file which contains:
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=christine_augustine;uid=root;pwd=epicodus;"
  }
}
```
4. Then, install the REPL dotnet script, run dotnet tool `install -g dotnet-script` in your terminal.
5. To install the necessary dependencies, run the following commands:
```
dotnet restore
dotnet build
dotnet run
```
<h5 align = "right">

[see more detailed instructions for windows/mac](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql) 

## Specifications

User is greeted with a splash Welcome page. 

| Behavior   |   Input   |  Output | 
|----------|:-------------:|------:|

## Known Bugs

N/A

## Support and contact details

_Please feel free to contact the author through GitHub **[christinereina](https://github.com/christinereina)** with any feedback, questions or concerns._


## Technologies Used

* C# 
* .NET-Core 2.2
* ASP.NET Core MVC
* MySQL
* Entity Framework Core
* Visual Studio Code
* Git Version Control 
* GitHub

### License

*This site is licensed under the MIT license.*

Copyright (c) 2020 **Christine Augustine**