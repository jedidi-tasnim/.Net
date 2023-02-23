using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure
{
    public class AMContexte:DbContext
    {
        public DbSet<Flight> flights{ get; set; }
        public DbSet<Passenger> passengers{ get; set; }
       // public DbSet<Plane> planes { get; set; }
       // public DbSet<Staff> staff { get; set; }
        public DbSet<Traveller> travellers { get; set; }
        public DbSet<Test2> test2s { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localDB)\MsSqlLocalDb; initial catalog=TasnimJedidi;Integrated Security=true ");
        }
    }
}
