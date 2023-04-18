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
using System.Xml.Linq;
using LAB03;
using System.Threading;

namespace LAB03
{
    public partial class Client : Form
    {

        IPEndPoint IP;
        Socket client;

        string name = Login.strName;
        public Client()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();
            try
            {
                Data init = new Data();
                init.strName = name; 
                init.cmdCommand = Command.Login;
                init.strMessage = null;

                //MessageBox.Show(Convert.ToString(init.cmdCommand));

                client.Send(init.Serialize());
            }
            catch { }
        }

        void Connect()
        {
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 10000);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                client.Connect(IP);
                Thread listener = new Thread(Receive);
                listener.IsBackground = true;
                listener.Start();
                this.Show();
            }
            catch
            {
                MessageBox.Show("Không thể kết nối đến server!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }      
        }

        void close()
        {
            client.Close();
        }

        void Send()
        {
            Data data = new Data();
            data.strName = name;
            data.cmdCommand = Command.Message;
            data.strMessage = textBox2.Text;


            if (client != null && textBox2.Text != string.Empty)
                client.Send(data.Serialize());
            //MessageBox.Show($"Send data: {data.Serialize().Length}");
        }

        void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] buffer = new byte[1024 * 5000];
                    client.Receive(buffer);

                    Data data = new Data(buffer);
                    

                    string message = data.strMessage;


                    switch (data.cmdCommand)
                    {
                        case Command.Login:
                            lstChatters.Items.Add(data.strName);
                            AddMessage("<<<" + data.strName + " da tham gia phong chat>>>");
                            break; ;

                        case Command.Logout:
                            lstChatters.Items.Remove(data.strName);
                            AddMessage("<<<" + data.strName + " da roi phong chat>>>");
                            break;

                        case Command.List:
                            lstChatters.Items.AddRange(data.strName.Split('*'));
                            lstChatters.Items.RemoveAt(lstChatters.Items.Count - 1);
                            break;

                        case Command.Message:
                            AddMessage(data.strName + ": " + data.strMessage);
                            break;
                    }
                }
            }
            catch
            {
                client.Close();
            }

        }

        void AddMessage(string s)
        {
            listView1.Items.Add(new ListViewItem() { Text = s });
        }

        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Send();
            AddMessage("Bạn: " + textBox2.Text);
            textBox2.Clear();
        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to leave the chat room?", "Client: " + name,
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }

            try
            {
                //Send a message to logout of the server
                Data msgToSend = new Data();
                msgToSend.cmdCommand = Command.Logout;
                msgToSend.strName = name;
                msgToSend.strMessage = null;

                byte[] buffer = msgToSend.Serialize();
                client.Send(buffer);
                client.Close();
            }
            catch (ObjectDisposedException)
            { }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Client: " + name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
            }
        }
    }
}
