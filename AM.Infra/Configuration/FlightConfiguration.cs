using System;
using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AM.Infra.Configuration
{
    public class FlightConfiguration : IEntityTypeConfiguration<Flight>
    {
        public FlightConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            builder.HasMany(p => p.Passengers).WithMany(p => p.Flights).
                UsingEntity(e => e.ToTable("FlightsPassengers"));

        }
    }
}

