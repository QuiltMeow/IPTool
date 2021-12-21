using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPLookUp
{
    public partial class PingForm : Form
    {
        private bool hasConfirm;
        private string host;

        public PingForm(string input = CommandUtil.EMPTY_STRING)
        {
            InitializeComponent();
            txtInput.Text = input;
        }

        private static void showNoInput()
        {
            MessageBox.Show("請輸入 IP 或域名", "確認", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            host = txtInput.Text;
            if (string.IsNullOrWhiteSpace(host))
            {
                showNoInput();
                return;
            }
            txtInput.ReadOnly = hasConfirm = true;
            btnConfirm.Enabled = false;
            btnExecutePing.Enabled = btnExecuteTraceRouter.Enabled = true;
        }

        private async void btnExecutePing_Click(object sender, EventArgs e)
        {
            if (!hasConfirm)
            {
                showNoInput();
                return;
            }
            btnExecutePing.Enabled = false;
            txtPing.Text = string.Empty;
            await Task.Run(() => CommandUtil.ping(host, (source, receive) => Util.appendText(txtPing, receive.Data)));
            btnExecutePing.Enabled = true;
        }

        private async void btnExecuteTraceRouter_Click(object sender, EventArgs e)
        {
            if (!hasConfirm)
            {
                showNoInput();
                return;
            }
            btnExecuteTraceRouter.Enabled = false;
            txtTraceRouter.Text = string.Empty;
            await Task.Run(() => CommandUtil.traceRouter(host, (source, receive) => Util.appendText(txtTraceRouter, receive.Data)));
            btnExecuteTraceRouter.Enabled = true;
        }

        private void btnResetWinsock_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定重設 Winsock ?", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CommandUtil.runCommand("netsh winsock reset");
                MessageBox.Show("Winsock 重設完成 建議重新啟動電腦", "資訊", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnResetTcpIp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定重設 TCP / IP ?", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CommandUtil.runCommand("netsh interface ip reset");
                MessageBox.Show("TCP / IP 重設完成 建議重新啟動電腦", "資訊", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnFlushDNS_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定清除 DNS 快取 ?", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CommandUtil.runCommand("ipconfig /flushdns");
                MessageBox.Show("DNS 快取清除完成", "資訊", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}