using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmotionMarketing.Domain
{
    [Table("genre")]
    public class Genre
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
