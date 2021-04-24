# Automapper

##Automapper in .NET Core

We will create a project in .NET Core using dotnet cli and will use visual studio code as the IDE.

Go to any directory where you want to create this project.

We are using powershell to setup this project.

>`PS E:/VSCODE/NETProjects>mkdir Automapper`

>`PS E:/VSCODE/NETProjects>cd Automapper`

Lets create a solution in Automapper folder.

>`PS E:/VSCODE/NETProjects>Automapper>dotnet new sln`

Lets create a project in the Automapper folder.

>`PS E:/VSCODE/NETProjects>Automapper>dotnet new webapi -o Automapper.API`

Lets add the project in the solution file because as of now they are disconnected to each other.

>`dotnet sln add Automapper.API/Automapper.API.csproj`

Now lets open Automapper folder in vscode.

>`PS E:/VSCODE/NETProjects>Automapper>code .`

Switch to project folder and install automapper.

>`PS E:/VSCODE/NETProjects>Automapper>cd Automapper.API`

>`PS E:/VSCODE/NETProjects>Automapper>Automapper.API>dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection`

We setup our project, now lets write some code. First of all delete the weather api controller and weather api class as we don't need this.

Lets create two folders Models and DTO.
Models will have classes that will exactly match with the database tables and DTO will have classes which need to pass to the client.

In our case we are using Employee class in Models folder and EmployeeDTO in DTO folders.

