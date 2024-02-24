﻿// <auto-generated />
using HotelAPI.MyAppDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HotelAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HotelAPI.Models.Hotel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            Id = "332d0d04-a59e-47e9-b18b-6d140a9f96ad",
                            Name = "Hills"
                        },
                        new
                        {
                            Id = "00b49f65-b472-49a6-bdfc-0890ee1c9f37",
                            Name = "Sofia"
                        },
                        new
                        {
                            Id = "907affb9-d69b-4467-a1ad-dbd08e50b215",
                            Name = "Nexus"
                        },
                        new
                        {
                            Id = "4f83789d-d01e-47bb-8c4a-05b0b49c86b1",
                            Name = "Nessebar"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}