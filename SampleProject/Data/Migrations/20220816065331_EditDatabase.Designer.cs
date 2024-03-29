﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SampleProject.Data;

#nullable disable

namespace SampleProject.Data.Migrations
{
    [DbContext(typeof(TrainsetLogContext))]
    [Migration("20220816065331_EditDatabase")]
    partial class EditDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.8");

            modelBuilder.Entity("SampleProject.Models.TrainsetLog", b =>
                {
                    b.Property<int>("Trainset")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("Trainset");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("DisplayRunNo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DisplayTrainset")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Line")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Line2")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Remarks")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("RollingStock")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("RunNo")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Trainset2")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Trainset3")
                        .HasColumnType("INTEGER");

                    b.HasKey("Trainset");

                    b.ToTable("TrainsetLogs");

                    b.HasData(
                        new
                        {
                            Trainset = 609,
                            Date = new DateTime(2022, 8, 16, 14, 53, 31, 697, DateTimeKind.Local).AddTicks(5742),
                            DisplayRunNo = "T211",
                            DisplayTrainset = "609/610",
                            Line = "NSL",
                            Line2 = "EWL",
                            Remarks = "Train",
                            RollingStock = "C151B",
                            RunNo = 211,
                            Trainset2 = 610,
                            Trainset3 = 0
                        },
                        new
                        {
                            Trainset = 223,
                            Date = new DateTime(2022, 8, 16, 14, 53, 31, 697, DateTimeKind.Local).AddTicks(5757),
                            DisplayRunNo = "T211",
                            DisplayTrainset = "223/224",
                            Line = "NSL",
                            Line2 = "EWL",
                            Remarks = "Train",
                            RollingStock = "C651",
                            RunNo = 211,
                            Trainset2 = 224,
                            Trainset3 = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
