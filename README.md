#Eau Claire Hair Salon

#### Meron G.Tekie

#### The application is built for Eau Claire Hair salon, It is abe to sort list of the clients with their corresponding Stylists based on the specialty of the Stylist.

## Technologies Used

- REPL(Read Evaluate Print Loop)

- README.md(Markdown)

- C#

- .NET 5.0

- ASP.NET Core MVC

- SQL

- Razor

- CRUD(Create Read Update Delete) View Model

- MySql Workbench

- Entity

- Linq

## Description

The application is built to provide a track of stylist's clients of Eau Claire Hair Salon assigned to the stylist according to the specialty of the stylist.

## Setup/Installation Requirements

- Fork this [Github](https://github.com/MeronTekie/EauCalireSalon.Solutions.git) link and clone it to your machine.

- Navigate through the directory.

- Open the project directory in coding frameworks(VSCode highly recommended ).

- Open Terminal and navigate to the type HairSalon and type _dotnet restore_.

- Type _dotnet build_ :this will help you to have all the technologies you need to run you test.

- create appsettings.json file and type the following to attach it to your SQL database

{ "ConnectionStrings": { "DefaultConnection": "Server=localhost;Port=3306;database=meron_tekie;uid=[ID];pwd=[PASSWORD];" } }

- Before commit and pushing to your remote repo make sure to add the _appsettings.json_ file to your .gitignore file for security relief.
- Open Your MySql workbench and navigate to Administrator

- Select DataImport /Restore

- Navigate to the Project Directory
- Imoprt the file name meron_tekie.sql

- You can change the name of the database to suit for you
  ,But make sure you update the name od dtabase in your appsettings.json file as well if so.

- Navigate back to the HairSalon directory and type _dotnet run_.

- This will enable you to test the functionality of the application to interact with the client.

- Navigate to the HairSalon directory and type _dotnet watch run_.

## Known Bugs

- You should first add a Stylist to add a Client because the application is designed to assign each client to a specific Stylist.

## License

[MIT](https://opensource.org/licenses/MIT)

- Copyright (c) Meron G. Tekie 2022
