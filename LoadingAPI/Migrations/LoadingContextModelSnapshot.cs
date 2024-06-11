﻿// <auto-generated />
using System;
using LoadingAPI.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LoadingAPI.Migrations
{
    [DbContext(typeof(LoadingContext))]
    partial class LoadingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("LoadingAPI.Entities.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AnswerText")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsChosen")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NextQuestion")
                        .HasColumnType("INTEGER");

                    b.Property<int>("QuestionId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StatKeyId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.HasIndex("StatKeyId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("LoadingAPI.Entities.AnswerStat", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("QuestionId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VoteOption1")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VoteOption2")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VoteOption3")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VoteOption4")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("AnswerStat");
                });

            modelBuilder.Entity("LoadingAPI.Entities.CharacterStat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Attack")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Expirience")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Health")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Level")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Strength")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("CharacterStat");
                });

            modelBuilder.Entity("LoadingAPI.Entities.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Avatar")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("LoadingAPI.Entities.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AnswerAmount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("QuestionText")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("LoadingAPI.Entities.StatKey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Stat")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("StatKey");
                });

            modelBuilder.Entity("LoadingAPI.Entities.Answer", b =>
                {
                    b.HasOne("LoadingAPI.Entities.Question", "Question")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LoadingAPI.Entities.StatKey", "StatKey")
                        .WithMany()
                        .HasForeignKey("StatKeyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");

                    b.Navigation("StatKey");
                });

            modelBuilder.Entity("LoadingAPI.Entities.AnswerStat", b =>
                {
                    b.HasOne("LoadingAPI.Entities.Question", "Question")
                        .WithMany("AnswerStats")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("LoadingAPI.Entities.Question", b =>
                {
                    b.Navigation("AnswerStats");

                    b.Navigation("Answers");
                });
#pragma warning restore 612, 618
        }
    }
}
