# ASP Net MVC Clean Architecture


## _Application of the Clean Architecture Design Philosophy in ASP Net MVC_
![](https://img.shields.io/badge/Code-CSharp-informational?style=flat&logo=c-sharp&logoColor=white&color=blue)
![](https://img.shields.io/badge/Code-.NET%20Core%206-informational?style=flat&logo=dotnet&logoColor=white&color=blue)

This MVC project is based on the project available at the [Macoratti Youtube Channel.](https://www.youtube.com/channel/UCoqYHkQy8q5nEMv1gkcZgSw)


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