﻿// <auto-generated />
using EmotionMarketing.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmotionMarketing.Domain.Migrations
{
    [DbContext(typeof(emotionDb))]
    [Migration("20181113210407_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("EmotionMarketing.Domain.Emotion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("emotion");
                });

            modelBuilder.Entity("EmotionMarketing.Domain.ExpectedResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EmotionId");

                    b.Property<int>("From");

                    b.Property<int>("To");

                    b.HasKey("Id");

                    b.HasIndex("EmotionId");

                    b.ToTable("expected_result");
                });

            modelBuilder.Entity("EmotionMarketing.Domain.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("genre");
                });

            modelBuilder.Entity("EmotionMarketing.Domain.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AttentionRate");

                    b.Property<string>("Description");

                    b.Property<int>("GenderType");

                    b.Property<int>("GenreId");

                    b.Property<string>("ProducerName");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.ToTable("projects");
                });

            modelBuilder.Entity("EmotionMarketing.Domain.ExpectedResult", b =>
                {
                    b.HasOne("EmotionMarketing.Domain.Emotion", "Emotion")
                        .WithMany()
                        .HasForeignKey("EmotionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EmotionMarketing.Domain.Project", b =>
                {
                    b.HasOne("EmotionMarketing.Domain.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
