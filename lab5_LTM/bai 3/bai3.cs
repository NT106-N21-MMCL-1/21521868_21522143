using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenPop;
using OpenPop.Mime;
using OpenPop.Pop3;

namespace bai_3
{
    public partial class bai3 : Form
    {
        public bai3()
        {
            InitializeComponent();
        }

        private void txtLimit_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            dgvContent.Rows.Clear();
            string username = txtEmail.Text.Trim();
            string password = txtPass.Text.Trim();
            string content = string.Empty;
            //opfdvpbpshlkmhdn
            try
            {
                using (var client = new Pop3Client())
                {
                    client.Connect("pop.gmail.com", 995, true);
                    client.Authenticate(username, password);
                    dgvContent.Columns.Add("subject", "Email");
                    dgvContent.Columns.Add("from", "From");
                    dgvContent.Columns.Add("date", "Date");
                    dgvContent.Columns.Add("body", "Content");
                    int TotalMessage = client.GetMessageCount();

                    for (int i = 1; i <= Int32.Parse(txtLimit.Text); i++)
                    {
                        var msg = client.GetMessage(i);
                        string subject = msg.Headers.Subject.ToString();
                        string from = msg.Headers.From.ToString();
                        string date = msg.Headers.Date.ToString();
                        MessagePart Plaintext = msg.FindFirstPlainTextVersion();
                        if(Plaintext != null) 
                        content = msg.FindFirstPlainTextVersion().GetBodyAsText();

                        dgvContent.Rows.Add(subject, from, date, content);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
