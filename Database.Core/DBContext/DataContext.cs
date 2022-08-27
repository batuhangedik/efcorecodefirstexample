using Database.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Database.Core.DBContext
{
    public class DataContext : DbContext
    {
        /// <summary>
        /// Collection of Room entities
        /// </summary>
        public DbSet<RoomDB> Rooms { get; set; }

        /// <summary>
        /// Collection of Reservation entities
        /// </summary>
        public DbSet<ReservationDB> Reservations { get; set; }

        /// <summary>
        /// Collection of Customer entities
        /// </summary>
        public DbSet<CustomerDB> Customers { get; set; }

        /// <summary>
        /// Collection of Employee entities
        /// </summary>
        public DbSet<EmployeeDB> Employees { get; set; }

        /// <summary>
        /// Collection of Departmen entities
        /// </summary>
        public DbSet<DepartmentDB> Departments { get; set; }

        /// <summary>
        /// Select and configure data source
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = ..\HotelCodeFirst.db", options =>
            {
                options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
            });
            base.OnConfiguring(optionsBuilder);
        }

        /// <summary>
        /// Configures the model
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ReservationDB>(entity => 
            { 
                entity.HasIndex(e => e.Id); 
            });

            modelBuilder.Entity<DepartmentDB>(entity =>
            {
                entity.HasIndex(e => e.Id);
            });
        }

    }
}
