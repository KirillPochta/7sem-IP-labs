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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void  button1_Click(object sender, EventArgs e)
        {
            string X = textBox1.Text;
            string Y = textBox2.Text;

            HttpClient client = new HttpClient();
            HttpRequestMessage requestMessage = new HttpRequestMessage();
            requestMessage.Method = HttpMethod.Post;
            FormUrlEncodedContent form = new FormUrlEncodedContent(new Dictionary<string, string> { { "X", X }, { "Y", Y } });
            requestMessage.Content = form;
            //requestMessage.RequestUri = new Uri("https://localhost:44379//PKA4");
            requestMessage.RequestUri = new Uri("http://172.16.193.234:11212//PKA4");

            HttpResponseMessage response =  await client.SendAsync(requestMessage);
            textBox3.Text = response.Content.ReadAsStringAsync().Result;
            
             
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = default(string);
            textBox2.Text = default(string);
            textBox3.Text = default(string);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
