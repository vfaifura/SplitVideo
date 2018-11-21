using System.Linq;
using System.Windows.Forms;
using EmotionMarketing.Domain;

namespace EmotionMarketing.Logic.Utils
{
    public static class ComboBoxLoader
    {
        public static void LoadGenreComboBox(ref ComboBox target)
        {
            using (var db = new emotionDb())
            {
                var genre = db.Genres.Select(x => x.Name).ToArray();
                AddToBox(genre, ref target);
            }
        }

        public static void LoadEmotionComboBox(ref DataGridViewComboBoxColumn target)
        {
            using (var db = new emotionDb())
            {
                var genre = db.Emotions.Select(x => x.Name).ToArray();
                target.Items.AddRange(genre);
            }
        }

        private static void AddToBox(string[] set, ref ComboBox target)
        {
            target.Items.AddRange(set);
            target.AutoCompleteCustomSource.AddRange(set);
        }
    }
}
