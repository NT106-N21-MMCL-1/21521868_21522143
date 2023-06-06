using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Xml.Linq;

namespace Bai4
{
    public partial class ReadMail : Form
    {
        public ReadMail()
        {
            InitializeComponent();
        }
        string pass_m = null;
        public void DisplayEmail(string to,string from, string subject, DateTime date,string body,string pass)
        {
            SendTo.Text = to;
            rcvFrom.Text = from;
            Subject.Text = subject;
            dateTime.Text = date.ToString();
            this.body.Text = body;
            pass_m = pass;
        }

        private void bt_Forward_Click(object sender, EventArgs e)
        {
            this.Hide();
            SendMail sendMail = new SendMail();
            sendMail.DisplayEmail( string.Empty, SendTo.Text, "Foward " +Subject.Text, dateTime.Text, body.Text,pass_m);
            sendMail.ShowDialog();
            sendMail = null;
            this.Show();
        }

        private void bt_Reply_Click(object sender, EventArgs e)
        {
            this.Hide();
            SendMail sendMail = new SendMail();
            sendMail.DisplayEmail(rcvFrom.Text,SendTo.Text, "Reply " + Subject.Text, dateTime.Text,string.Empty, pass_m);
            sendMail.ShowDialog();
            sendMail = null;
            this.Show();
        }
    }
}
