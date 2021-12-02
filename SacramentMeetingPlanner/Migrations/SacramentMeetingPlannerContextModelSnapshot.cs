﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace SacramentMeetingPlanner.Migrations
{
    [DbContext(typeof(SacramentMeetingPlannerContext))]
    partial class SacramentMeetingPlannerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("SacramentMeeting.Models.Hymn", b =>
                {
                    b.Property<int>("HymnId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("HymnName")
                        .HasColumnType("TEXT");

                    b.Property<int>("HymnNumber")
                        .HasColumnType("INTEGER");

                    b.HasKey("HymnId");

                    b.ToTable("Hymn");
                });

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

                    b.Property<int>("OpeningHymnId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("OpeningPrayer")
                        .HasColumnType("TEXT");

                    b.Property<string>("SacramentHymn")
                        .HasColumnType("TEXT");

                    b.HasKey("SacramentPlanId");

                    b.HasIndex("OpeningHymnId");

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

            modelBuilder.Entity("SacramentMeeting.Models.SacramentPlan", b =>
                {
                    b.HasOne("SacramentMeeting.Models.Hymn", "OpeningHymn")
                        .WithMany()
                        .HasForeignKey("OpeningHymnId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OpeningHymn");
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
