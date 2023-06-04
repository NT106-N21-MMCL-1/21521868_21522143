using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using MailKit;
using MimeKit;
using MailKit.Net.Imap;
using MailKit.Search;

namespace bai2
{
    public partial class bai2 : Form
    {
        public bai2()
        {
            InitializeComponent();
        }
        public async Task ReceiveMail()
        {
            try
            {
                using (var client = new ImapClient())
                {
                    dgvContent.Rows.Clear();
                    await client.ConnectAsync("imap.gmail.com", 993, true);
                    client.Authenticate(txtEmail.Text.Trim(), txtPass.Text.Trim());

                    await client.Inbox.OpenAsync(FolderAccess.ReadOnly);

                    var query = SearchQuery.All;
                    var uids = await client.Inbox.SearchAsync(query);

                    dgvContent.Columns.Add("Subject", "Email");
                    dgvContent.Columns.Add("From", "From");
                    dgvContent.Columns.Add("Date", "Date");
                    dgvContent.Columns.Add("body", "Content");
                    //int count = 0;
                    //var item = new ListViewItem();
                    //listView1.Columns.Add("Subject");
                    //listView1.Columns.Add("From");
                    //listView1.Columns.Add("Date");
                    for (int i = 0; i < Int32.Parse(txtLimit.Text); i++)
                    {
                        //count++;
                        var message =await client.Inbox.GetMessageAsync(i);
                        dgvContent.Rows.Add(message.Subject,message.From, message.Date.ToString(), message.Body);
                        //item.Text = message.From.ToString() ; // Column 1 (Subject)
                        //item.SubItems.Add(message.From.ToString()); // Column 2 (From)
                        //item.SubItems.Add(message.Date.ToString());
                    }
                    //listView1.Items.Add(item);
                    client.Disconnect(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ReceiveMail();
        }

        private void bai2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
