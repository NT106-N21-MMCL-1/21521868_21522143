using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace bài3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            richTextBox1.ReadOnly = true;
        }

            IPEndPoint IP;
            Socket client;

            void Connect()
            {
                IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
                client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                try
                {
                    client.Connect(IP);
                    client.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Thread listen = new Thread(Receive);
                listen.IsBackground = true;
                listen.Start();
            }

        void Receive()
            {
                try
                {
                    while (true)
                    {
                        byte[] data = new byte[1024 * 5000];
                        client.Receive(data);

                        string data_tosend = (string)Deserialize(data);
                        Addmessage(data_tosend);
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            void Addmessage(string s)
            {
            richTextBox1.Text = s + '\n';
            }

            object Deserialize(byte[] data)
            {
                MemoryStream Stream = new MemoryStream(data);
                BinaryFormatter Formatter = new BinaryFormatter();

                return Formatter.Deserialize(Stream);

            }
            private void listView1_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

        private void button1_Click(object sender, EventArgs e)
        {
            Connect();
            Receive();
        }
    }
    }
