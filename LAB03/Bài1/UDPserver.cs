using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài1
{
    public partial class UDPServer : Form
    {
       
        public UDPServer()
        {
            InitializeComponent();
            textBox2.ReadOnly = true;
        }
        private void UDPServer_Load(object sender, EventArgs e)
        {
        }
        public void serverThread_receive()
        {
            try
            {
                UdpClient client = new UdpClient(Int32.Parse(textBox1.Text));

                Task.Run(() =>
                {
                    while (true)
                    {
                        IPEndPoint remoteEndPoint = new IPEndPoint(IPAddress.Any, 0);
                        Byte[] receiveBytes = client.Receive(ref remoteEndPoint);
                        string returnData = Encoding.UTF8.GetString(receiveBytes);
                        string mess = remoteEndPoint.Address.ToString() + ":" + returnData.ToString() + '\n';
                        if (InvokeRequired)
                            Invoke(new Action(() => AddMessage(mess)));
                        else
                            AddMessage(mess);
                    }
                    client.Close();
                });
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void AddMessage(string mess)
        {
            textBox2.Text += mess;
        }
        
        private void button2_Click(object sender, EventArgs e)//listen
        {
           serverThread_receive();
        }   
    }
}
