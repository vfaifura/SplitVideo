using System;
using System.Drawing;
using System.IO;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace EmotionMarketing.Logic.Detection
{
    public class FaceDetector
    {
        /// <summary>
        /// Функция проверки изображения на наличие на нем лиц
        /// Функция обнаруживает лица, расположенные под углом отклонения менее 30 градусов.
        /// Это обусловлено ограничениями, накладываемыми алгоритмом Виолы-Джонса.
        /// </summary>
        /// <param name="image">Входное изображение </param>
        /// <returns>true если на изображении есть лица, false если лиц нет</returns>
        public static bool ContainsFaces(Bitmap image)
        {
            // Полный путь к файлу каскада Хаара
            string cascadeFile = Path.Combine(Environment.CurrentDirectory,
                @"cascades\haarcascade_frontalface_default.xml");

            // Открыть файл каскада
            var cascade = new HaarCascade(cascadeFile);

            // Преобразовать входное изображение в нужный формат
            var convertedImage = new Image<Bgr, byte>(image);
            var grayImage = convertedImage.Convert<Gray, byte>();

            // Обнаружить лица на изображении
            // (описание параметров функции см. на http://www.emgu.com/wiki/files/2.4.2/document/html/11c784fc-7d30-a921-07ec-ecdb7d217bbe.htm)
            var faces = grayImage.DetectHaarCascade(cascade, 1.1, 4,
                HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                new Size(image.Width / 15, image.Height / 15))[0];

            // Если на изображении есть хотя бы одно лицо - вернуть true, иначе false
            return faces.Length > 0;
        }
    }
}
