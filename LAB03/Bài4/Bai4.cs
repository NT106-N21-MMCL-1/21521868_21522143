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
    public partial class Bai4_lab03 : Form
    {
        public static bool isExistServer = false;
        public Bai4_lab03()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Server server = new Server();
        }
    }
}
