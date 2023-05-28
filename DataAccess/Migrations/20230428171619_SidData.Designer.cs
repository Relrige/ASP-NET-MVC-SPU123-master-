﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Data;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(ShopDbContext))]
    [Migration("20230428171619_SidData")]
    partial class SidData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SPU123_Shop_MVC.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Electronics",
                            City = "Rivne",
                            Contact = "0312921399",
                            Description = "iPhone X laalalala",
                            Price = 650m,
                            Title = "iPhone X"
                        },
                        new
                        {
                            Id = 2,
                            Category = "Sport",
                            City = "Rivne",
                            Contact = "04122411399",
                            Description = "PowerBall laalalala",
                            Price = 45m,
                            Title = "PowerBall"
                        },
                        new
                        {
                            Id = 3,
                            Category = "Clothes",
                            City = "Rivne",
                            Contact = "0675586399",
                            Description = "Nike T-Shirt laalalala",
                            Price = 189m,
                            Title = "Nike T-Shirt"
                        },
                        new
                        {
                            Id = 4,
                            Category = "Electronics",
                            City = "Rivne",
                            Contact = "097642399",
                            Description = "Samsung S23 laalalala",
                            Price = 1200m,
                            Title = "Samsung S23"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}