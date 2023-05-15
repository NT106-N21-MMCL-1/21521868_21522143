using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label4.Text = "LOADING...";
                string url = textBox1.Text;
                WebRequest request = WebRequest.Create(url);
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream stream = response.GetResponseStream())
                    {
                        using (StreamReader reader = new StreamReader(stream))
                        {
                            string data = reader.ReadToEnd();
                            richTextBox1.Text = data;
                        }
                    }
                }
                label4.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
