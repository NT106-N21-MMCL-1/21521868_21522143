using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB03
{
    public partial class Login : Form
    {

        public static string strName { get; set; }

        public static string strIP { get; set; }
        public Login()
        {
            InitializeComponent();
            this.Show();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            strName = txtName.Text;
            strIP = textBox1.Text;

            Client client = new Client(strName, strIP);
            client.Text = strName;
            this.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty)
                buttonOK.Enabled = false;
            else 
                buttonOK.Enabled = true;
        }
    }
}
