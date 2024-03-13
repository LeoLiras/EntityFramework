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
            #region EmployeeSector
            modelBuilder.Entity<EmployeeSector>().HasKey(x => new { x.SectorId, x.EmployeeId });
            modelBuilder.Entity<EmployeeSector>().HasOne(x => x.Employee).WithMany(x=>x.EmployeesSectors).HasForeignKey(x => x.EmployeeId);
            modelBuilder.Entity<EmployeeSector>().HasOne(x => x.Sector).WithMany(x => x.EmployeesSectors).HasForeignKey(x => x.SectorId);
            //modelBuilder.Entity<Employee>().HasMany(x=>x.EmployeesSectors).WithOne(x=>x.Employee).HasForeignKey(x=>x.EmployeeId);
            //modelBuilder.Entity<Sector>().HasMany(x=>x.EmployeesSectors).WithOne(x=>x.Sector).HasForeignKey(x=>x.SectorId);
            #endregion

            #region Seeds
            modelBuilder.Entity<Employee>().HasData(
                new Employee() { Id = 1, Name = "Mari"},
                new Employee() { Id = 2, Name = "João" },
                new Employee() { Id = 3, Name = "Pedro" },
                new Employee() { Id = 4, Name = "Vanessa" },
                new Employee() { Id = 5, Name = "Thiago" },
                new Employee() { Id = 6, Name = "Vivian" },
                new Employee() { Id = 7, Name = "Renalla" }
            );

            modelBuilder.Entity<Sector>().HasData(
                new Sector() { Id = 1, Name = "IT"},
                new Sector() { Id = 2, Name = "Logistica" },
                new Sector() { Id = 3, Name = "Financeiro" },
                new Sector() { Id = 4, Name = "ADM" }
            );

            modelBuilder.Entity<EmployeeSector>().HasData(
                new EmployeeSector() { SectorId = 1, EmployeeId = 1, Created = DateTimeOffset.Now},
                new EmployeeSector() { SectorId = 2, EmployeeId = 2, Created = DateTimeOffset.Now },
                new EmployeeSector() { SectorId = 3, EmployeeId = 3, Created = DateTimeOffset.Now },
                new EmployeeSector() { SectorId = 4, EmployeeId = 4 ,Created = DateTimeOffset.Now },
                new EmployeeSector() { SectorId = 4, EmployeeId = 5 ,Created = DateTimeOffset.Now },
                new EmployeeSector() { SectorId = 3, EmployeeId = 6 ,Created = DateTimeOffset.Now },
                new EmployeeSector() { SectorId = 2, EmployeeId = 7 ,Created = DateTimeOffset.Now }
            );

            modelBuilder.Entity<Team>().HasData(
                new Team() { Id = 1, Name = "A1"},
                new Team() { Id = 2, Name = "A2" },
                new Team() { Id = 3, Name = "A3" },
                new Team() { Id = 4, Name = "A4" },
                new Team() { Id = 5, Name = "A5" }
            );
            #endregion

            #region Mapping EF Core 5+
            modelBuilder.Entity<Employee>().HasMany(x => x.Teams).WithMany(x => x.Employees);
            #endregion
        }
    }
}
