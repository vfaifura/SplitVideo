using System.Linq;
using EmotionMarketing.Domain;

namespace EmotionMarketing.Logic.DbWorker
{
    public class ExpectedResultWorker
    {
        public void Create(int projectId, int from, int to, string emotion)
        {
            using (var db = new emotionDb())
            {
                var emotionInstance = db.Emotions.FirstOrDefault(x => x.Name.Equals(emotion));

                var expectedResult = new ExpectedResult
                {
                    ProjectId = projectId,
                    From = from,
                    To = to,
                    Emotion = emotionInstance
                };

                db.ExpectedResults.Add(expectedResult);
                db.SaveChanges();
            }
        }
    }
}
