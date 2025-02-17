using EFProject.Infra.Context;
using EFProject.Infra.DataGenerators;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
var connStr = configuration.GetConnectionString("SqlServer");

var optionsBuilder = new DbContextOptionsBuilder<MovieDbContext>();

optionsBuilder
	.ConfigureWarnings(warnings =>
	{
		warnings.Log(Microsoft.EntityFrameworkCore.Diagnostics.RelationalEventId.PendingModelChangesWarning);
	});

optionsBuilder.UseSqlServer(connStr, options =>
{
	options.MigrationsHistoryTable("_EFMigrationHistory", schema: "ef");
	options.CommandTimeout(5_000);
	//options.EnableRetryOnFailure(maxRetryCount: 5);
});

optionsBuilder.UseAsyncSeeding(async(context,_, ct) =>
{
	var movieExist = await context.Movies.AnyAsync(cancellationToken:ct);
	if (movieExist) return;

	var movies = DataGenerator.GenerateMovies(10);
	context.Movies.AddRange(movies);

	await context.SaveChangesAsync(ct);
	Console.WriteLine("Movies added");
});


var dbContext = new MovieDbContext(optionsBuilder.Options);
await dbContext.Database.EnsureCreatedAsync();

dbContext.Database.OpenConnection();

await EnsureMigrations();

Console.WriteLine("DONE!");

async Task EnsureMovieData()
{
	var movieExist=await dbContext.Movies.AnyAsync();
	if (movieExist) return;

	var movies=DataGenerator.GenerateMovies(10);
	dbContext.Movies.AddRange(movies);

	await dbContext.SaveChangesAsync();
	Console.WriteLine("Movies added");
}


async Task EnsureMigrations()
{
	var migrations=await dbContext.Database.GetPendingMigrationsAsync();

	if (migrations.Any())
	{
		Console.WriteLine("Migrations Applying...");
		await dbContext.Database.MigrateAsync();
		Console.WriteLine("Migrations Applied...");
	}
}

Console.ReadLine();