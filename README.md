# ASP Net MVC Clean Architecture


## _An Web Api for learning purposes with EF + MySql and Angular FrontEnd_
![](https://img.shields.io/badge/Code-CSharp-informational?style=flat&logo=c-sharp&logoColor=white&color=blue)
![](https://img.shields.io/badge/Code-.NET%20Core%206-informational?style=flat&logo=dotnet&logoColor=white&color=blue)

This WebApi is build based on the amazing ASP .NET Core Guide available at https://code-maze.com/net-core-series/

I took this guide for learning the core aspects of a robust WEBApi with Repository Pattern and connection to MySQL Database.

As always, as I'm going through other interesting tools and concepts, I probably add in this project (pagination, Elasticsearch, ...)

![Database-Model](mysql_model.png "MySQL Modelling of the Database")

## Objectives

Develop a robust and scalable WebAPI in ASP .NET with consumption in an Angular FrontEnd

* Work with C# and ASP Net Development
* Work with Entity Framework + MySQL (Dockerized)
* Work with Docker Container
* Develop a scalable WebAPI with Repository Pattern
* Use NLog for logging errors to file (and stdout when deployed)
* Work with Angular Framework
* Work with GIT
* Work with relational database (SQL)
* ... Should add more things down the road...

## To-do

- JWT Authentication and Authorization
- Angular FrontEnd
- Pagination, ElasticSearch
- Dockerize the app
- Deploy the final app (Probably in the Azure Platform)
- Implement Unity Testing

## Dependencies

* Entity Framework
* NLog
* Pomelo MySql package
* AutoMapper

## Run

## Apply Initial Migration and Update Database

## Apply Migration
```sh
dotnet ef migrations add InitialCreate --project mvcCleanArch.Infra.Data -s mvcCleanArch.MVC -c ApplicationDbContext --verbose
```

## Update Database
```sh
 dotnet ef database update --project mvcCleanArch.Infra.Data -s mvcCleanArch.MVC -c ApplicationDbContext --verbose
```