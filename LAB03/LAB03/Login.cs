﻿using System;
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
        public Login()
        {
            InitializeComponent();
            this.Show();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            strName = txtName.Text;

            Client client = new Client();
            this.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text == "")
                buttonOK.Enabled = false;
        }
    }
}
