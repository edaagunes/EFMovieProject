using EFProject.Infra.Context;
using Microsoft.EntityFrameworkCore;

var dbContext = new MovieDbContext();

dbContext.Database.OpenConnection();

Console.Read();