# WCTC_EFTutorial_Pets

## Sample commands
````
dotnet tool update --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.Extensions.Configuration.Json
dotnet ef migrations add InitialCreate
dotnet ef database update InitialCreate
dotnet ef database update 0
dotnet ef migrations remove
````
