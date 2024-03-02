﻿// <auto-generated />
using HotelAPI.MyAppDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HotelAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240225135929_InitialGuest")]
    partial class InitialGuest
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HotelAPI.Models.Guest", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Guests");
                });

            modelBuilder.Entity("HotelAPI.Models.Hotel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            Id = "e2bec708-3cdc-4206-84f5-59bbafcd9212",
                            City = "Los Angeles",
                            Country = "United States of America",
                            Name = "Hills"
                        },
                        new
                        {
                            Id = "104534a5-a298-40a5-b839-e3339182e0a5",
                            City = "Sofia",
                            Country = "Bulgaria",
                            Name = "Sofia"
                        },
                        new
                        {
                            Id = "0646e403-6c13-47e8-bed4-ab9146bbefae",
                            City = "Mexico",
                            Country = "Mexico",
                            Name = "Nexus"
                        },
                        new
                        {
                            Id = "1560779e-27f2-45b2-9c4f-35f803d73440",
                            City = "Nessebar",
                            Country = "Bulgaria",
                            Name = "Nessebar"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
