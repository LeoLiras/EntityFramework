using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Models.FluentAPI
{
    public class eCommerceFluentContext : DbContext
    {
        public eCommerceFluentContext(DbContextOptions<eCommerceFluentContext> options) : base(options)
        {
        }

        #region Conexão sem ambiente

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=eCommerce;Integrated Security=True;");
        //}
        #endregion

        public DbSet<User>? Users { get; set; }
        public DbSet<Contact>? Contacts { get; set; }
        public DbSet<SendAddress>? SendAddresses { get; set; }
        public DbSet<Department>? Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("TB_USUARIOS");
            modelBuilder.Entity<User>().Property(x => x.RG).HasColumnName("REGISTRO_GERAL").HasMaxLength(10).HasDefaultValue("RG-AUSENTE").IsRequired();
            modelBuilder.Entity<User>().Ignore(x => x.Sex);
            modelBuilder.Entity<User>().Property(x => x.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<User>().HasIndex(x => x.CPF).IsUnique().HasFilter("[CPF] is not null" ).HasDatabaseName("CPF Unique");

            modelBuilder.Entity<User>().HasKey(x => new { x.Id, x.CPF });


            modelBuilder.Entity<User>().HasOne(x => x.Contact).WithOne(x => x.User).HasForeignKey<Contact>(x => x.UserId);
            modelBuilder.Entity<User>().HasMany(x => x.SendAddresses).WithOne(x => x.User).HasForeignKey(x => x.UserId);
            modelBuilder.Entity<User>().HasMany(x => x.Departments).WithMany(x => x.Users);

        }
    } 
}
