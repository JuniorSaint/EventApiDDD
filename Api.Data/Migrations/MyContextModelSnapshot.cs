﻿// <auto-generated />
using System;
using Api.Data.Contex;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Api.Data.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Api.Domain.Entities.EventEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<DateTime>("EventDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("EventImage")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<TimeSpan>("EventTime")
                        .HasColumnType("interval");

                    b.Property<string>("Local")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PeopleAmount")
                        .HasColumnType("integer");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.Property<string>("Theme")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("EventDate");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("Api.Domain.Entities.EventSpeakerEntity", b =>
                {
                    b.Property<Guid>("EventId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("SpeakerId")
                        .HasColumnType("uuid");

                    b.HasKey("EventId", "SpeakerId");

                    b.HasIndex("SpeakerId");

                    b.ToTable("EventSpeakers");
                });

            modelBuilder.Entity("Api.Domain.Entities.LotEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("Amount")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("EventId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("InitialDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("LotName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("LotName");

                    b.ToTable("Lots");
                });

            modelBuilder.Entity("Api.Domain.Entities.SocialMediaEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("EventId")
                        .HasColumnType("integer");

                    b.Property<Guid?>("EventId1")
                        .HasColumnType("uuid");

                    b.Property<string>("SocialMedia")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("SpeakerId")
                        .HasColumnType("integer");

                    b.Property<Guid?>("SpeakerId1")
                        .HasColumnType("uuid");

                    b.Property<string>("URL")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("EventId1");

                    b.HasIndex("SocialMedia");

                    b.HasIndex("SpeakerId1");

                    b.ToTable("SocialMedias");
                });

            modelBuilder.Entity("Api.Domain.Entities.SpeakerEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("MiniResume")
                        .HasColumnType("text");

                    b.Property<string>("SpeakerEmail")
                        .HasColumnType("text");

                    b.Property<string>("SpeakerImage")
                        .HasColumnType("text");

                    b.Property<string>("SpeakerName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SpeakerPhone")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("SpeakerName");

                    b.ToTable("Speakers");
                });

            modelBuilder.Entity("Api.Domain.Entities.UserEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(90)
                        .HasColumnType("character varying(90)");

                    b.Property<string>("IsActive")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("65c2e3de-4865-47d3-af0c-acb3c1d0cfee"),
                            CreatedAt = new DateTime(2021, 10, 15, 16, 39, 46, 145, DateTimeKind.Local).AddTicks(7950),
                            Email = "junior.saint@gmail.com",
                            IsActive = "yes",
                            Password = "123456",
                            UpdatedAt = new DateTime(2021, 10, 15, 16, 39, 46, 169, DateTimeKind.Local).AddTicks(3230),
                            UserName = "Junior",
                            UserType = "administrator"
                        });
                });

            modelBuilder.Entity("Api.Domain.Entities.EventSpeakerEntity", b =>
                {
                    b.HasOne("Api.Domain.Entities.EventEntity", "Event")
                        .WithMany("EventSpeakers")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Api.Domain.Entities.SpeakerEntity", "Speaker")
                        .WithMany("EventSpeakers")
                        .HasForeignKey("SpeakerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");

                    b.Navigation("Speaker");
                });

            modelBuilder.Entity("Api.Domain.Entities.LotEntity", b =>
                {
                    b.HasOne("Api.Domain.Entities.EventEntity", "Event")
                        .WithMany("Lots")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");
                });

            modelBuilder.Entity("Api.Domain.Entities.SocialMediaEntity", b =>
                {
                    b.HasOne("Api.Domain.Entities.EventEntity", "Event")
                        .WithMany("socialMedias")
                        .HasForeignKey("EventId1")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Api.Domain.Entities.SpeakerEntity", "Speaker")
                        .WithMany("SocialMedias")
                        .HasForeignKey("SpeakerId1")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Event");

                    b.Navigation("Speaker");
                });

            modelBuilder.Entity("Api.Domain.Entities.EventEntity", b =>
                {
                    b.Navigation("EventSpeakers");

                    b.Navigation("Lots");

                    b.Navigation("socialMedias");
                });

            modelBuilder.Entity("Api.Domain.Entities.SpeakerEntity", b =>
                {
                    b.Navigation("EventSpeakers");

                    b.Navigation("SocialMedias");
                });
#pragma warning restore 612, 618
        }
    }
}
