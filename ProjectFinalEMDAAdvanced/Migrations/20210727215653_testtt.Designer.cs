﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectFinalEMDAAdvanced.Data;

namespace ProjectFinalEMDAAdvanced.Migrations
{
    [DbContext(typeof(StaffDbContext))]
    [Migration("20210727215653_testtt")]
    partial class testtt
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113");

            modelBuilder.Entity("ProjectFinalEMDAAdvanced.Models.Events", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Days");

                    b.Property<DateTime>("End");

                    b.Property<string>("EventColor");

                    b.Property<bool>("IsFullDay");

                    b.Property<int?>("StaffId");

                    b.Property<DateTime>("Start");

                    b.Property<string>("Title");

                    b.Property<int>("Weeks");

                    b.HasKey("Id");

                    b.HasIndex("StaffId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("ProjectFinalEMDAAdvanced.Models.Leave", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Accepted");

                    b.Property<DateTime>("EndDate");

                    b.Property<int?>("StaffId");

                    b.Property<DateTime>("StartDate");

                    b.Property<int>("TotalDays");

                    b.HasKey("Id");

                    b.HasIndex("StaffId");

                    b.ToTable("Leave");
                });

            modelBuilder.Entity("ProjectFinalEMDAAdvanced.Models.Reasons", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Reason");

                    b.Property<int>("ReasonCount");

                    b.HasKey("Id");

                    b.ToTable("Reasons");
                });

            modelBuilder.Entity("ProjectFinalEMDAAdvanced.Models.SignOuts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Day");

                    b.Property<string>("HoursIn");

                    b.Property<int?>("ReasonId");

                    b.Property<int?>("StaffId");

                    b.Property<DateTime>("TimeOut");

                    b.HasKey("Id");

                    b.HasIndex("ReasonId");

                    b.HasIndex("StaffId");

                    b.ToTable("SignOuts");
                });

            modelBuilder.Entity("ProjectFinalEMDAAdvanced.Models.Staff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<bool>("In");

                    b.Property<string>("LastName");

                    b.Property<DateTime>("TimeIn");

                    b.Property<DateTime>("TimeOut");

                    b.HasKey("Id");

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("ProjectFinalEMDAAdvanced.Models.Events", b =>
                {
                    b.HasOne("ProjectFinalEMDAAdvanced.Models.Staff", "Staff")
                        .WithMany()
                        .HasForeignKey("StaffId");
                });

            modelBuilder.Entity("ProjectFinalEMDAAdvanced.Models.Leave", b =>
                {
                    b.HasOne("ProjectFinalEMDAAdvanced.Models.Staff", "Staff")
                        .WithMany()
                        .HasForeignKey("StaffId");
                });

            modelBuilder.Entity("ProjectFinalEMDAAdvanced.Models.SignOuts", b =>
                {
                    b.HasOne("ProjectFinalEMDAAdvanced.Models.Reasons", "Reason")
                        .WithMany()
                        .HasForeignKey("ReasonId");

                    b.HasOne("ProjectFinalEMDAAdvanced.Models.Staff", "Staff")
                        .WithMany()
                        .HasForeignKey("StaffId");
                });
#pragma warning restore 612, 618
        }
    }
}
