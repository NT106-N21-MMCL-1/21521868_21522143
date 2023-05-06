using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bài1
{
    public partial class UDPClient : Form
    {
        public UDPClient()
        {
            InitializeComponent();
        }
        public void Send(string mess)
        {
            try
            {
            //    ipendp = new IPEndPoint(IPAddress.Parse(textBox1.Text), Int32.Parse(textBox2.Text));
                UdpClient client = new UdpClient();
                client.Connect(IPAddress.Parse(textBox1.Text), Int32.Parse(textBox2.Text));
                Byte[] sendBytes = Encoding.UTF8.GetBytes(mess);
                client.Send(sendBytes, sendBytes.Length);
                client.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Send(textBox3.Text);
            textBox3.Clear();
        }
        private void UDPClient_Load(object sender, EventArgs e)
        {
            //CheckForIllegalCrossThreadCalls = false;
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
