# _Pierre's Sweet and Savory Treats_ 

#### _C# Identity Solo Project For Epicodus_ 
#### _DATE 01.15.2021_

#### By _**Tawnee Harris**_

## Description

This application will allow users to log in and create, update, and delete instances of treats and flavors.  

## Setup/Installation Requirements

Software Requirements
* An internet browser of your choice; I prefer Chrome
* A code editor; I prefer VSCode
* .NET Core
* MySQL
* MySQL Workbench

Open by Downloading or Cloning
* Navigate to <https://github.com/tawneeh/PierresTreats.Solution.git>
* Download this repository to your computer by clicking the green Code button and 'Download Zip'
* Or clone the repository

AppSettings
* This project requires an AppSettings file. Create your `appsettings.json` file in the main `PierresTreats` directory. 
* Format your `appsettings.json` file as follows including your unique password that was created at MySqlWorkbench installation:
```
{
  "ConnectionStrings":{
      "DefaultConnection": "Server=localhost;Port=3306;database=tawnee_harris_1;uid=root;pwd=<YourPassword>;"
  }
}
```
* Update the Server, Port, and User ID as needed.

Import Database using Entity Framework Core
* Navigate to PierresTreats.Solution/PierresTreats and type `dotnet ef migrations add <MigrationName>` into the terminal
* Then, type `dotnet ef database update` into the terminal to create your database tables.

Launch this Application
* Navigate to PierresTreats.Solution/PierresTreats and type `dotnet restore` into the terminal
* Then, in the same project folder, type `dotnet build` into the terminal followed by `dotnet run`
* Peruse this application at your leisure

## Known Bugs

This application has no known bugs. 

## Support and contact details

Please feel free to reach out to Tawnee anytime at <tawneeh@icloud.com>

## Technologies Used

* C#
* Razor
* Entity Framework Core
* MySql
* MySql Workbench
* Identity

### License

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

Copyright (c) 2021 **_Tawnee Harris_**