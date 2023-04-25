using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài1
{
    public partial class ControlPanel : Form
    {
        public ControlPanel()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            
        }

        private void UDPServer_Click(object sender, EventArgs e)
        {
            UDPServer udpserver = new UDPServer();
            udpserver.Show();
        }

        private void UDPClient_Click(object sender, EventArgs e)
        {
            UDPClient udpclient = new UDPClient();
            udpclient.Show();
        }

        private void ControlPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
