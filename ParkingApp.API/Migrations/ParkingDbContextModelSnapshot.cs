﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParkingApp.API.Persistence;

namespace ParkingApp.API.Migrations
{
    [DbContext(typeof(ParkingDbContext))]
    partial class ParkingDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ParkingApp.API.Core.Domain.ParkingArea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal?>("Discount")
                        .HasColumnType("decimal(3, 2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<decimal>("WeekdaysHourlyRate")
                        .HasColumnType("decimal(4, 2)");

                    b.Property<decimal>("WeekendHourlyRate")
                        .HasColumnType("decimal(4, 2)");

                    b.HasKey("Id");

                    b.ToTable("ParkingAreas");
                });
#pragma warning restore 612, 618
        }
    }
}
