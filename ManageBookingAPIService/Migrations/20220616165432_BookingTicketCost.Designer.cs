﻿// <auto-generated />
using System;
using ManageBookingAPIService.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ManageBookingAPIService.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220616165432_BookingTicketCost")]
    partial class BookingTicketCost
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SharedServices.Models.Airline", b =>
                {
                    b.Property<int>("AirlineRecId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AirlineLogo")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("AirlineName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ContactAddress")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ContactNumber")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<double?>("DiscountAmount")
                        .HasColumnType("float");

                    b.Property<string>("DiscountCode")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<bool>("IsBlock")
                        .HasColumnType("bit");

                    b.HasKey("AirlineRecId");

                    b.ToTable("Airlines");
                });

            modelBuilder.Entity("SharedServices.Models.Booking", b =>
                {
                    b.Property<int>("BookingRecId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfJourney")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailId")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsBusinessClass")
                        .HasColumnType("bit");

                    b.Property<bool>("IsCancelTicket")
                        .HasColumnType("bit");

                    b.Property<bool>("IsRoundTrip")
                        .HasColumnType("bit");

                    b.Property<string>("Meal")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("NoOfSeats")
                        .HasColumnType("int");

                    b.Property<int>("PNRNumber")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ReturnDateOfJourney")
                        .HasColumnType("datetime2");

                    b.Property<bool>("ReturnIsBusinessClass")
                        .HasColumnType("bit");

                    b.Property<int?>("ReturnScheduleRecId")
                        .HasColumnType("int");

                    b.Property<int>("ScheduleRecId")
                        .HasColumnType("int");

                    b.Property<double>("TicketCost")
                        .HasColumnType("float");

                    b.HasKey("BookingRecId");

                    b.HasIndex("ScheduleRecId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("SharedServices.Models.Passenger", b =>
                {
                    b.Property<int>("PassengerRecId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("BookingRecId")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ReturnSeatNumbers")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("SeatNumbers")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("PassengerRecId");

                    b.HasIndex("BookingRecId");

                    b.ToTable("Passenger");
                });

            modelBuilder.Entity("SharedServices.Models.Schedule", b =>
                {
                    b.Property<int>("ScheduleRecId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AirlineRecId")
                        .HasColumnType("int");

                    b.Property<double>("BusinessClassTicket")
                        .HasColumnType("float");

                    b.Property<DateTime?>("EndDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("FlightNumber")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("FromPlace")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("InstrumentUsed")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Meal")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("NoOfBussinessClsSeats")
                        .HasColumnType("int");

                    b.Property<int>("NoOfNonBussinessClsSeats")
                        .HasColumnType("int");

                    b.Property<int>("NoOfRows")
                        .HasColumnType("int");

                    b.Property<double>("NonBusinessClassTicket")
                        .HasColumnType("float");

                    b.Property<string>("ScheduleDays")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("StartDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ToPlace")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ScheduleRecId");

                    b.HasIndex("AirlineRecId");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("SharedServices.Models.Booking", b =>
                {
                    b.HasOne("SharedServices.Models.Schedule", "Schedules")
                        .WithMany("Bookings")
                        .HasForeignKey("ScheduleRecId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Schedules");
                });

            modelBuilder.Entity("SharedServices.Models.Passenger", b =>
                {
                    b.HasOne("SharedServices.Models.Booking", "Bookings")
                        .WithMany("Passengers")
                        .HasForeignKey("BookingRecId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("SharedServices.Models.Schedule", b =>
                {
                    b.HasOne("SharedServices.Models.Airline", "Airlines")
                        .WithMany("Schedules")
                        .HasForeignKey("AirlineRecId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Airlines");
                });

            modelBuilder.Entity("SharedServices.Models.Airline", b =>
                {
                    b.Navigation("Schedules");
                });

            modelBuilder.Entity("SharedServices.Models.Booking", b =>
                {
                    b.Navigation("Passengers");
                });

            modelBuilder.Entity("SharedServices.Models.Schedule", b =>
                {
                    b.Navigation("Bookings");
                });
#pragma warning restore 612, 618
        }
    }
}
