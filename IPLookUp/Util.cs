using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace IPLookUp
{
    public static class Util
    {
        public static void updateControlTextResult(Control control, IEnumerable<object> result, bool extraLine = false)
        {
            if (result == null)
            {
                control.Text = "查詢失敗";
                return;
            }

            StringBuilder sb = new StringBuilder();
            foreach (object data in result)
            {
                sb.AppendLine(data.ToString());
                if (extraLine)
                {
                    sb.AppendLine();
                }
            }
            control.Text = sb.ToString();
        }

        public static void appendText(TextBox textBox, string text)
        {
            if (text == null)
            {
                return;
            }
            try
            {
                textBox.Invoke((MethodInvoker)delegate
                {
                    textBox.AppendText($"{text}{Environment.NewLine}");
                });
            }
            catch
            {
            }
        }

        public static void openForm(Type type)
        {
            using (Form form = (Form)Activator.CreateInstance(type))
            {
                form.ShowDialog();
            }
        }
    }
}