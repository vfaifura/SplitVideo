using System.Linq;
using EmotionMarketing.Domain;

namespace EmotionMarketing.Logic.DbWorker
{
    public class ActualResultWorker
    {
        public void Create(string emotion, int projectId, int timeIndex)
        {
            using (var db = new emotionDb())
            {
                var emotionInstance = db.Emotions.FirstOrDefault(x => x.Name.Equals(emotion));

                var actualResult = new ActualResult
                {
                    ProjectId = projectId,
                    TimeIndex = timeIndex,
                    Emotion = emotionInstance
                };

                db.Add(actualResult);
                db.SaveChanges();
            }
        }
    }
}
