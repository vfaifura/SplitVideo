using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models;

namespace EmotionMarketing.Logic.Cognitive
{
    public class VisionService : CognitiveService<VisionService>
    {
        public List<VisualFeatureTypes> Features { get; } =
            new List<VisualFeatureTypes>
            {
                VisualFeatureTypes.Categories, VisualFeatureTypes.Description,
                VisualFeatureTypes.Faces, VisualFeatureTypes.ImageType,
                VisualFeatureTypes.Tags
            };

        private ComputerVisionClient computerVision;

        public override VisionService Init()
        {
            computerVision = new ComputerVisionClient(
                    new ApiKeyServiceClientCredentials(ApiSubscriptionKey))
            {
                Endpoint = ApiEndpoint
            };

            return this;

        }

        // Analyze a remote image
        public async Task<ImageAnalysis> AnalyzeRemoteAsync(string imageUrl)
        {
            if (computerVision == null)
                throw new Exception("Client not initialized.");
            if (!Uri.IsWellFormedUriString(imageUrl, UriKind.Absolute))
                throw new Exception($"Invalid remote image url: {imageUrl}");

            return await computerVision.AnalyzeImageAsync(imageUrl, Features);
        }

        // Analyze a local image
        public async Task<ImageAnalysis> AnalyzeLocalAsync(string imagePath)
        {
            if (computerVision == null)
                throw new Exception("Client not initialized.");
            if (!File.Exists(imagePath))
                throw new Exception($"Unable to open or read local image: {imagePath}");

            using (Stream imageStream = File.OpenRead(imagePath))
            {
                return await computerVision
                    .AnalyzeImageInStreamAsync(imageStream, Features);
            }
        }
    }
}
