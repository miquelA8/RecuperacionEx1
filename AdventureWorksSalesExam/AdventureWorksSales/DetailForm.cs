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
    public partial class DetailForm : Form
    {
        private int _id;

        List<SalesOrderDetail> sodDF = new List<SalesOrderDetail>();
        List<SalesOrderHeader> sohDF = new List<SalesOrderHeader>();

        List<SalesOrderHeader> auxSOH = new List<SalesOrderHeader>();
        SalesOrderHeader test;
       


        public DetailForm(SalesOrderHeader obj)
        {
            test = obj;
            InitializeComponent();
            UpdateElement();
        }
        private void UpdateElement()
        {
            listBoxDetail.DataSource = sodDF;
        }
        private void DetailForm_Load(object sender, EventArgs e)
        {
            textBoxCustomer.Text = test.CustomerID.ToString();
            textBoxOrderDate.Text = test.OrderDate.ToString();
            textBoxOrderNumber.Text = test.SalesOrderID.ToString();
            textBoxSubTotal.Text = test.Subtotal.ToString("C2");
            textBoxTax.Text = test.TaxAmt.ToString("C2");
            textBoxShipping.Text = test.Freight.ToString("C2");
            textBoxTotal.Text = test.TotalDue.ToString("C2");

            DataAccess db = new DataAccess();
            sodDF = db.GetOrderDetails(test.SalesOrderID);
            UpdateElement();


        }
    }
}
