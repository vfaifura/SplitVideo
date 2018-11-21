using System.Windows.Forms;

namespace EmotionMarketing.Logic.Utils
{
    public static class MessageSender
    {
        public static void SuccessMessage(string text)
        {
            MessageBox.Show(text, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void WarningMessage(string text)
        {
            MessageBox.Show(text, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ErrorMessage(string text)
        {
            MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult AskMessage(string text)
        {
            return MessageBox.Show(text, "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
