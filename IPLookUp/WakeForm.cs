using System;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPLookUp
{
    public partial class WakeForm : Form
    {
        private const int PACKET_SIZE = 102;

        public WakeForm()
        {
            InitializeComponent();
            cbPort.SelectedIndex = 0;
        }

        public static void sendPacket(string ipAddress, string macAddress, int port = 9)
        {
            IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse(ipAddress), port);
            byte[] macByte = macAddress.Split('-', ':').Select(value => Convert.ToByte(value, 16)).ToArray();

            using (UdpClient udpClient = new UdpClient())
            {
                byte[] data = new byte[PACKET_SIZE];
                for (int i = 0; i < 6; ++i)
                {
                    data[i] = 0xFF;
                }
                for (int i = 1; i <= 16; ++i)
                {
                    macByte.CopyTo(data, i * 6);
                }
                udpClient.Send(data, PACKET_SIZE, ipEndPoint);
            }
        }

        private void setSending(bool send)
        {
            txtIP.ReadOnly = txtMAC.ReadOnly = send;
            cbPort.Enabled = btnSend.Enabled = !send;
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            string ip = txtIP.Text;
            if (!IPUtil.isIPAddress(ip))
            {
                MessageBox.Show("請輸入有效 IP 位址", "輸入", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string mac = txtMAC.Text;
            if (!IPUtil.isMACAddress(mac))
            {
                MessageBox.Show("請輸入有效 MAC 位址", "輸入", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int port = int.Parse(cbPort.SelectedItem.ToString());
            setSending(true);
            await Task.Run(() =>
            {
                try
                {
                    sendPacket(ip, mac, port);
                    MessageBox.Show("封包已發送", "資訊", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"發送封包時發生例外狀況 : {ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });
            setSending(false);
        }
    }
}