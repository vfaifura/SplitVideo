using Microsoft.EntityFrameworkCore;

namespace EmotionMarketing.Domain
{
    public class emotionDb : DbContext
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<ExpectedResult> ExpectedResults { get; set; }
        public DbSet<Emotion> Emotions { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseMySql(
                    @"server=localhost;port=3306;database=emotion_marketing;uid=root;");
        }
    }
}
