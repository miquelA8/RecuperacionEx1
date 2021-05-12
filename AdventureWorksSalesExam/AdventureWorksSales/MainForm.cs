using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureWorksSales
{
    public partial class MainForm : Form
    {
        List<SalesOrderHeader> soh = new List<SalesOrderHeader>();
        List<Customer> customer = new List<Customer>();

        
        public MainForm()
        {
            InitializeComponent();
            UpdateElement();
        }

        private void UpdateElement()
        {
            customersComboBox.DataSource = customer;
            salesListBox.DataSource = soh;
        }

        private void salesListBox_DoubleClick(object sender, EventArgs e)
        {
            SalesOrderHeader id = ((SalesOrderHeader)salesListBox.SelectedItem);
            DataAccess db = new DataAccess();

            Form form = new DetailForm(id);
            form.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            customer = db.GetCustomers();
            UpdateElement();
            
        }

        private void salesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            

        }

        private void customersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            int id = ((Customer)customersComboBox.SelectedItem).CustomerID;
            soh = db.GetOrderHeader(id);
            UpdateElement();
        }
    }
}
