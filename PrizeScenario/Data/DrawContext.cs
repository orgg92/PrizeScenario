using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using PrizeScenario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrizeScenario.Data
{
    public class DrawContext : DbContext
    {
        public DrawContext(DbContextOptions<DrawContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionStringBuilder = new SqliteConnectionStringBuilder { DataSource = "users.db" };
            var connectionString = connectionStringBuilder.ToString();
            var connection = new SqliteConnection(connectionString);

            optionsBuilder.UseSqlite(connection);


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Participant>().HasData(
                new Participant { UserId = 1, FirstName = "John", LastName = "Doe", PostCode = "T35710" },
                new Participant { UserId = 2, FirstName = "Jane", LastName = "Doe", PostCode = "T35711" },
                new Participant { UserId = 3, FirstName = "Joe", LastName = "Smith", PostCode = "T35710" },
                new Participant { UserId = 4, FirstName = "Jane", LastName = "Smith", PostCode = "T35710" },
                new Participant { UserId = 5, FirstName = "Sam", LastName = "Fisher", PostCode = "T35710" },
                new Participant { UserId = 6, FirstName = "Wonder", LastName = "Woman", PostCode = "T35710" },
                new Participant { UserId = 7, FirstName = "Patrick", LastName = "Star", PostCode = "T35710" },
                new Participant { UserId = 8, FirstName = "Patrick", LastName = "Stewart", PostCode = "T35710" },
                new Participant { UserId = 9, FirstName = "Spongebob", LastName = "Squarepants", PostCode = "T35710" },
                new Participant { UserId = 10, FirstName = "Pete", LastName = "Armstrong", PostCode = "T35710" });
        }

        public virtual DbSet<Participant> Participants { get; set; }
    }
}
