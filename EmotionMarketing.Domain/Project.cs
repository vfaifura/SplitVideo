using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmotionMarketing.Domain
{
    [Table("projects")]
    public class Project
    {
        public Project()
        {
            this.ExpectedResults = new HashSet<ExpectedResult>();
            this.ActualResults = new HashSet<ActualResult>();
        }

        [Key]
        [Column("id")] public int Id { get; set; }

        [Column("title")] public string Title { get; set; }

        [Column("description")] public string Description { get; set; }

        [Column("producer_name")] public string ProducerName { get; set; }

        [Column("gender_type")] public GenderType GenderType { get; set; }

        [Column("genre_id")] public int GenreId { get; set; }

        [Column("attention_rate")] public int AttentionRate { get; set; }

        public Genre Genre { get; set; }

        public virtual ICollection<ExpectedResult> ExpectedResults { get; set; }
        public virtual ICollection<ActualResult> ActualResults { get; set; }
    }

    public enum GenderType
    {
        Male,
        Female
    }
}
