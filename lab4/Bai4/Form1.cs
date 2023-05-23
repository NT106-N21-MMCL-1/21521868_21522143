using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static System.Net.WebRequestMethods;

namespace Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public async void GetdataFromAPI_and_showitonForm()
        {
            try 
            {
                string apiurl = $"https://reqres.in/api/users?page=1";
                    using(HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(apiurl);
                    if(response.IsSuccessStatusCode)
                    {
                        string jsonContent = await response.Content.ReadAsStringAsync();
                        
                        JObject data = JObject.Parse(jsonContent);
                        //listView1.Items.Add(data.ToString());
                        richTextBox1.Text = data.ToString();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GetdataFromAPI_and_showitonForm();
        }
    }
}
