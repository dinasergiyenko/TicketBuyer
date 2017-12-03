﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using TicketBuyer.DataAccessLayer;
using TicketBuyer.DataAccessLayer.Enums;

namespace TicketBuyer.DataAccessLayer.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateTime");

                    b.Property<string>("Information");

                    b.Property<string>("Name");

                    b.Property<int>("PlaceId");

                    b.Property<int>("Status");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("PlaceId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.EventComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comment");

                    b.Property<DateTime>("DateTime");

                    b.Property<int>("EventId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("UserId");

                    b.ToTable("EventComments");
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.EventPhoto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EventId");

                    b.Property<string>("Photo");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.ToTable("EventPhotos");
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("PaymentId");

                    b.Property<int>("Status");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("PaymentId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.Payment", b =>
                {
                    b.Property<int>("Id");

                    b.Property<DateTime>("DateTime");

                    b.HasKey("Id");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.Place", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Information");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Places");
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.PlacePhoto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Photo");

                    b.Property<int>("PlaceId");

                    b.HasKey("Id");

                    b.HasIndex("PlaceId");

                    b.ToTable("PlacePhotos");
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.Price", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EventId");

                    b.Property<float>("EventPrice");

                    b.Property<int>("SectorId");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("SectorId");

                    b.ToTable("Prices");
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.Seating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Row");

                    b.Property<int>("Seat");

                    b.Property<int>("SectorId");

                    b.HasKey("Id");

                    b.HasIndex("SectorId");

                    b.ToTable("Seatings");
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.Sector", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Limit");

                    b.Property<int>("PlaceId");

                    b.Property<string>("Title");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("PlaceId");

                    b.ToTable("Sectors");
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EventId");

                    b.Property<int>("OrderId");

                    b.Property<float>("Price");

                    b.Property<int?>("SeatingId");

                    b.Property<int>("SectorId");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("OrderId");

                    b.HasIndex("SeatingId");

                    b.HasIndex("SectorId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Password");

                    b.Property<int>("Role");

                    b.Property<string>("Salt");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.WishEvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EventId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("UserId");

                    b.ToTable("WishEvents");
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.Event", b =>
                {
                    b.HasOne("TicketBuyer.DataAccessLayer.Entities.Place", "Place")
                        .WithMany("Events")
                        .HasForeignKey("PlaceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.EventComment", b =>
                {
                    b.HasOne("TicketBuyer.DataAccessLayer.Entities.Event", "Event")
                        .WithMany("EventComments")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TicketBuyer.DataAccessLayer.Entities.User", "User")
                        .WithMany("EventComments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.EventPhoto", b =>
                {
                    b.HasOne("TicketBuyer.DataAccessLayer.Entities.Event", "Event")
                        .WithMany("EventPhotos")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.Order", b =>
                {
                    b.HasOne("TicketBuyer.DataAccessLayer.Entities.Payment", "Payment")
                        .WithMany()
                        .HasForeignKey("PaymentId");

                    b.HasOne("TicketBuyer.DataAccessLayer.Entities.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.PlacePhoto", b =>
                {
                    b.HasOne("TicketBuyer.DataAccessLayer.Entities.Place", "Place")
                        .WithMany("PlacePhotos")
                        .HasForeignKey("PlaceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.Price", b =>
                {
                    b.HasOne("TicketBuyer.DataAccessLayer.Entities.Event", "Event")
                        .WithMany()
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TicketBuyer.DataAccessLayer.Entities.Sector", "Sector")
                        .WithMany("Prices")
                        .HasForeignKey("SectorId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.Seating", b =>
                {
                    b.HasOne("TicketBuyer.DataAccessLayer.Entities.Sector", "Sector")
                        .WithMany("Seatings")
                        .HasForeignKey("SectorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.Sector", b =>
                {
                    b.HasOne("TicketBuyer.DataAccessLayer.Entities.Place", "Place")
                        .WithMany("Sectors")
                        .HasForeignKey("PlaceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.Ticket", b =>
                {
                    b.HasOne("TicketBuyer.DataAccessLayer.Entities.Event", "Event")
                        .WithMany("Tickets")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TicketBuyer.DataAccessLayer.Entities.Order", "Order")
                        .WithMany("Tickets")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TicketBuyer.DataAccessLayer.Entities.Seating", "Seating")
                        .WithMany("Tickets")
                        .HasForeignKey("SeatingId");

                    b.HasOne("TicketBuyer.DataAccessLayer.Entities.Sector", "Sector")
                        .WithMany("Tickets")
                        .HasForeignKey("SectorId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("TicketBuyer.DataAccessLayer.Entities.WishEvent", b =>
                {
                    b.HasOne("TicketBuyer.DataAccessLayer.Entities.Event", "Event")
                        .WithMany("WishEvents")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TicketBuyer.DataAccessLayer.Entities.User", "User")
                        .WithMany("WishEvents")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
