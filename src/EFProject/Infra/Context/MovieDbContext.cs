using EFProject.Infra.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace EFProject.Infra.Context
{
	public class MovieDbContext : DbContext
	{
		public DbSet<MovieEntity> Movies { get; set; }
		public DbSet<ActorEntity> Actors { get; set; }
		public DbSet<DirectorEntity> Directors { get; set; }
		public DbSet<GenreEntity> Genres { get; set; }

		public MovieDbContext(DbContextOptions options) : base(options)
		{
		}
		public MovieDbContext()
		{

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.HasDefaultSchema("ef");
			modelBuilder.ApplyConfigurationsFromAssembly(typeof(MovieEntityConfiguration).Assembly);
		}
	}

	public class DbContextFactory : IDesignTimeDbContextFactory<MovieDbContext>
	{
		public MovieDbContext CreateDbContext(string[] args)
		{
			var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
			var connStr = configuration.GetConnectionString("SqlServer");

			var optionsBuilder = new DbContextOptionsBuilder<MovieDbContext>();

			optionsBuilder.UseSqlServer(connStr, options =>
			{
				options.MigrationsHistoryTable("_EFMigrationHistory", schema: "ef");
				options.CommandTimeout(5_000);
				options.EnableRetryOnFailure(maxRetryCount: 5);
			});

			return new MovieDbContext(optionsBuilder.Options);
		}
	}
}
