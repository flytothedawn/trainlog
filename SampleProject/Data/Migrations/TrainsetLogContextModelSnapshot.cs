﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SampleProject.Data;

#nullable disable

namespace SampleProject.Data.Migrations
{
    [DbContext(typeof(TrainsetLogContext))]
    partial class TrainsetLogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.8");

            modelBuilder.Entity("SampleProject.Models.SpottingRecord", b =>
                {
                    b.Property<string>("SpottingRecordID")
                        .HasColumnType("TEXT");

                    b.Property<int?>("TrainsetForeignKey")
                        .HasColumnType("INTEGER");

                    b.HasKey("SpottingRecordID");

                    b.HasIndex("TrainsetForeignKey");

                    b.ToTable("SpottingRecords");

                    b.HasData(
                        new
                        {
                            SpottingRecordID = "MRT93742",
                            TrainsetForeignKey = 714
                        });
                });

            modelBuilder.Entity("SampleProject.Models.TrainsetLog", b =>
                {
                    b.Property<int>("Trainset")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("Trainset");

                    b.Property<string>("DisplayTrainset")
                        .HasColumnType("TEXT");

                    b.Property<string>("Line")
                        .HasColumnType("TEXT");

                    b.Property<string>("Line2")
                        .HasColumnType("TEXT");

                    b.Property<string>("Remarks")
                        .HasColumnType("TEXT");

                    b.Property<string>("RollingStock")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Trainset2")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Trainset3")
                        .HasColumnType("INTEGER");

                    b.HasKey("Trainset");

                    b.ToTable("TrainsetLogs");

                    b.HasData(
                        new
                        {
                            Trainset = 609,
                            DisplayTrainset = "609/610",
                            Line = "NSL",
                            Line2 = "EWL",
                            Remarks = "Train",
                            RollingStock = "C151B",
                            Trainset2 = 610,
                            Trainset3 = 0
                        },
                        new
                        {
                            Trainset = 223,
                            DisplayTrainset = "223/224",
                            Line = "NSL",
                            Remarks = "Train",
                            RollingStock = "C651",
                            Trainset2 = 224,
                            Trainset3 = 0
                        });
                });

            modelBuilder.Entity("SampleProject.Models.SpottingRecord", b =>
                {
                    b.HasOne("SampleProject.Models.TrainsetLog", "TrainsetLog")
                        .WithMany("SpottingRecords")
                        .HasForeignKey("TrainsetForeignKey");

                    b.Navigation("TrainsetLog");
                });

            modelBuilder.Entity("SampleProject.Models.TrainsetLog", b =>
                {
                    b.Navigation("SpottingRecords");
                });
#pragma warning restore 612, 618
        }
    }
}
