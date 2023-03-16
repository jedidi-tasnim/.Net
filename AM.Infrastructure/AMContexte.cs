using AM.ApplicationCore.Domain;
using AM.Infrastructure.Configuration;
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
        // public DbSet<Test2> test2s { get; set; }
        public DbSet<Seat> seats  { get; set; }
        public DbSet<Section> sections  { get; set; }
        public DbSet<Reservation> reservations   { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer(@"Data Source=(localDB)\MsSqlLocalDb; initial catalog=TasnimJedidi;Integrated Security=true ");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FlightConfiguration());
         //   modelBuilder.ApplyConfiguration(new PassengerConfiguration());
            modelBuilder.Entity<Passenger>().ToTable("Passengers");
            modelBuilder.Entity<Staff>().ToTable("Staffs");
            modelBuilder.Entity<Traveller>().ToTable("Travellers");
            modelBuilder.ApplyConfiguration(new TicketConfiguration());
            modelBuilder.ApplyConfiguration(new ReservationConfiguration());
            modelBuilder.ApplyConfiguration(new SeatConfiguration());
           
            




        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>().HaveMaxLength(120);
            configurationBuilder.Properties<DateTime>().HaveColumnType("date");
            configurationBuilder.Properties<Double>().HaveColumnType("float");   
        }


       


    }
}
