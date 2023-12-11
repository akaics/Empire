﻿// <auto-generated />
using System;
using Empire.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Empire.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Empire.Model.Bruger", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AdgangsKode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrugerNavn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Bruger");
                });

            modelBuilder.Entity("Empire.Model.Salgsopslag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BrugerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OprettelsesDato")
                        .HasColumnType("datetime2");

                    b.Property<double>("Pris")
                        .HasColumnType("float");

                    b.Property<string>("Skin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SalgsOpslag");
                });

            modelBuilder.Entity("Empire.Model.Skin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Beskrivelse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Pris")
                        .HasColumnType("float");

                    b.Property<string>("SkinNavn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Stand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VåbenType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Skin");
                });

            modelBuilder.Entity("Empire.Model.Søgekriterier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("SkinNavn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Stand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VåbenType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Søgekriterier");
                });
#pragma warning restore 612, 618
        }
    }
}