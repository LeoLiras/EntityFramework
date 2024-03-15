﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eCommerceOffice;

#nullable disable

namespace eCommerceOffice.Migrations
{
    [DbContext(typeof(eCommerceOfficeContext))]
    [Migration("20240314093011_EmployeeToVehicle")]
    partial class EmployeeToVehicle
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EmployeeTeam", b =>
                {
                    b.Property<int>("EmployeesId")
                        .HasColumnType("int");

                    b.Property<int>("TeamsId")
                        .HasColumnType("int");

                    b.HasKey("EmployeesId", "TeamsId");

                    b.HasIndex("TeamsId");

                    b.ToTable("EmployeeTeam");
                });

            modelBuilder.Entity("eCommerceOffice.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Mari"
                        },
                        new
                        {
                            Id = 2,
                            Name = "João"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Pedro"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Vanessa"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Thiago"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Vivian"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Renalla"
                        });
                });

            modelBuilder.Entity("eCommerceOffice.Models.EmployeeSector", b =>
                {
                    b.Property<int>("SectorId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("SectorId", "EmployeeId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeesSectors");

                    b.HasData(
                        new
                        {
                            SectorId = 1,
                            EmployeeId = 1,
                            Created = new DateTimeOffset(new DateTime(2024, 3, 14, 6, 30, 10, 892, DateTimeKind.Unspecified).AddTicks(9081), new TimeSpan(0, -3, 0, 0, 0))
                        },
                        new
                        {
                            SectorId = 2,
                            EmployeeId = 2,
                            Created = new DateTimeOffset(new DateTime(2024, 3, 14, 6, 30, 10, 892, DateTimeKind.Unspecified).AddTicks(9109), new TimeSpan(0, -3, 0, 0, 0))
                        },
                        new
                        {
                            SectorId = 3,
                            EmployeeId = 3,
                            Created = new DateTimeOffset(new DateTime(2024, 3, 14, 6, 30, 10, 892, DateTimeKind.Unspecified).AddTicks(9111), new TimeSpan(0, -3, 0, 0, 0))
                        },
                        new
                        {
                            SectorId = 4,
                            EmployeeId = 4,
                            Created = new DateTimeOffset(new DateTime(2024, 3, 14, 6, 30, 10, 892, DateTimeKind.Unspecified).AddTicks(9112), new TimeSpan(0, -3, 0, 0, 0))
                        },
                        new
                        {
                            SectorId = 4,
                            EmployeeId = 5,
                            Created = new DateTimeOffset(new DateTime(2024, 3, 14, 6, 30, 10, 892, DateTimeKind.Unspecified).AddTicks(9114), new TimeSpan(0, -3, 0, 0, 0))
                        },
                        new
                        {
                            SectorId = 3,
                            EmployeeId = 6,
                            Created = new DateTimeOffset(new DateTime(2024, 3, 14, 6, 30, 10, 892, DateTimeKind.Unspecified).AddTicks(9116), new TimeSpan(0, -3, 0, 0, 0))
                        },
                        new
                        {
                            SectorId = 2,
                            EmployeeId = 7,
                            Created = new DateTimeOffset(new DateTime(2024, 3, 14, 6, 30, 10, 892, DateTimeKind.Unspecified).AddTicks(9117), new TimeSpan(0, -3, 0, 0, 0))
                        });
                });

            modelBuilder.Entity("eCommerceOffice.Models.EmployeeVehicle", b =>
                {
                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("InitialBondDate")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("EmployeeId", "VehicleId");

                    b.HasIndex("VehicleId");

                    b.ToTable("EmployeeVehicle");
                });

            modelBuilder.Entity("eCommerceOffice.Models.Sector", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sectors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "IT"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Logistica"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Financeiro"
                        },
                        new
                        {
                            Id = 4,
                            Name = "ADM"
                        });
                });

            modelBuilder.Entity("eCommerceOffice.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "A1"
                        },
                        new
                        {
                            Id = 2,
                            Name = "A2"
                        },
                        new
                        {
                            Id = 3,
                            Name = "A3"
                        },
                        new
                        {
                            Id = 4,
                            Name = "A4"
                        },
                        new
                        {
                            Id = 5,
                            Name = "A5"
                        });
                });

            modelBuilder.Entity("eCommerceOffice.Models.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Identification")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vehicles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Identification = "ABC123",
                            Name = "Mobi"
                        },
                        new
                        {
                            Id = 2,
                            Identification = "BCA324",
                            Name = "Argo"
                        },
                        new
                        {
                            Id = 3,
                            Identification = "ASD342",
                            Name = "Onix"
                        },
                        new
                        {
                            Id = 4,
                            Identification = "JKL123",
                            Name = "Celta"
                        },
                        new
                        {
                            Id = 5,
                            Identification = "POJ876",
                            Name = "HB20"
                        });
                });

            modelBuilder.Entity("EmployeeTeam", b =>
                {
                    b.HasOne("eCommerceOffice.Models.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eCommerceOffice.Models.Team", null)
                        .WithMany()
                        .HasForeignKey("TeamsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eCommerceOffice.Models.EmployeeSector", b =>
                {
                    b.HasOne("eCommerceOffice.Models.Employee", "Employee")
                        .WithMany("EmployeesSectors")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eCommerceOffice.Models.Sector", "Sector")
                        .WithMany("EmployeesSectors")
                        .HasForeignKey("SectorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Sector");
                });

            modelBuilder.Entity("eCommerceOffice.Models.EmployeeVehicle", b =>
                {
                    b.HasOne("eCommerceOffice.Models.Employee", "Employee")
                        .WithMany("EmployeesVehicles")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eCommerceOffice.Models.Vehicle", "Vehicle")
                        .WithMany("EmployeesVehicles")
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("eCommerceOffice.Models.Employee", b =>
                {
                    b.Navigation("EmployeesSectors");

                    b.Navigation("EmployeesVehicles");
                });

            modelBuilder.Entity("eCommerceOffice.Models.Sector", b =>
                {
                    b.Navigation("EmployeesSectors");
                });

            modelBuilder.Entity("eCommerceOffice.Models.Vehicle", b =>
                {
                    b.Navigation("EmployeesVehicles");
                });
#pragma warning restore 612, 618
        }
    }
}