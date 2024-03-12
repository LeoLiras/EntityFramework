using eCommerceOffice.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceOffice
{
    public class eCommerceOfficeContext : DbContext
    {
        public DbSet<Employee>? Employees { get; set; }
        public DbSet<EmployeeSector> EmployeesSectors { get; set; }
        public DbSet<Sector>? Sectors { get; set; }
        public DbSet<Team>? Teams { get; set; }
        public DbSet<Vehicle>? Vehicles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=eCommerceOffice;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeSector>().HasKey(x => new { x.SectorId, x.EmployeeId });
            modelBuilder.Entity<Employee>().HasMany(x=>x.EmployeesSectors).WithOne(x=>x.Employee).HasForeignKey(x=>x.EmployeeId);
            modelBuilder.Entity<Sector>().HasMany(x=>x.EmployeesSectors).WithOne(x=>x.Sector).HasForeignKey(x=>x.SectorId);
        }
    }
}
