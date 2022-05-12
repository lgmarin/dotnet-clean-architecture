## Apply Initial Migration and Update Database

## Apply Migration
´´´sh
dotnet ef migrations add InitialCreate --project mvcCleanArch.Infra.Data -s mvcCleanArch.MVC -c ApplicationDbContext --verbose
´´´

## Update Database
´´´sh
 dotnet ef database update --project mvcCleanArch.Infra.Data -s mvcCleanArch.MVC -c ApplicationDbContext --verbose
´´´