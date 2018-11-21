using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Azure.CognitiveServices.Vision.Face;
using Microsoft.Azure.CognitiveServices.Vision.Face.Models;

namespace EmotionMarketing.Logic.Cognitive
{
    public class FaceService : CognitiveService<FaceService>
    {
        /// <summary>
        /// Атрибуты изображения с лицом: эмоции, пол, очки?, улыбка?, макияж, шум, ...
        /// </summary>
        public FaceAttributeType[] FaceAttributes { get; set; } =
        {
            FaceAttributeType.Emotion, FaceAttributeType.Gender, FaceAttributeType.Glasses,
            FaceAttributeType.Smile, FaceAttributeType.Makeup, FaceAttributeType.Noise
        };

        private FaceClient faceClient;

        public override FaceService Init()
        {
            faceClient = new FaceClient(
                new ApiKeyServiceClientCredentials(ApiSubscriptionKey))
            {
                Endpoint = ApiEndpoint
            };

            return this;
        }


        /// <summary>
        /// Анализировать изображение по URL
        /// </summary>
        /// <returns>Список обнаруженных лиц и данные анализа</returns>
        public async Task<IList<DetectedFace>> AnalyzeFaceRemoteAsync(string imageUrl)
        {
            if (faceClient == null)
                throw new Exception("Client not initialized.");
            if (!Uri.IsWellFormedUriString(imageUrl, UriKind.Absolute))
                throw new Exception($"Invalid remote image url: {imageUrl}");

            return await faceClient.Face.DetectWithUrlAsync(
                imageUrl, false, true, FaceAttributes);
        }

        /// <summary>
        /// Анализировать изображение на диске
        /// </summary>
        /// <returns>Список обнаруженных лиц и данные анализа</returns>
        public async Task<IList<DetectedFace>> AnalyzeFaceLocalAsync(string imagePath)
        {
            if (faceClient == null)
                throw new Exception("Client not initialized.");
            if (!File.Exists(imagePath))
                throw new Exception($"Unable to open or read local image: {imagePath}");

            using (Stream imageStream = File.OpenRead(imagePath))
            {
                return await faceClient.Face.DetectWithStreamAsync(
                    imageStream, false, true, FaceAttributes);
            }
        }

    }
}
