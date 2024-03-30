using Microsoft.EntityFrameworkCore;
using UserData.Models;

namespace UserData.Data
{
	public class AppDbContext : DbContext
	{

		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
		public DbSet<User> Users { get; set; }


		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			// Specify that we are using SQLite and provide the connection string.
			// This connection string points to a file named "mydatabase.db" in the same directory as the application.
			optionsBuilder.UseSqlite("Data Source=mydatabase.db");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<User>().HasData(
				new User
				{
					PersonalId = "197001152345",
					Name = "Johan Nilsson",
					PhoneNumber = "07234567890",
					Email = "johan.nilsson@test.com"
				});

		}

	}
}
