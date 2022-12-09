﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ekzApi.Models;

#nullable disable

namespace ekzApi.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ekzApi.Models.Expense", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<double>("Cost")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Expenses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = 0,
                            Cost = 200.0,
                            Name = "Cinema ticket purchase",
                            Time = new DateTime(2022, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Category = 3,
                            Cost = 150.0,
                            Name = "Taxi ride",
                            Time = new DateTime(2022, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Category = 1,
                            Cost = 3000.0,
                            Name = "Rental",
                            Time = new DateTime(2022, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Category = 4,
                            Cost = 50.0,
                            Name = "Charity",
                            Time = new DateTime(2022, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            Category = 2,
                            Cost = 500.0,
                            Name = "Tracksuit purchase",
                            Time = new DateTime(2022, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            Category = 2,
                            Cost = 1500.0,
                            Name = "Table purchase",
                            Time = new DateTime(2022, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7,
                            Category = 1,
                            Cost = 350.0,
                            Name = "Food",
                            Time = new DateTime(2022, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8,
                            Category = 4,
                            Cost = 2000.0,
                            Name = "Gambling",
                            Time = new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 9,
                            Category = 3,
                            Cost = 400.0,
                            Name = "Haircut",
                            Time = new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 10,
                            Category = 0,
                            Cost = 100.0,
                            Name = "Netflix subscription",
                            Time = new DateTime(2022, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}