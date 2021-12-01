﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace SacramentMeetingPlanner.Migrations
{
    [DbContext(typeof(SacramentMeetingPlannerContext))]
    [Migration("20211130224208_Speakers")]
    partial class Speakers
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("SacramentMeeting.Models.SacramentPlan", b =>
                {
                    b.Property<int>("SacramentPlanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClosingHymn")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClosingPrayer")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConductingLeader")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("MusicNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("OpenningHymn")
                        .HasColumnType("TEXT");

                    b.Property<string>("OpenningPrayer")
                        .HasColumnType("TEXT");

                    b.Property<string>("SacramentHymn")
                        .HasColumnType("TEXT");

                    b.Property<string>("SpeakerSubject")
                        .HasColumnType("TEXT");

                    b.HasKey("SacramentPlanId");

                    b.ToTable("SacramentPlan");
                });

            modelBuilder.Entity("SacramentMeeting.Models.Speaker", b =>
                {
                    b.Property<int>("SpeakerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("SacramentPlanId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Topic")
                        .HasColumnType("TEXT");

                    b.HasKey("SpeakerId");

                    b.HasIndex("SacramentPlanId");

                    b.ToTable("Speaker");
                });

            modelBuilder.Entity("SacramentMeeting.Models.Speaker", b =>
                {
                    b.HasOne("SacramentMeeting.Models.SacramentPlan", "SacramentPlan")
                        .WithMany("Speakers")
                        .HasForeignKey("SacramentPlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SacramentPlan");
                });

            modelBuilder.Entity("SacramentMeeting.Models.SacramentPlan", b =>
                {
                    b.Navigation("Speakers");
                });
#pragma warning restore 612, 618
        }
    }
}
