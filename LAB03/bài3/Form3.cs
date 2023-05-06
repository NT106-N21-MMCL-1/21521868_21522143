using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace bài3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }
        IPEndPoint IP;
        Socket client;

        public void Connect()
        {
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            try
            {
                client.Connect(IP);
                MessageBox.Show("Connected successfully!");
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Send()
        {
            if (textBox_in.Text != string.Empty)
                client.Send(Serialize(textBox_in.Text));

        }
        public void Addmessage(string s)
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

        private void Button_send_Click(object sender, EventArgs e)
        {
            Send();
            Addmessage(textBox_in.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            client.Close();
            MessageBox.Show("Disconnected successfully!");
        }
    }
}

       
