using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using EmotionMarketing.Logic.Cognitive;
using EmotionMarketing.Logic.Detection;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models;
using Microsoft.Azure.CognitiveServices.Vision.Face.Models;

namespace SplitVideo.Test
{
    public partial class FormMain : Form
    {
        public FormMain() => InitializeComponent();

        private async void ButtonOpen_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();

            if (dialog.ShowDialog() != DialogResult.OK) return;

            // "результаты анализов"
            IList<DetectedFace> facesResult = null;
            ImageAnalysis visionResult = null;

            try
            {
                Image image;

                using (var stream = File.Open(dialog.FileName, FileMode.Open))
                {
                    image = Image.FromStream(stream);
                }

                Picture.Image = image;

                // проверка (Emgu, Виола-Джонс) есть ли лицо
                bool haveFaces = FaceDetector.ContainsFaces(new Bitmap(image));

                if (!haveFaces)
                {
                    MessageBox.Show(@"На изображении лиц не обнаружено.", @"Внимание!");
                    return;
                }

                StatusLabel.Text = @"Анализ изображения...";

                // анализ лица
                var face = new FaceService.Create()
                           .WithSubscriptionKey(AzureConstants.FaceSubscriptionKey)
                           .WithEndpoint(AzureConstants.FaceEndpoint)
                           .Get().Init();

                facesResult = await face.AnalyzeFaceLocalAsync(dialog.FileName);

                // анализа изображения
                var computeVision = new VisionService.Create()
                                    .WithSubscriptionKey(AzureConstants.VisionSubscriptionKey)
                                    .WithEndpoint(AzureConstants.VisionUriBase)
                                    .Get().Init();

                visionResult = await computeVision.AnalyzeLocalAsync(dialog.FileName);

                StatusLabel.Text = @"Анализ завершен.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Ошибка!");
                StatusLabel.Text = @"Произошла ошибка";
            }

            // вывод результатов

            TBoxTags.Clear();
            TBoxCaptions.Clear();

            LabelAnger.Text = facesResult?.First().FaceAttributes.Emotion.Anger.ToString();
            LabelContempt.Text = facesResult?.First().FaceAttributes.Emotion.Contempt.ToString();
            LabelDisgust.Text = facesResult?.First().FaceAttributes.Emotion.Disgust.ToString();
            LabelFear.Text = facesResult?.First().FaceAttributes.Emotion.Fear.ToString();
            LabelHappiness.Text = facesResult?.First().FaceAttributes.Emotion.Happiness.ToString();
            LabelNeutral.Text = facesResult?.First().FaceAttributes.Emotion.Neutral.ToString();
            LabelSadness.Text = facesResult?.First().FaceAttributes.Emotion.Sadness.ToString();
            LabelSurprise.Text = facesResult?.First().FaceAttributes.Emotion.Surprise.ToString();

            LabelSmile.Text = facesResult?.First().FaceAttributes.Smile.ToString();
            LabelGlasses.Text = facesResult?.First().FaceAttributes.Glasses.ToString();
            LabelSex.Text = facesResult?.First().FaceAttributes.Gender.ToString();

            visionResult?.Tags?.ToList().ForEach(i => TBoxTags.Text += $"{i.Name}  ");
            visionResult?.Description?.Captions.ToList().ForEach(i => TBoxCaptions.Text += $"{i.Text}\n");

            // определяем преобладающую эмоцию
            var emotions = facesResult?.First().FaceAttributes.Emotion;
            if (emotions != null)
            {
                var list = new Dictionary<string, double>()
                {
                    {"Презрение", emotions.Contempt},
                    {"Гнев", emotions.Anger},
                    {"Отвращение", emotions.Disgust},
                    {"Страх", emotions.Fear},
                    {"Счастье", emotions.Happiness},
                    {"Нейтральный", emotions.Neutral},
                    {"Печаль", emotions.Sadness},
                    {"Удивление", emotions.Surprise}
                };

                LabelDominated.Text = (from i in list
                                       where i.Value == list.Max(v => v.Value)
                                       select i.Key).First();
                ;

            }
        }
    }
}
