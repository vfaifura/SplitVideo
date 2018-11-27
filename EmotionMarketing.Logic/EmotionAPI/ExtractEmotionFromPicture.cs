using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EmotionMarketing.Logic.Cognitive;
using EmotionMarketing.Logic.Detection;
using EmotionMarketing.Logic.Utils;
using Microsoft.Azure.CognitiveServices.Vision.Face.Models;

namespace EmotionMarketing.Logic.EmotionAPI
{
    public class ExtractEmotionFromPicture
    {
        public async Task<string> Process(string imgPath)
        {
            IList<DetectedFace> facesResult;
            // ImageAnalysis visionResult = null;

            try
            {
                Image image;

                using (var stream = File.Open(imgPath, FileMode.Open))
                {
                    image = Image.FromStream(stream);
                }

                // проверка (Emgu, Виола-Джонс) есть ли лицо
                var haveFaces = FaceDetector.ContainsFaces(new Bitmap(image));

                if (!haveFaces)
                {
                    return "No attention";
                }

                // анализ лица
                var face = new FaceService.Create()
                           .WithSubscriptionKey(AzureConstants.FaceSubscriptionKey)
                           .WithEndpoint(AzureConstants.FaceEndpoint)
                           .Get().Init();

                facesResult = await face.AnalyzeFaceLocalAsync(imgPath);
            }
            catch (Exception ex)
            {
                MessageSender.ErrorMessage(ex.Message);
                return null;
            }

            /*
            // анализа изображения
            var computeVision = new VisionService.Create()
                                .WithSubscriptionKey(AzureConstants.VisionSubscriptionKey)
                                .WithEndpoint(AzureConstants.VisionUriBase)
                                .Get().Init();

            visionResult = await computeVision.AnalyzeLocalAsync(imgPath);
            */

            var dictionary = new Dictionary<string, double>
            {
                {"Anger", facesResult?.First().FaceAttributes.Emotion.Anger ?? 0},
                {"Contempt", facesResult?.First().FaceAttributes.Emotion.Contempt ?? 0},
                {"Disgust", facesResult?.First().FaceAttributes.Emotion.Disgust ?? 0},
                {"Fear", facesResult?.First().FaceAttributes.Emotion.Fear ?? 0},
                {"Happiness", facesResult?.First().FaceAttributes.Emotion.Happiness ?? 0},
                {"Neutral", facesResult?.First().FaceAttributes.Emotion.Neutral ?? 0},
                {"Sadness", facesResult?.First().FaceAttributes.Emotion.Sadness ?? 0},
                {"Surprise", facesResult?.First().FaceAttributes.Emotion.Surprise ?? 0}
            };

            // todo handle gender
            // var gender = facesResult?.First().FaceAttributes.Gender.ToString();

            // todo revise whether we need it
            // var smile = facesResult?.First().FaceAttributes.Smile.ToString();

            return dictionary.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
        }
    }
}
