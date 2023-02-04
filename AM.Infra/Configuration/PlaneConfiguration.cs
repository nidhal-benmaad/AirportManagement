using System;
using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AM.Infra.Configuration
{
	public class PlaneConfiguration:IEntityTypeConfiguration<Plane>
	{
		public PlaneConfiguration()
		{
		}

     

        public void Configure(EntityTypeBuilder<Plane> builder)
        {
            builder.HasKey(p => p.PlaneId);
            builder.ToTable("MyPlanes");
            builder.Property(p => p.Capacity).HasColumnName("PlaneCapacity");

            builder.HasMany(f => f.Flights).WithOne(p => p.Plane).HasForeignKey(f => f.FlightId);
        }
    }
}

