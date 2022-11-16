using System;
using System.Windows.Forms;
using WindowsFormsApp1.ServiceReference1;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        PhoneClient  client;
        private int? currentId;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new PhoneClient();
            dataGridViewPhone.DataSource = client.GetPhones();
            textBoxNameAdd.Text = "";
            textBoxNumberAdd.Text = "";
            textBoxNameUpd.Text = "";
            textBoxNumberUpd.Text = "";


        }

        private void dataGridViewPhone_SelectionChanged(object sender, EventArgs e)
        {
            textBoxNameAdd.Text = "";
            textBoxNumberAdd.Text = "";
            textBoxNameUpd.Text = "";
            textBoxNumberUpd.Text = "";
            var currentRow = dataGridViewPhone.Rows[dataGridViewPhone.CurrentCell.RowIndex];
            Phone phone = (Phone)currentRow.DataBoundItem;
            textBoxNameUpd.Text = phone.Name;
            textBoxNumberUpd.Text = phone.Number.ToString();
            currentId = phone.Id;
        }

        private void deletePhone(object sender, EventArgs e)
        {
            client.DeletePhone((int)currentId);
            dataGridViewPhone.DataSource = client.GetPhones();
            currentId = null;
        }

        private void updatePhone(object sender, EventArgs e)
        {
            Phone phone = new Phone();
            phone.Id = (int)currentId;
            phone.Name = textBoxNameUpd.Text;
            phone.Number = Convert.ToInt32(textBoxNumberUpd.Text);
            client.UpdatePhone(phone);
            dataGridViewPhone.DataSource = client.GetPhones();
            dataGridViewPhone.ClearSelection();
            currentId = null;
        }

        private void addPhone(object sender, EventArgs e)
        {
            Phone phone = new Phone();
            phone.Id = (int)currentId;
            phone.Name = textBoxNameAdd.Text;
            phone.Number = Convert.ToInt32(textBoxNumberAdd.Text);
            client.AddPhone(phone);
            dataGridViewPhone.DataSource = client.GetPhones();
            currentId = null;
        }
    }
}
