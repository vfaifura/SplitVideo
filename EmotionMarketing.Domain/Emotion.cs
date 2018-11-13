using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmotionMarketing.Domain
{
    [Table("emotion")]
    public class Emotion
    {
        [Key]
        [Column("id")] public int Id { get; set; }

        [Column("name")] public string Name { get; set; }
    }
}
