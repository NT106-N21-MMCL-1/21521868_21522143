using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void ProcessRequest_download_stream()
        {
            try
            {
                string url = textBox1.Text;
                WebRequest request = WebRequest.Create(url);
                using (WebClient client = new WebClient())
                {
                    label5.Text = "Loading...";
                    using (WebResponse response = request.GetResponse())
                    {
                        client.DownloadFile(url, textBox2.Text);
                        MessageBox.Show("Thành công download file HTML về custom URL.");

                        
                        using (Stream stream = response.GetResponseStream())
                        {
                            using (StreamReader reader = new StreamReader(stream))
                            { 
                                string data = reader.ReadToEnd();
                                richTextBox1.Text = data;                           
                            }
                        }
                        
                    }
                    label5.Text = "";
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            ProcessRequest_download_stream();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
