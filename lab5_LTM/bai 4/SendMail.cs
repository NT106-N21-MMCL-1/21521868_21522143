using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MimeKit;

namespace Bai4
{
    public partial class SendMail : Form
    {
        public SendMail()
        {
            InitializeComponent();
        }
        string pass_m = null;
        public void DisplayEmail(string to, string from, string subject, string date, string body, string pass)
        {
            sendTo.Text = to;
            rcvFrom.Text = from;
            this.subject.Text = subject;
            this.body.Text = body;
            pass_m = pass;
        }
        string email;
        private void bt_Send_Click(object sender, EventArgs e)
        {
            try
            {
                string to = sendTo.Text;
                string from = rcvFrom.Text;
                string subject = this.subject.Text;
                string body = this.body.Text;
                bool check = false;
                email = string.Empty;
                for (int i=0; i<to.Length; i++)
                {
                    if (to[i] =='<') { check = true;i++; }
                    if (to[i] == '>') { check = false; break; }
                    if (check) { email += to[i]; }
                }   
                if (email == string.Empty) { email = to; }
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("", from));
                message.To.Add(new MailboxAddress("", email));
                message.Subject = subject;

                var bodyBuilder = new BodyBuilder();
                bodyBuilder.TextBody = body;

                string filePath = url.Text; 
                if (!string.IsNullOrEmpty(filePath))
                {
                    bodyBuilder.Attachments.Add(filePath);
                }

                message.Body = bodyBuilder.ToMessageBody();

                using (var client = new MailKit.Net.Smtp.SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 465, true);
                    client.Authenticate(from, pass_m);
                    client.Send(message);
                    client.Disconnect(true);
                }

                MessageBox.Show("Email sent successfully.", "Success", MessageBoxButtons.OK);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending email: "+email + ex.Message);
            }
        }
        private void bt_attach_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false; 
            openFileDialog.Filter = "All Files (*.*)|*.*"; 

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                url.Text = filePath;
            }
        }
    }
}
