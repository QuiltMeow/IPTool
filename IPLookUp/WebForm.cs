using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace IPLookUp
{
    public partial class WebForm : Form
    {
        public static bool isWebViewInstall()
        {
            string registryKey = @"SOFTWARE\WOW6432Node\Microsoft\EdgeUpdate\Clients";
            using (RegistryKey edgeKey = Registry.LocalMachine.OpenSubKey(registryKey))
            {
                if (edgeKey != null)
                {
                    string[] productKey = edgeKey.GetSubKeyNames();
                    if (productKey.Any())
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public WebForm(string title, Size size, string url)
        {
            if (!isWebViewInstall())
            {
                if (MessageBox.Show("Web View 2 執行階段尚未安裝 按下確定後進入下載頁面", "執行階段", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start("https://developer.microsoft.com/zh-tw/microsoft-edge/webview2");
                }
                Close();
                return;
            }
            InitializeComponent();
            Text = title;
            Size = size;
            webView.Source = new Uri(url);
        }
    }
}