﻿// <auto-generated />
using System;
using MOD.MentorLibrary;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MOD.MentorLibrary.Migrations
{
    [DbContext(typeof(MentorContext))]
    [Migration("20191122072334_MOD")]
    partial class MOD
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MOD.ModelLibrary.PaymentDtls", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("commision")
                        .HasColumnType("float");

                    b.Property<double>("fees")
                        .HasColumnType("float");

                    b.Property<bool>("paymentStatus")
                        .HasColumnType("bit");

                    b.Property<int>("skillId")
                        .HasColumnType("int");

                    b.Property<string>("skillName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("trainerFees")
                        .HasColumnType("float");

                    b.Property<string>("trainerId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("trainingDetailsId")
                        .HasColumnType("int");

                    b.Property<string>("userId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("PaymentDtls");
                });

            modelBuilder.Entity("MOD.ModelLibrary.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Fees")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prerequisites")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TOC")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("MOD.ModelLibrary.TrainingDtls", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("accept")
                        .HasColumnType("bit");

                    b.Property<double>("amountReceived")
                        .HasColumnType("float");

                    b.Property<double>("avaRating")
                        .HasColumnType("float");

                    b.Property<double>("commisionAmount")
                        .HasColumnType("float");

                    b.Property<DateTime>("endDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("mentorFirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mentorId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mentorLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("progress")
                        .HasColumnType("int");

                    b.Property<int>("rating")
                        .HasColumnType("int");

                    b.Property<bool>("rejectNotify")
                        .HasColumnType("bit");

                    b.Property<int>("skillId")
                        .HasColumnType("int");

                    b.Property<string>("skillname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("startDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("timeSlot")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("trainingPaymentStatus")
                        .HasColumnType("bit");

                    b.Property<string>("userFirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userLastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("TrainingDtls");
                });

            modelBuilder.Entity("MOD.ModelLibrary.UserMod", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ConfirmSignup")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("PictureUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrainerTechnology")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrainerTimings")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YearOfExperience")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UserMods");
                });
#pragma warning restore 612, 618
        }
    }
}