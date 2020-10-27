﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelApi.Models;

namespace TravelApi.Migrations
{
    [DbContext(typeof(TravelApiContext))]
    [Migration("20201027210554_Userseed")]
    partial class Userseed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TravelApi.Models.Place", b =>
                {
                    b.Property<int>("PlaceId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("Country")
                        .IsRequired();

                    b.Property<DateTime>("Date");

                    b.Property<string>("Landmark")
                        .IsRequired();

                    b.Property<int>("Rating");

                    b.Property<string>("Review")
                        .IsRequired();

                    b.HasKey("PlaceId");

                    b.ToTable("Places");

                    b.HasData(
                        new
                        {
                            PlaceId = -1,
                            City = "Las Vegas",
                            Country = "USA",
                            Date = new DateTime(2020, 10, 27, 14, 5, 54, 250, DateTimeKind.Local).AddTicks(2090),
                            Landmark = "casino",
                            Rating = 7,
                            Review = "Hot"
                        },
                        new
                        {
                            PlaceId = -2,
                            City = "NYC",
                            Country = "USA",
                            Date = new DateTime(2020, 10, 27, 14, 5, 54, 262, DateTimeKind.Local).AddTicks(6430),
                            Landmark = "Empire State building",
                            Rating = 10,
                            Review = "Crowded"
                        },
                        new
                        {
                            PlaceId = -3,
                            City = "Portland",
                            Country = "USA",
                            Date = new DateTime(2020, 10, 27, 14, 5, 54, 262, DateTimeKind.Local).AddTicks(6450),
                            Landmark = "skidmore fountian",
                            Rating = 2,
                            Review = "Bridges"
                        },
                        new
                        {
                            PlaceId = -4,
                            City = "Seattle",
                            Country = "USA",
                            Date = new DateTime(2020, 10, 27, 14, 5, 54, 262, DateTimeKind.Local).AddTicks(6460),
                            Landmark = "starbucks",
                            Rating = 4,
                            Review = "Hills"
                        },
                        new
                        {
                            PlaceId = -5,
                            City = "Miami",
                            Country = "USA",
                            Date = new DateTime(2020, 10, 27, 0, 0, 0, 0, DateTimeKind.Local),
                            Landmark = "art basil",
                            Rating = 2,
                            Review = "Beaches"
                        });
                });

            modelBuilder.Entity("TravelApi.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Password");

                    b.Property<string>("Token");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            Password = "yoyoyo",
                            Username = "NatDawg"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}