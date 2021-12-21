using MaxMind.GeoIP2.Model;
using MaxMind.GeoIP2.Responses;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPLookUp
{
    public partial class MainForm : Form
    {
        private const bool MAP_POINT = true;
        private const int NO_POINT_ZOOM = 16;
        private const string ORIGIN_CHINESE_NAME = "zh-CN";

        private static readonly Size DEFAULT_WEB_SIZE = new Size(1000, 650);
        private string mapUrl;

        public MainForm()
        {
            InitializeComponent();
        }

        public static bool hasInternet()
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    using (client.OpenRead("http://google.com/generate_204"))
                    {
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        public void updateGeoIPResult(CityResponse result)
        {
            StringBuilder sb = new StringBuilder();
            Country country = result.Country;
            City city = result.City;
            ChineseTranslate translate = Program.translate;
            sb.Append("國碼 : ").AppendLine(country.IsoCode);

            sb.Append("國家原文 : ").AppendLine(country.Name);
            IReadOnlyDictionary<string, string> countryName = country.Names;
            if (countryName.ContainsKey(ORIGIN_CHINESE_NAME))
            {
                sb.Append("國家名稱 : ").AppendLine(translate.convertTraditionalChinese(countryName[ORIGIN_CHINESE_NAME]));
            }

            sb.Append("城市原文 : ").AppendLine(city.Name);
            IReadOnlyDictionary<string, string> cityName = city.Names;
            if (cityName.ContainsKey(ORIGIN_CHINESE_NAME))
            {
                sb.Append("城市名稱 : ").AppendLine(translate.convertTraditionalChinese(cityName[ORIGIN_CHINESE_NAME]));
            }

            sb.Append("郵遞區號 : ").AppendLine(result.Postal.Code);
            Location location = result.Location;
            string longitude = location.Longitude?.ToString();
            string latitude = location.Latitude?.ToString();

            sb.Append("經度 : ").AppendLine(longitude);
            sb.Append("緯度 : ").Append(latitude);
            labelGeoIP.Text = sb.ToString();

            if (longitude == null || latitude == null)
            {
                mapUrl = null;
                return;
            }
            mapUrl = MAP_POINT ? $"http://maps.google.com/maps?q={latitude},{longitude}" : $"https://www.google.com.tw/maps/@{latitude},{longitude},{NO_POINT_ZOOM}z";
        }

        public void updateQQWryResult(IPWry.IPWryResult result)
        {
            StringBuilder sb = new StringBuilder();
            ChineseTranslate translate = Program.translate;
            sb.AppendLine(translate.convertTraditionalChinese(result.mainInformation));
            sb.Append(translate.convertTraditionalChinese(result.subInformation));
            labelQQWry.Text = sb.ToString();
        }

        private async Task query(string input)
        {
            GeoIP geoIP = Program.geoIP;
            if (IPUtil.isIPAddress(input))
            {
                updateGeoIPResult(await Task.Run(() => geoIP.queryIP(input)));
                updateQQWryResult(await Task.Run(() => IPWry.queryIP(input)));
                Util.updateControlTextResult(txtReverse, await Task.Run(() => DomainUtil.queryDomain(input)));
            }
            else
            {
                IPAddress[] ip = await Task.Run(() => DomainUtil.queryIP(input));
                if (ip == null)
                {
                    labelGeoIP.Text = labelQQWry.Text = "找不到目標主機";
                    Util.updateControlTextResult(txtReverse, null);
                    return;
                }

                string query = IPUtil.getFirstIPv4Address(ip);
                if (query == null)
                {
                    query = ip[0].ToString();
                }

                updateGeoIPResult(await Task.Run(() => geoIP.queryIP(query)));
                updateQQWryResult(await Task.Run(() => IPWry.queryIP(query)));

                IList<string> reverse = new List<string>();
                reverse.Add(input);
                foreach (IPAddress address in ip)
                {
                    reverse.Add(address.ToString());
                }
                Util.updateControlTextResult(txtReverse, reverse);
            }
        }

        private void setLoading(bool loading)
        {
            txtInput.ReadOnly = loading;
            btnQuery.Enabled = !loading;
            if (loading)
            {
                mapUrl = null;
                labelGeoIP.Text = labelQQWry.Text = txtReverse.Text = "查詢中 ...";
            }
        }

        private async void btnQuery_Click(object sender, EventArgs e)
        {
            string host = txtInput.Text;
            if (string.IsNullOrWhiteSpace(host))
            {
                MessageBox.Show("請輸入查詢內容", "查詢", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            setLoading(true);
            await query(host);
            setLoading(false);
        }

        private void btnDNSTool_Click(object sender, EventArgs e)
        {
            string host = txtInput.Text;
            if (IPUtil.isIPAddress(host))
            {
                host = string.Empty;
            }

            using (DomainForm form = new DomainForm(host))
            {
                form.ShowDialog();
            }
        }

        private void btnDiagnosticTool_Click(object sender, EventArgs e)
        {
            using (PingForm form = new PingForm(txtInput.Text))
            {
                form.ShowDialog();
            }
        }

        private async void updateInternetStatus()
        {
            bool status = await Task.Run(() => hasInternet());
            tsslStatus.Text = $"網路狀態{(status ? "良好" : "受限")}";
        }

        private void timerNetworkStatus_Tick(object sender, EventArgs e)
        {
            updateInternetStatus();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            updateInternetStatus();
            timerNetworkStatus.Start();
        }

        private void btnCopyGeoIP_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(labelGeoIP.Text);
        }

        private void btnCopyQQWry_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(labelQQWry.Text);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Environment.Exit(Environment.ExitCode);
            }
            catch
            {
                Process.GetCurrentProcess().Kill();
            }
        }

        private void btnIP_Click(object sender, EventArgs e)
        {
            Util.openForm(typeof(IPForm));
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            if (mapUrl == null)
            {
                MessageBox.Show("無法查詢地圖位置", "地圖", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            openWebForm("Google 地圖", DEFAULT_WEB_SIZE, mapUrl);
        }

        private static void openWebForm(string title, Size size, string url)
        {
            using (WebForm form = new WebForm(title, size, url))
            {
                if (form.IsDisposed)
                {
                    return;
                }
                form.ShowDialog();
            }
        }

        private void btnSpeedTest_Click(object sender, EventArgs e)
        {
            openWebForm("網路速度測試", DEFAULT_WEB_SIZE, "https://quilt.speedtestcustom.com/");
        }

        private void btnWake_Click(object sender, EventArgs e)
        {
            Util.openForm(typeof(WakeForm));
        }
    }
}