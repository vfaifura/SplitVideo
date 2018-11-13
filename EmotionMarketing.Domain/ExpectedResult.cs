using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmotionMarketing.Domain
{
    [Table("expected_result")]
    public class ExpectedResult
    {
        [Key]
        public int Id { get; set; }

        public int From { get; set; }

        public int To { get; set; }

        public int EmotionId { get; set; }

        public Emotion Emotion { get; set; }
    }
}
