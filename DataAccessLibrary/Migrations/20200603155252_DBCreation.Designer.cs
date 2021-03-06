﻿// <auto-generated />
using System;
using DataAccessLibrary.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLibrary.Migrations
{
    [DbContext(typeof(FlightControlContext))]
    [Migration("20200603155252_DBCreation")]
    partial class DBCreation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4");

            modelBuilder.Entity("DataAccessLibrary.Models.FlightPlan", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<int>("InitialLocationId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Passengers")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("InitialLocationId");

                    b.ToTable("FlightPlans");
                });

            modelBuilder.Entity("DataAccessLibrary.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("TEXT");

                    b.Property<double>("Latitude")
                        .HasColumnType("REAL");

                    b.Property<double>("Longitude")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("DataAccessLibrary.Models.Segment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FlightPlanId")
                        .HasColumnType("TEXT");

                    b.Property<double>("Latitude")
                        .HasColumnType("REAL");

                    b.Property<double>("Longitude")
                        .HasColumnType("REAL");

                    b.Property<int>("TimeSpanSeconds")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("FlightPlanId");

                    b.ToTable("Segments");
                });

            modelBuilder.Entity("DataAccessLibrary.Models.Server", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("URL")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(1024);

                    b.HasKey("Id");

                    b.ToTable("Servers");
                });

            modelBuilder.Entity("DataAccessLibrary.Models.FlightPlan", b =>
                {
                    b.HasOne("DataAccessLibrary.Models.Location", "InitialLocation")
                        .WithMany()
                        .HasForeignKey("InitialLocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataAccessLibrary.Models.Segment", b =>
                {
                    b.HasOne("DataAccessLibrary.Models.FlightPlan", null)
                        .WithMany("Segments")
                        .HasForeignKey("FlightPlanId");
                });
#pragma warning restore 612, 618
        }
    }
}
