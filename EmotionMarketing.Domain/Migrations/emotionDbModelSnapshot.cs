using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EmotionMarketing.Domain.Migrations
{
    [DbContext(typeof(emotionDb))]
    internal class emotionDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.6");

            modelBuilder.Entity("EmotionMarketing.Domain.ActualResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<int>("EmotionId")
                        .HasColumnName("emotion_id");

                    b.Property<int>("ProjectId")
                        .HasColumnName("project_id");

                    b.Property<int>("TimeIndex")
                        .HasColumnName("time_index");

                    b.HasKey("Id");

                    b.HasIndex("EmotionId");

                    b.HasIndex("ProjectId");

                    b.ToTable("actual_result");
                });

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
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<int>("EmotionId")
                        .HasColumnName("emotion_id");

                    b.Property<int>("From")
                        .HasColumnName("from");

                    b.Property<int>("ProjectId")
                        .HasColumnName("project_id");

                    b.Property<int>("To")
                        .HasColumnName("to");

                    b.HasKey("Id");

                    b.HasIndex("EmotionId");

                    b.HasIndex("ProjectId");

                    b.ToTable("expected_result");
                });

            modelBuilder.Entity("EmotionMarketing.Domain.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("genre");
                });

            modelBuilder.Entity("EmotionMarketing.Domain.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<int>("AttentionRate")
                        .HasColumnName("attention_rate");

                    b.Property<string>("Description")
                        .HasColumnName("description");

                    b.Property<int>("GenderType")
                        .HasColumnName("gender_type");

                    b.Property<int>("GenreId")
                        .HasColumnName("genre_id");

                    b.Property<string>("ProducerName")
                        .HasColumnName("producer_name");

                    b.Property<string>("Title")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.ToTable("projects");
                });

            modelBuilder.Entity("EmotionMarketing.Domain.ActualResult", b =>
                {
                    b.HasOne("EmotionMarketing.Domain.Emotion", "Emotion")
                        .WithMany()
                        .HasForeignKey("EmotionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EmotionMarketing.Domain.Project", "Project")
                        .WithMany("ActualResults")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EmotionMarketing.Domain.ExpectedResult", b =>
                {
                    b.HasOne("EmotionMarketing.Domain.Emotion", "Emotion")
                        .WithMany()
                        .HasForeignKey("EmotionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EmotionMarketing.Domain.Project", "Project")
                        .WithMany("ExpectedResults")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EmotionMarketing.Domain.Project", b =>
                {
                    b.HasOne("EmotionMarketing.Domain.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
