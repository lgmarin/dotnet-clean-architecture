# ASP Net MVC Clean Architecture


## _Application of the Clean Architecture Design Philosophy in ASP Net MVC_
![](https://img.shields.io/badge/Code-CSharp-informational?style=flat&logo=c-sharp&logoColor=white&color=blue)
![](https://img.shields.io/badge/Code-.NET%20Core%206-informational?style=flat&logo=dotnet&logoColor=white&color=blue)

This MVC project is based on the project available at the [Macoratti Youtube Channel.](https://www.youtube.com/channel/UCoqYHkQy8q5nEMv1gkcZgSw)

## Clean Architecture Project Structure

![ASP .Net Core Clean Architecture Structure](/img/aspc_cleanarq18.png "ASP .Net Core Clean Architecture Structure")
[Image Available here.](https://docs.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/common-web-application-architectures)

### Application

Contains the Services, View Models and Interfaces that represents the general business model of the project.

The interfaces includes abstractions for operations that will be performed using the Infrastructure layer, such as data access, file system access, networking, and so on.

Dependencies: Domain

### Domain

Contains the Entities and Interfaces of the Project.

Dependencies: None

### Infra Data

Contains the Data Access Logic with DataContext, Migrations, and Data Models.

Dependencies: Domain

### Infra Data

Contains the Inversion of Control Logic, grants access to the other layers via Dependency Injection.

Dependencies: Domain, Application, Infra.Data

## Dependencies

* Entity Framework


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