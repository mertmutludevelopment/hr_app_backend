﻿// <auto-generated />
using HrApp.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HrApp.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20231212201736_initDeclinedLeaveTable")]
    partial class initDeclinedLeaveTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("HrApp.Models.ApprovedLeave", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("EndLeaveDay")
                        .HasColumnType("integer");

                    b.Property<int>("EndLeaveMonth")
                        .HasColumnType("integer");

                    b.Property<int>("EndLeaveYear")
                        .HasColumnType("integer");

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("NumberOfLeaveDay")
                        .HasColumnType("integer");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("StartLeaveDay")
                        .HasColumnType("integer");

                    b.Property<int>("StartLeaveMonth")
                        .HasColumnType("integer");

                    b.Property<int>("StartLeaveYear")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("ApprovedLeaves");
                });

            modelBuilder.Entity("HrApp.Models.DeclinedLeave", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("EndLeaveDay")
                        .HasColumnType("integer");

                    b.Property<int>("EndLeaveMonth")
                        .HasColumnType("integer");

                    b.Property<int>("EndLeaveYear")
                        .HasColumnType("integer");

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("NumberOfLeaveDay")
                        .HasColumnType("integer");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("StartLeaveDay")
                        .HasColumnType("integer");

                    b.Property<int>("StartLeaveMonth")
                        .HasColumnType("integer");

                    b.Property<int>("StartLeaveYear")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("DeclinedLeaves");
                });

            modelBuilder.Entity("HrApp.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("EventDay")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("EventDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("EventLocation")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("EventName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("EventTime")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EventDay = "20.01.2024",
                            EventDescription = "Football match between teams",
                            EventLocation = "Bursaspor training complex",
                            EventName = "Football Match",
                            EventTime = "18.00"
                        });
                });

            modelBuilder.Entity("HrApp.Models.PendingLeave", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("EndLeaveDay")
                        .HasColumnType("integer");

                    b.Property<int>("EndLeaveMonth")
                        .HasColumnType("integer");

                    b.Property<int>("EndLeaveYear")
                        .HasColumnType("integer");

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("NumberOfLeaveDay")
                        .HasColumnType("integer");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("StartLeaveDay")
                        .HasColumnType("integer");

                    b.Property<int>("StartLeaveMonth")
                        .HasColumnType("integer");

                    b.Property<int>("StartLeaveYear")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("PendingLeaves");
                });

            modelBuilder.Entity("HrApp.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("BirthDay")
                        .HasColumnType("integer");

                    b.Property<int>("BirthMonth")
                        .HasColumnType("integer");

                    b.Property<int>("BirthYear")
                        .HasColumnType("integer");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("LeaveDay")
                        .HasColumnType("integer");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDay = 1,
                            BirthMonth = 1,
                            BirthYear = 2001,
                            Department = "Mobile",
                            Email = "mert@gmail.com",
                            Fullname = "MERT MUTLU",
                            LeaveDay = 0,
                            Password = "mert123",
                            PhoneNumber = "5380329797"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
