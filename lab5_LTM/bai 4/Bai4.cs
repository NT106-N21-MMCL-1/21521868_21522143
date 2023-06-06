using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Windows.Forms;
using MailKit;
using MailKit.Net.Imap;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bai4
{
    public partial class Bai4 : Form
    {
        private MailKit.Net.Imap.ImapClient client; 

        public Bai4()
        {
            InitializeComponent();
            client = new MailKit.Net.Imap.ImapClient(); 
        }

        private void bt_Login_Click(object sender, EventArgs e)
        {
            Login.Enabled = false;
            Logout.Enabled = true;
            compose.Enabled = true;
            Refresh.Enabled = true;
            try
            {
                
                string IMAP_SERVER = imap.Text;
                int IMAP_PORT = Int32.Parse(Port_imap.SelectedItem.ToString());
                string IMAP_USERNAME = user.Text;
                string IMAP_PASSWORD = pass.Text;

                client.Connect(IMAP_SERVER, IMAP_PORT, true);
                client.Authenticate(IMAP_USERNAME, IMAP_PASSWORD);

                load_dgv(sender,e);
            }
            catch (Exception ex)
            {
                client.Disconnect(true);
                Logout.Enabled = false;
                Refresh.Enabled = false;
                compose.Enabled = false;
                Login.Enabled = true;
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
        private void load_dgv(object sender, EventArgs e)
        {
            Mail.Rows.Clear();
            var inbox = client.Inbox;

            inbox.Open(MailKit.FolderAccess.ReadOnly);
            for (int i = 0; i < inbox.Count; i++)
            {
                var message = inbox.GetMessage(i);
                Mail.Rows.Add((i + 1).ToString(), message.From, message.Subject, message.Date, message.TextBody);
            }
        }
        private void Bai4_Load(object sender, EventArgs e)
        {
            Port_imap.Items.Clear();
            Port_imap.Items.Add("993");
            Port_Smtp.Items.Clear();
            Port_Smtp.Items.Add("465");
            imap.Text = "imap.gmail.com";
            SMTP.Text = "smtp.gmail.com";
            Port_imap.SelectedItem = "993";
            Port_Smtp.SelectedItem = "465";
            Logout.Enabled = false;
            Refresh.Enabled = false;
            compose.Enabled = false;
            Login.Enabled = true;
            Mail.Rows.Clear();
        }


        private void dgv_Mail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                string from = Mail.Rows[rowIndex].Cells["From"].Value.ToString();
                string subject = Mail.Rows[rowIndex].Cells["Subject"].Value.ToString();
                DateTimeOffset dateTimeOffset = (DateTimeOffset)Mail.Rows[rowIndex].Cells["DateTime"].Value;
                DateTime date = dateTimeOffset.DateTime;
                string body = Mail.Rows[rowIndex].Cells["Body"].Value.ToString();
                this.Hide();
                ReadMail readMail = new ReadMail();
                readMail.DisplayEmail(user.Text, from, subject, date, body,pass.Text);
                readMail.ShowDialog();
                readMail = null;
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void bt_Refresh_Click(object sender, EventArgs e)
        {
            load_dgv(sender, e);
        }

        private void bt_newMail_Click(object sender, EventArgs e)
        {
            this.Hide();
            SendMail sendMail = new SendMail();
            sendMail.DisplayEmail(null, user.Text, null, null, null, pass.Text);
            sendMail.ShowDialog();
            sendMail = null;
            this.Show();
        }

        private void bt_Logout_Click(object sender, EventArgs e)
        {
            try
            {
                if (client.IsConnected)
                {
                    client.Disconnect(true);
                    MessageBox.Show("Logout");
                    Bai4_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Cannot connect to server !!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void tb_pass_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)sender;
            textBox.UseSystemPasswordChar = true;
        }
    }
}

