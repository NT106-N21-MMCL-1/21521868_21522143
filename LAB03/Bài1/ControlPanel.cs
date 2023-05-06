using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài1
{
    public partial class ControlPanel : Form
    {
        public ControlPanel()
        {
            InitializeComponent();
        }

        private void UDPServer_Click(object sender, EventArgs e)
        {
            Thread ServerThread = new Thread(() =>
            {
                UDPServer udpserver = new UDPServer();
                udpserver.ShowDialog();
            });
            ServerThread.Start();
        }

        private void UDPClient_Click(object sender, EventArgs e)
        {
            Thread ClientThread = new Thread(() =>
            {
                UDPClient udpclient = new UDPClient();
                udpclient.ShowDialog();
            });
            ClientThread.Start();
        }

        private void ControlPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
