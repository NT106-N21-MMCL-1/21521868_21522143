using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
}
/*
 * namespace Server
{
    public partial class Form1_server : Form
    {
        public Form1_server()
        {
            
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        IPEndPoint IP;
        Socket server;
        List<Socket> ClientList;


        void Connect()
        {
            ClientList = new List<Socket>();
            IP = new IPEndPoint(IPAddress.Any, 9999);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            
            

            server.Bind(IP);

            Thread Listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        server.Listen(100);
                        Socket client = server.Accept();
                        ClientList.Add(client);

                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);
                    }
                }catch {
                    IP = new IPEndPoint(IPAddress.Any, 9999);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }

                
                

            } );
            Listen.IsBackground = true;
            Listen.Start();

        }

        void close()
        {
            server.Close();
        }
        void Send(Socket client)
        {
            
            if (textBox_in.Text != string.Empty)
                client.Send(Serialize(textBox_in.Text));

        }

        void Receive(object obj )
        {

            Socket client = obj as Socket;
            try
            {   while(true) {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    string data_tosend = (string)Deserialize(data);
                    Addmessage(data_tosend);
                }
                
            }
            catch
            {
                ClientList.Remove(client);
                client.Close();
            }
        }

        void Addmessage(string s)
        {
            listView1.Items.Add(new ListViewItem() { Text = s });
            textBox_in.Clear();
        }
        byte[] Serialize(object obj)
        {
            MemoryStream Stream = new MemoryStream();
            BinaryFormatter Formatter = new BinaryFormatter();

            Formatter.Serialize(Stream, obj);
            return Stream.ToArray();
        }

        object Deserialize(byte[] data)
        {
            MemoryStream Stream = new MemoryStream(data);
            BinaryFormatter Formatter = new BinaryFormatter();

            return Formatter.Deserialize(Stream);

        }

        private void textBox_in_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_send_Click(object sender, EventArgs e)
        {
            foreach(Socket item in ClientList)
            {
                Send( item);
            }
            Addmessage(textBox_in.Text);
            
                
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;

            Connect();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            }
            catch
            {
                MessageBox.Show("Khong the ket noi","loi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            //hi
            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }

        void close()
        {
            client.Close();
        }
        void Send()
        {
            if (textBox_in.Text != string.Empty)
                client.Send(Serialize(textBox_in.Text));
        
        }

        void Receive()
        {
            try
            {
                while (true) {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    string data_tosend = (string)Deserialize(data);
                    Addmessage(data_tosend);
                }
                
            }
            catch
            {
                MessageBox.Show("Không thể kết nối!","loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        void Addmessage(string s)
        {
            listView1.Items.Add(new ListViewItem() { Text = s });
            textBox_in.Clear();
               
        }
        byte[] Serialize(object obj)
        {
            MemoryStream Stream = new MemoryStream();
            BinaryFormatter Formatter = new BinaryFormatter();

            Formatter.Serialize(Stream, obj);
            return Stream.ToArray();
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

        private void Button_send_Click(object sender, EventArgs e)
        {
            Send();
            Addmessage(textBox_in.Text);
        }
    }
}

*/

//below is another different owner of the exercise

/*
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

namespace LAB3
{
    public partial class Task3Form : Form
    {
        TCPServerForm server = new TCPServerForm();
        TCPClientForm client = new TCPClientForm();
        Thread serverThread;
        Thread clientThread;

        public Task3Form()
        {
            InitializeComponent();
        }

        private void openServer()
        {
            try
            {
                server.ShowDialog();
            } 
            catch
            {
                MessageBox.Show("Server is already open!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openClient()
        {
            try
            {
                client.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Client is already open!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOpenServer_Click(object sender, EventArgs e)
        {
            if (!server.IsDisposed)
            {
                serverThread = new Thread(new ThreadStart(openServer));
                serverThread.Start();
            }
        }

        private void btnOpenClient_Click(object sender, EventArgs e)
        {
            if (!client.IsDisposed)
            {
                clientThread = new Thread(new ThreadStart(openClient));
                clientThread.Start();
            }
        }
    }
}
*/
