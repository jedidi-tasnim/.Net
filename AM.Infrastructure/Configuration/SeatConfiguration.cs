using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configuration
{
    public class SeatConfiguration : IEntityTypeConfiguration<Seat>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Seat> builder)
        {
            builder.HasOne(s=>s.section).WithMany(t=>t.seats).HasForeignKey(t=>t.SectionFk).OnDelete(DeleteBehavior.SetNull);
        }
    }
}
