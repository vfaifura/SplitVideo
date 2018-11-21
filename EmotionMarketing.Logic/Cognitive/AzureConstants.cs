namespace EmotionMarketing.Logic.Cognitive
{
    /// <summary>
    /// Ключи и URL от API Azure / Cognitive Services
    /// Отсюда: https://azure.microsoft.com/ru-ru/try/cognitive-services/my-apis/
    /// </summary>
    public class AzureConstants
    {

        public const string FaceSubscriptionKey = "e852ecadf15b472491da893efeb8481e";

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
        public const string VisionSubscriptionKey = "43610666-9104-4ef5-a6ad-eeab6d9d7152";

        public const string VisionUriBase = "https://westcentralus.api.cognitive.microsoft.com";
    }
}
