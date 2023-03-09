using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configuration
{
    public class PassengerConfiguration : IEntityTypeConfiguration<Passenger>
    {
        public void Configure(EntityTypeBuilder<Passenger> builder)
        {
            builder.OwnsOne(P => P.FullName, p =>
            {

                p.Property(k=>k.FirstName).IsRequired().HasMaxLength(30).HasColumnName("FirstName");
                p.Property(k => k.LastName).IsRequired().HasMaxLength(30).HasColumnName("LastName");
            });
            builder.HasDiscriminator<int>("type").HasValue<Passenger>(0).HasValue<Staff>(2).HasValue<Traveller>(3);
           

        }
    }
}
