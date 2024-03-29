﻿// <auto-generated />
using System;
using AirTagTracker;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AirTagTracker.Migrations
{
    [DbContext(typeof(FindMyModel))]
    partial class FindMyModelModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("dbo")
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AirTagTracker.AirTagData", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<double?>("Latitude")
                        .HasColumnType("float");

                    b.Property<double?>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("TagName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UploadSessionAirTagDatasId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UploadSessionAirTagDatasId");

                    b.ToTable("AirTagDatas", "dbo");
                });

            modelBuilder.Entity("AirTagTracker.UploadSession", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<DateTime>("DateTimeDataAccessed")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateTimeDataLastModified")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("SessionDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("UploadSessions", "dbo");
                });

            modelBuilder.Entity("AirTagTracker.AirTagData", b =>
                {
                    b.HasOne("AirTagTracker.UploadSession", null)
                        .WithMany("AirTagDatas")
                        .HasForeignKey("UploadSessionAirTagDatasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AirTagTracker.UploadSession", b =>
                {
                    b.Navigation("AirTagDatas");
                });
#pragma warning restore 612, 618
        }
    }
}
