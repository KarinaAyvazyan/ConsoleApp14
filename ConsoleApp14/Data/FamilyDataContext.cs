using FamilyCreated.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FamilyCreated.Data
{
    public class FamilyDataContext:DbContext
    {
     
        public DbSet<Family> Families { get; set; }
        public DbSet<Person> Persons { get; }
        public DbSet<Animal> Animals { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=FamilyDb;Trusted_Connection=True;");
        }


    }
}
