

using Microsoft.EntityFrameworkCore;

namespace EmotionMarketing.Domain
{
    public class emotionDb : DbContext
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<ExpectedResult> ExpectedResults { get; set; }
        public DbSet<Emotion> Emotions { get; set; }

        public DbSet<ActualResult> ActualResults { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseMySql("server=localhost;port=3306;database=emotion_marketing;uid=root;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExpectedResult>(
                entity =>
                {
                    entity.HasOne(x => x.Project).WithMany(x => x.ExpectedResults);
                    entity.HasOne(x => x.Emotion);
                });

            modelBuilder.Entity<Project>(
                entity =>
                {
                    entity.HasMany(x => x.ExpectedResults).WithOne(x => x.Project);
                    entity.HasOne(x => x.Genre);
                });

            modelBuilder.Entity<ActualResult>(
                entity =>
                {
                    entity.HasOne(x => x.Emotion);
                    entity.HasOne(x => x.Project);
                });
        }
    }
}
