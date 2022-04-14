mkdir [name of folder]
cd [name of folder]/
dotnet new webapp
(get out from name of folder) cd ..
dotnet new xunit -o instructor.Tests
dotnet sln add ./instructor/instructor.csproj
dotnet sln add ./instructor.Tests/instructor.Tests.csproj
dotnet add ./instructor.Tests/instructor.Tests.csproj reference ./instructor/instructor.csproj
//Create Models.cs under deliverycart
dotnet tool install --global dotnet-aspnet-codegenerator
cd (name of folder)instructor
dotnet add package Microsoft.EntityFrameworkCore.SQLite
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.InMemory
(window)dotnet aspnet-codegenerator razorpage -m Order -dc deliverycart.Data.Assignment3XTestsContext -udl -outDir Pages/Orders --referenceScriptLibraries -sqlite
dotnet aspnet-codegenerator razorpage -m Instructor -dc instructor.Data.InstructorTestContext -udl -outDir Pages/Instructors --referenceScriptLibraries -sqlite


dotnet run
//work on async method in dbContext and pages/Order/create
dotnet ef migrations add initial_migration
dotnet ef database update
dotnet run
dotnet build
cd ..
dotnet test ./deliverycart.Tests./deliverycart.Tests.csproj

