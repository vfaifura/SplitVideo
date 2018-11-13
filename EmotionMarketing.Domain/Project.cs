using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmotionMarketing.Domain
{
    [Table("projects")]
    public class Project
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string ProducerName { get; set; }

        public GenderType GenderType { get; set; }

        public int GenreId { get; set; }

        public Genre Genre { get; set; }

        public int AttentionRate { get; set; }
    }

    public enum GenderType
    {
        Male,
        Female
    }
}
