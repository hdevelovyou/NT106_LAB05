using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MimeKit;
using MailKit.Net.Smtp;
using MailKit.Security;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace LAB05
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            string fromEmail = tbFrom.Text;
            string toEmail = tbTo.Text;
            string subject = tbSubject.Text;
            string body = tbBody.Text;
            string password = tbPasswd.Text;
            string attachmentPath = tbPath.Text.Trim();
            try
            {
                var message = new MimeMessage();
                message.From.Add(MailboxAddress.Parse(fromEmail));
                message.To.Add(MailboxAddress.Parse(toEmail));
                message.Subject = subject;
                var bodyBuilder = new BodyBuilder
                {
                    TextBody = body
                };

                // Nếu có file đính kèm và file tồn tại
                if (!string.IsNullOrEmpty(attachmentPath) && File.Exists(attachmentPath))
                {
                    bodyBuilder.Attachments.Add(attachmentPath);
                }

                message.Body = bodyBuilder.ToMessageBody();

                using var smtp = new SmtpClient();
                await smtp.ConnectAsync("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                await smtp.AuthenticateAsync(fromEmail, password);
                await smtp.SendAsync(message);
                await smtp.DisconnectAsync(true);

                MessageBox.Show("Email đã gửi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gửi email thất bại:\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Chọn tệp đính kèm";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tbPath.Text = ofd.FileName;
            }
        }
    }
}
