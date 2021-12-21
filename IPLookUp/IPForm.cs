using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPLookUp
{
    public partial class IPForm : Form
    {
        public IPForm()
        {
            InitializeComponent();
        }

        private void btnCopyIPv4_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(labelIPv4.Text);
        }

        private void btnCopyIPv6_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(labelIPv6.Text);
        }

        private async void IPForm_Load(object sender, EventArgs e)
        {
            string IPv4 = null, IPv6 = null;
            txtAdapter.Text = string.Empty;
            await Task.Run(() =>
            {
                string errorMesssage;
                HttpClient client = Program.httpClient;
                IPv4 = IPUtil.getPublicIPAddress(client, out errorMesssage);
                IPv6 = IPUtil.getPublicIPAddress(client, out errorMesssage, false);
                if (IPv4 == null)
                {
                    IPv4 = "無法取得";
                }
                if (IPv6 == null)
                {
                    IPv6 = "無法取得";
                }
                CommandUtil.runProcess("ipconfig.exe", string.Empty, (source, receive) => Util.appendText(txtAdapter, receive.Data));
            });

            labelIPv4.Text = IPv4;
            labelIPv6.Text = IPv6;
        }
    }
}