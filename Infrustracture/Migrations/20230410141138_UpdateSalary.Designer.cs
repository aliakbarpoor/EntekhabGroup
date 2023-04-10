﻿// <auto-generated />
using System;
using Infrustracture;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrustracture.Migrations
{
    [DbContext(typeof(EFContext))]
    [Migration("20230410141138_UpdateSalary")]
    partial class UpdateSalary
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Salary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Allowance")
                        .HasColumnType("float");

                    b.Property<double>("BasicSalary")
                        .HasColumnType("float");

                    b.Property<DateTimeOffset>("Date")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OveTime")
                        .HasColumnType("int");

                    b.Property<double>("OveTimeGrossValue")
                        .HasColumnType("float");

                    b.Property<double>("Transportation")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Salary", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
