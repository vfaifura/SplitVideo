﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmotionMarketing.Domain
{
    [Table("expected_result")]
    public class ExpectedResult
    {
        [Key]
        [Column("id")] public int Id { get; set; }

        [Column("from")] public int From { get; set; }

        [Column("to")] public int To { get; set; }

        [Column("emotion_id")] public int EmotionId { get; set; }

        [Column("project_id")] public int ProjectId { get; set; }

        public Emotion Emotion { get; set; }

        public Project Project { get; set; }
    }
}
