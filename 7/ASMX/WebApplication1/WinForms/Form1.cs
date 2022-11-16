using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceReference1;

namespace WinForms
{
    public partial class Form1 : Form
    {
        WebServicePhoneBookSoapClient client;
        public Form1()
        {
            client = new WebServicePhoneBookSoapClient(");

            InitializeComponent();
        }
   
    
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridPhones.DataSource = client.GetDictAsync();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
