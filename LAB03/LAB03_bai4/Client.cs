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

        public IPEndPoint IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 10000);
        public Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        string name = Login.strName;
        Dictionary<string, bool> check = new Dictionary<string, bool>();
        public Client()
        {
            InitializeComponent();
            check.Add(name, true);
            CheckForIllegalCrossThreadCalls = false;
            Connect();
            try
            {
                Data init = new Data();
                init.strName = name; 
                init.cmdCommand = Command.Login;
                init.strMessage = null;

                client.Send(init.Serialize());
            }
            catch { }
        }

        void Connect()
        {
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
            data.strMessage = textBox1.Text;


            if (client != null && textBox1.Text != string.Empty)
                client.Send(data.Serialize());
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
                    


                    switch (data.cmdCommand)
                    {
                        case Command.Login:
                            lstChatters.Items.Add(data.strName);
                            check.Add(data.strName, false);

                            AddMessage("<<<" + data.strName + " da tham gia phong chat>>>");
                            break; ;

                        case Command.Logout:
                            lstChatters.Items.Remove(data.strName);
                            AddMessage("<<<" + data.strName + " da roi phong chat>>>");
                            break;

                        case Command.List:
                            lstChatters.Items.AddRange(data.strName.Split('*'));
                            lstChatters.Items.RemoveAt(lstChatters.Items.Count - 1);
                            for(int i = 0; i<lstChatters.Items.Count; i++)
                            {
                                if (lstChatters.Items[i].ToString() != name)
                                    check.Add(lstChatters.Items[i].ToString(),false);
                            }
                            break;

                        case Command.Message:
                            AddMessage(data.strName + ": " + data.strMessage);
                            break;
                        case Command.Private:
                            {
                                //tabControl1.SelectedIndex = 0;
                                string Name = data.strName.Split('*')[0];
                                if (!check[Name])
                                {
                                    createTab(Name);
                                    check[Name] = true;
                                    MessageBox.Show("Bạn có tin nhắn từ: "+Name);
                                }
                                break;
                            }
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
        private void button1_Click_1(object sender, EventArgs e)
        {
            Send();
            AddMessage("Bạn: " + textBox1.Text);
            textBox1.Clear();
        }

        void createTab(string Name)
        {
            ChatPrivateView chat = new ChatPrivateView(Name,name);
            chat.Dock = DockStyle.Fill;
            TabPage tab = new TabPage(Name);
            tab.Controls.Add(chat);
            tabControl2.TabPages.Add(tab);
            //tabControl1.SelectedIndex = 1;
            //tabControl2.SelectedTab = tab;
        }

        private void lstChatters_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!check[lstChatters.SelectedItem.ToString()])
            {
                createTab(lstChatters.SelectedItem.ToString());
                check[lstChatters.SelectedItem.ToString()] = true;

                Data data = new Data();
                data.strMessage = string.Empty;
                data.cmdCommand = Command.Private;
                data.strName = name + "*" + lstChatters.SelectedItem.ToString();

                byte[] buffer = data.Serialize();
                client.Send(buffer);
            }
        }
    }
}
