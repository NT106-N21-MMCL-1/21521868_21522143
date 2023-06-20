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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading;
using System.Diagnostics;
using System.IO;

namespace LAB03
{
    public partial class ChatPrivateView : UserControl
    {
        public IPEndPoint IP;
        public Socket client;
        string name;
        string opponent;

        public ChatPrivateView()
        {
            InitializeComponent();
        }
        public ChatPrivateView(string opp, string Name, string ip)
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            opponent = opp;
            name = Name;

            IP = new IPEndPoint(IPAddress.Parse(ip), 10000);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            Connect();
            try
            {
                Data init = new Data();
                init.strName = name+"*"+opponent;
                init.cmdCommand = Command.InitPrivate;
                init.strMessage = null;

                client.Send(init.Serialize());
            }
            catch { }
        }

        void AddMessage(string s)
        {
            listView2.Items.Add(new ListViewItem() { Text = s });
        }


        void Connect()
        {
            client.Connect(IP);
            Thread listener = new Thread(Receive);
            listener.IsBackground = true;
            listener.Start();
        }

        void close()
        {
            client.Close();
        }

        void Send()
        {
            Data data = new Data();
            data.strName = name+"*"+opponent;
            data.cmdCommand = Command.MessageSecret;
            data.strMessage = textBox2.Text;

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
                        case Command.MessageSecret:
                            {
                                AddMessage(data.strName.Split('*')[0] + ": " + data.strMessage);
                                break;
                            }
                        case Command.File:
                            {
                                string fileName = data.strMessage.Split('*')[0];
                                byte[] dataFile = Convert.FromBase64String(data.strMessage.Split('*')[1]);
                                SaveDataToFile(dataFile, fileName);
                                MessageBox.Show("You got " + fileName + " from " + data.strName.Split('*')[0]);
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

        private void SaveDataToFile(byte[] data, string fileName)
        {
            string file = Path.Combine(Application.StartupPath, fileName);
            File.WriteAllBytes(file, data);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Send();
            AddMessage("Bạn: " + textBox2.Text);
            textBox2.Clear();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
            }
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            string filePath = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|Text files (*.txt)|*.txt";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
            }

            string fileName = Path.GetFileName(filePath);

            byte[] dataFile = File.ReadAllBytes(filePath);

            string base64String = Convert.ToBase64String(dataFile);

            Data data = new Data();
            data.cmdCommand = Command.File;
            data.strName = name + "*" + opponent;
            data.strMessage = fileName + "*" + base64String;

            client.Send(data.Serialize());
        }
    }
}
