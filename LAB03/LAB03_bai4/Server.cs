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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;

namespace LAB03
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            if (!Lab03.isExistServer)
            {
                Lab03.isExistServer = true;
                Connect();
                this.Show();
            }

            else
                MessageBox.Show("Server đã được tạo", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        IPEndPoint IP;
        Socket server;
        List<Socket> clientList;
        List<string> clients = new List<string>();
        Dictionary<string, Socket> clientInfo = new Dictionary<string, Socket>();

        void Connect()
        {
            clientList = new List<Socket>();

            IP = new IPEndPoint(IPAddress.Any, 10000);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            server.Bind(IP);


            Thread listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        server.Listen(100);
                        Socket client = server.Accept();
                        clientList.Add(client);

                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);
                    }
                }
                catch
                {
                    IP = new IPEndPoint(IPAddress.Any, 10000);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                }
            });

            listen.IsBackground = true;
            listen.Start();
        }

        void close()
        {
            server.Close();
        }

        void Receive(Object obj)
        {
            Socket client = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] buffer = new byte[1024 * 5000];
                    client.Receive(buffer);

                    

                    Data data = new Data(buffer);

                    //MessageBox.Show($"Received data: {data.Serialize().Length}");

                    switch (data.cmdCommand)
                    {
                        case Command.Message:
                            AddMessage(data.strName + ": " + data.strMessage);
                            foreach (Socket item in clientList)
                            {
                                if (item != null && item != client)
                                    item.Send(data.Serialize());
                            }
                            break;
                        case Command.Login:
                            {
                                AddMessage("<<<" + data.strName + " da tham gia phong chat>>>");

                                clients.Add(data.strName);
                                clientInfo.Add(data.strName, client);
                                lstChatters.Items.Add(data. strName);

                                string listName = "";
                                foreach(var name in clients)
                                {
                                    listName += name + "*";
                                }

                                Data temp = new Data();
                                temp.strName = listName;
                                temp.strMessage = null;
                                temp.cmdCommand = Command.List;

                                client.Send(temp.Serialize());

                                foreach (Socket item in clientList)
                                {
                                    if (item != null && item != client)
                                        item.Send(data.Serialize());
                                }

                                break;
                            }
                        case Command.Logout:
                            AddMessage("<<<" + data.strName + " da roi phong chat>>>");

                            clients.Remove(data.strName);
                            clientInfo.Remove(data.strName);
                            lstChatters.Items.Remove(data.strName);

                            foreach (Socket item in clientList)
                            {
                                if (item != null && item != client)
                                    item.Send(data.Serialize());
                            }
                            break;
                        case Command.Private:
                            {
                                Data tempData = new Data();
                                tempData.strName = data.strName;
                                tempData.strMessage = data.strMessage;
                                tempData.cmdCommand = Command.Private;

                                string opponent = data.strName.Split('*')[1];

                                clientInfo[opponent].Send(tempData.Serialize());
                                break;
                            }
                        case Command.InitPrivate:
                            {
                                clientInfo.Add(data.strName, client);

                                break;
                            }
                        case Command.MessageSecret:
                            {
                                Data tempData = new Data();
                                tempData.strName = data.strName;
                                tempData.strMessage = data.strMessage;
                                tempData.cmdCommand = Command.MessageSecret;

                                string _name = data.strName.Split('*')[0];
                                string _opponent = data.strName.Split('*')[1];
                                string key = _opponent + "*" + _name;

                                clientInfo[key].Send(tempData.Serialize());
                                break;
                            }
                        case Command.File:
                            {
                                Data tempData = new Data();
                                tempData.strName = data.strName;
                                tempData.strMessage = data.strMessage;
                                tempData.cmdCommand = Command.File;

                                string _name = data.strName.Split('*')[0];
                                string _opponent = data.strName.Split('*')[1];
                                string key = _opponent + "*" + _name;

                                clientInfo[key].Send(tempData.Serialize());
                                break;
                            }
                    }
                }
            }
            catch
            {
                clientList.Remove(client);
                client.Close();
            }

        }

        void AddMessage(string s)
        {
            listView1.Items.Add(new ListViewItem() { Text = s });
        }

        private void Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            Lab03.isExistServer = false;
           close();
        }
    }
}
