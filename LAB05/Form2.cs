using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Imap;
using MailKit.Security;
using MimeKit;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using MailKit;

namespace LAB05
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.Columns.Add("Email", 200);
            listView1.Columns.Add("From", 100);
            listView1.Columns.Add("Thời gian", 100);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                System.Net.ServicePointManager.ServerCertificateValidationCallback =
                delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
                {
                    return true;
                };
                using (var client = new ImapClient())
                {
                    client.Connect("127.0.0.1", 993, SecureSocketOptions.SslOnConnect);
                    client.Authenticate(tbMail.Text.Trim(), tbPass.Text.Trim());
                    var inbox = client.Inbox;
                    inbox.Open(MailKit.FolderAccess.ReadOnly);

                    listView1.Items.Clear();
                    int total = inbox.Count;
                    label5.Text= total.ToString();

                    int recent = 0;
                    var summaries = inbox.Fetch(0, -1, MessageSummaryItems.Flags);
                    foreach (var summary in summaries)
                    {
                        if (!summary.Flags.HasValue || !summary.Flags.Value.HasFlag(MessageFlags.Seen))
                        {
                            recent++;
                        }
                    }
                    label6.Text= recent.ToString();

                    for (int i = 0; i < inbox.Count; i++)
                    {
                        var message = inbox.GetMessage(i);
                        var item = new ListViewItem(message.Subject);

                        item.SubItems.Add(message.From.ToString());
                        item.SubItems.Add(message.Date.DateTime.ToString("dd/MM/yyyy HH:mm:ss"));

                        listView1.Items.Add(item);
                    }

                    client.Disconnect(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
