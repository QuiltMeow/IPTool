using System;
using System.Net.Http;
using System.Windows.Forms;

namespace IPLookUp
{
    public static class Program
    {
        private const string GEO_IP_FILE_NAME = "GeoLite2-City.mmdb";
        private const string TRANSLATE_FILE_NAME = "s2tw.json";

        public static GeoIP geoIP
        {
            get;
            private set;
        }

        public static ChineseTranslate translate
        {
            get;
            private set;
        }

        public static HttpClient httpClient
        {
            get;
            private set;
        }

        private static void init()
        {
            geoIP = new GeoIP(GEO_IP_FILE_NAME);
            translate = new ChineseTranslate(TRANSLATE_FILE_NAME);
            httpClient = new HttpClient();
        }

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            init();
            Application.Run(new MainForm());
        }
    }
}