namespace EmotionMarketing.Logic.Cognitive
{
    /// <summary>
    /// Ключи и URL от API Azure / Cognitive Services
    /// Отсюда: https://azure.microsoft.com/ru-ru/try/cognitive-services/my-apis/
    /// </summary>
    public class AzureConstants
    {

        public const string FaceSubscriptionKey = "35f6cd1355fc4e63b9098e26405aae3b";

        /// <summary>
        /// Документация Azure:
        ///
        /// You must use the same region as you used to get your subscription
        /// keys. For example, if you got your subscription keys from westus,
        /// replace "westcentralus" with "westus".
        ///
        /// Free trial subscription keys are generated in the westcentralus
        /// region. If you use a free trial subscription key, you shouldn't
        /// need to change the region.
        /// Specify the Azure region
        /// </summary>
        public const string FaceEndpoint = "https://westeurope.api.cognitive.microsoft.com/";

        // public const string VisionSubscriptionKey = "746b71c1a7e847b093065b442f26ffe6";
        public const string VisionSubscriptionKey = "312910038fee4cc297c0d18f0d5908c3";

        public const string VisionUriBase = "https://westcentralus.api.cognitive.microsoft.com";
    }
}
