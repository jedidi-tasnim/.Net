using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configuration
{
    public class FlightConfiguration : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            builder.HasKey(f => f.FlightId);
            builder.ToTable("MyFlight");
            builder.Property(j => j.Departure).IsRequired().HasMaxLength(100).HasColumnName("VILLE DE DEPARTURE").HasDefaultValue("Hammamet").HasColumnType("nchar");
            builder.HasOne(f => f.plane).WithMany(p=>p.flights).HasForeignKey(f => f.PlaneFK).OnDelete(DeleteBehavior.SetNull);
            builder.HasMany(f => f.passengers).WithMany(f => f.flights).UsingEntity(p => p.ToTable("My Reservation"));

        }
    }
}
