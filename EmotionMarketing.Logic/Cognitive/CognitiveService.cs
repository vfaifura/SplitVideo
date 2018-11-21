using System;

namespace EmotionMarketing.Logic.Cognitive
{
    public abstract class CognitiveService<T> where T : CognitiveService<T>, new ()
    {
        public string ApiSubscriptionKey { get; protected set; }
        public string ApiEndpoint { get; protected set; }

        public abstract T Init();

        /// <summary>
        /// Паттерн "Строитель" (Builder) для конфигурации объекта
        ///
        /// Использование:
        /// 
        /// var someService = new SomeService.Create()
        ///         .WithSubscriptionKey(key)
        ///         .WithEndpoint(endpoint)
        ///         .Get();
        /// </summary>
        public class Create
        {
            private readonly T obj = new T();

            public Create WithSubscriptionKey(string apiKey)
            {
                if (string.IsNullOrEmpty(apiKey))
                    throw new Exception("Cognitive service create failed: API <Subscription key> not set.");

                obj.ApiSubscriptionKey = apiKey;

                return this;
            }

            public Create WithEndpoint(string apiEndpoint)
            {
                if (string.IsNullOrEmpty(apiEndpoint))
                    throw new Exception("Cognitive service create failed: API <Endpoint> not set.");

                obj.ApiEndpoint = apiEndpoint;

                return this;
            }

            public T Get() => obj;
        }
    }
}
