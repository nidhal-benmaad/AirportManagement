using System;
using AM.ApplicationCore.Domain;
using AM.Infra.Configuration;
using Microsoft.EntityFrameworkCore;

namespace AM.Infra
{
	public class AMContext:DbContext // Classe générique qui offres des méthodes permetant
	{
		public AMContext()
		{
		}

		public DbSet <Plane> Planes { get; set; }

        public DbSet<Flight> Flights { get; set; }

        public DbSet<Staff> Staff { get; set; }

        public DbSet<Passenger> Passengers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
                Initial Catalog=AirportManagement;
                Integrated Security=true;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PlaneConfiguration());
            modelBuilder.ApplyConfiguration(new FlightConfiguration());


            modelBuilder.Entity<Passenger>().OwnsOne(p => p.Fullname, full =>
            {
                full.Property(p => p.Firstname).HasMaxLength(30).HasColumnName("passFirstName");
                full.Property(p => p.Lastname).HasMaxLength(30).HasColumnName("passLastName");
            });
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<DateTime>().HaveColumnType("date");
        }
    }
}

