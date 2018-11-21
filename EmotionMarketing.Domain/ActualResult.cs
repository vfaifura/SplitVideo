using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmotionMarketing.Domain
{
    [Table("actual_result")]
    public class ActualResult
    {
        [Key] [Column("id")] public int Id { get; set; }

        [Column("time_index")] public int TimeIndex { get; set; }

        // if null -> missed attention
        [Column("emotion_id")] public int EmotionId { get; set; }

        [Column("project_id")] public int ProjectId { get; set; }

        public Emotion Emotion { get; set; }
        public Project Project { get; set; }



    }
}
