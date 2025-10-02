using Microsoft.EntityFrameworkCore;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region Commands
/*
dotnet ef migrations add InitialSchema --project StudentManagement.Console --output-dir Data/Migrations 

dotnet ef migrations script -o Data/Migrations/V1__InitialSchema.sql --project StudentManagement.Console
  */
#endregion