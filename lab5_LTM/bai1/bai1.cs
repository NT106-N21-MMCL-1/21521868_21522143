using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace bai1
{
    public partial class bai1 : Form
    {
        public bai1()
        {
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Port = 587;
            InitializeComponent();
        }

        public void SendMessage() { 
            
            try
            {
            string senderEmail = txtsender.Text.Trim();
           
            string recipientEmail = txtrec.Text.Trim();
            string subject = txtsub.Text;
            string body = rtxt.Text;

            MailMessage mail = new MailMessage(senderEmail, recipientEmail, subject, body);

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.UseDefaultCredentials = false;
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new NetworkCredential(senderEmail, "uxzdjucburyxtmup");

            smtpClient.Send(mail);

            MessageBox.Show("Email sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsub.Clear();
                rtxt.Clear();
            }
            catch (Exception ex)
            {
            MessageBox.Show("Failed to send email. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendMessage();
        }
    }
}
