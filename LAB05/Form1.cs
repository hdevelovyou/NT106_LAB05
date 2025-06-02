using System.Net.Mail;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace LAB05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void send_btn_Click(object sender, EventArgs e)
        {
            //System.Net.ServicePointManager.ServerCertificateValidationCallback =
            //delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
            //{
            //    return true;
            //};
            using (SmtpClient smtpClient = new SmtpClient("127.0.0.1"))
            {
                string mailfrom = from_textBox.Text.ToString().Trim();
                string mailto = to_textBox.Text.ToString().Trim();
                string subject = subject_textBox.Text.ToString().Trim();
                string body = body_richTextBox.Text.ToString();
                string password = pass_textBox.Text.ToString().Trim();

                var basicCredential = new NetworkCredential(mailfrom, password);

                using (MailMessage message =new MailMessage())
                {
                    MailAddress fromAdress = new MailAddress(mailfrom);
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = basicCredential;

                    message.From = fromAdress;
                    message.Subject = subject;
                    message.IsBodyHtml = true;
                    message.Body = body;
                    message.To.Add(mailto);

                    try
                    {
                        smtpClient.Send(message);
                        MessageBox.Show("Email sent successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }    

            }
        }
    }
}
