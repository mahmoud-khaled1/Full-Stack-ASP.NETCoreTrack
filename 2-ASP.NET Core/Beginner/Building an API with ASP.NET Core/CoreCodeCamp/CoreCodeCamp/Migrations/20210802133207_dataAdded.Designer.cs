﻿// <auto-generated />
using System;
using CoreCodeCamp;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoreCodeCamp.Migrations
{
    [DbContext(typeof(CampContext))]
    [Migration("20210802133207_dataAdded")]
    partial class dataAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoreCodeCamp.Camp", b =>
                {
                    b.Property<int>("CampId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EventDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Length")
                        .HasColumnType("int");

                    b.Property<int?>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("Moniker")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CampId");

                    b.HasIndex("LocationId");

                    b.ToTable("Camps");

                    b.HasData(
                        new
                        {
                            CampId = 1,
                            EventDate = new DateTime(2018, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Length = 1,
                            Moniker = "ATL2018",
                            Name = "Atlanta Code Camp"
                        });
                });

            modelBuilder.Entity("CoreCodeCamp.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CityTown")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StateProvince")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VenueName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LocationId");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("CoreCodeCamp.Speaker", b =>
                {
                    b.Property<int>("SpeakerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BlogUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Company")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GitHub")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Twitter")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SpeakerId");

                    b.ToTable("Speakers");
                });

            modelBuilder.Entity("CoreCodeCamp.Talk", b =>
                {
                    b.Property<int>("TalkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Abstract")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CampId")
                        .HasColumnType("int");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<int?>("SpeakerId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TalkId");

                    b.HasIndex("CampId");

                    b.HasIndex("SpeakerId");

                    b.ToTable("Talks");
                });

            modelBuilder.Entity("CoreCodeCamp.Camp", b =>
                {
                    b.HasOne("CoreCodeCamp.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("CoreCodeCamp.Talk", b =>
                {
                    b.HasOne("CoreCodeCamp.Camp", "Camp")
                        .WithMany("Talks")
                        .HasForeignKey("CampId");

                    b.HasOne("CoreCodeCamp.Speaker", "Speaker")
                        .WithMany()
                        .HasForeignKey("SpeakerId");

                    b.Navigation("Camp");

                    b.Navigation("Speaker");
                });

            modelBuilder.Entity("CoreCodeCamp.Camp", b =>
                {
                    b.Navigation("Talks");
                });
#pragma warning restore 612, 618
        }
    }
}
