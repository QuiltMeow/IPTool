using DnsClient;
using DnsClient.Protocol;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Whois;

namespace IPLookUp
{
    public partial class DomainForm : Form
    {
        private readonly IWhoisLookup whois;
        private readonly ILookupClient dnsClient;

        public DomainForm(string domain = CommandUtil.EMPTY_STRING)
        {
            InitializeComponent();
            txtInput.Text = domain;

            whois = new WhoisLookup();
            dnsClient = new LookupClient();
        }

        private ISet<string> queryDNSRecord(string domain, QueryType type)
        {
            ISet<string> ret = new HashSet<string>();
            try
            {
                IEnumerable<DnsResourceRecord> result = dnsClient.Query(domain, type).AllRecords;
                foreach (DnsResourceRecord data in result)
                {
                    ret.Add(data.ToString());
                }
            }
            catch
            {
            }
            return ret;
        }

        private ISet<string> queryAllDNSRecord(string domain)
        {
            ISet<string> ret = new HashSet<string>();
            IEnumerable<QueryType> allType = Enum.GetValues(typeof(QueryType)).Cast<QueryType>();
            foreach (QueryType value in allType)
            {
                ret.UnionWith(queryDNSRecord(domain, value));
            }
            return ret;
        }

        private void setLoading(bool loading)
        {
            txtInput.ReadOnly = loading;
            btnQuery.Enabled = !loading;
            if (loading)
            {
                txtWhois.Text = txtDNSRecord.Text = "查詢中 ...";
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
            WhoisResponse whoisQuery = await Task.Run(() =>
            {
                try
                {
                    return whois.Lookup(host);
                }
                catch
                {
                    return null;
                }
            });
            txtWhois.Text = whoisQuery != null ? whoisQuery.Content : "查詢失敗";
            Util.updateControlTextResult(txtDNSRecord, await Task.Run(() => queryAllDNSRecord(host)), true);
            setLoading(false);
        }
    }
}