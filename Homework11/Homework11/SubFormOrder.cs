using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Homework8;

namespace Homework8
{
    public partial class SubFormOrder : Form
    {
        public string CustomerName { get; set; }
        public string Address { get; set; }
        private Order order;
        public Order NewOrder { get { return order; } }
        private List<OrderItem> items = new List<OrderItem> { };
        public SubFormOrder()
        {
            CustomerName = "";
            Address = "";
            InitializeComponent();
            txtCustomer.DataBindings.Add("Text", this, "CustomerName");
            txtAddress.DataBindings.Add("Text", this, "Address");
            orderItemsBindingSource.DataSource = items;
        }
        public SubFormOrder(string formTitle, string defaultID, string defaultCustomer, string defaultAddress, string defaultDate, List<OrderItem> defaultItems = null)
        {
            CustomerName = "";
            Address = "";
            InitializeComponent();
            txtCustomer.DataBindings.Add("Text", this, "CustomerName");
            txtAddress.DataBindings.Add("Text", this, "Address");

            this.Text = formTitle;
            txtID.Text = defaultID;
            CustomerName = defaultCustomer;
            Address = defaultAddress;
            dateTimePicker.Text = defaultDate;
            if (defaultItems != null) items = defaultItems;
            orderItemsBindingSource.DataSource = items;
            //orderItemsBindingSource.ResetBindings(false);

            if (formTitle == "Edit Order") txtID.ReadOnly = true;
            else txtID.ReadOnly = false;
        }
        private void TextBoxInt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == '\r'))
            {
                e.Handled = true;
            }
            TextBox tb = sender as TextBox;
            if (e.KeyChar == '0' && tb.TextLength == 0)
            {
                e.Handled = true;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            StringBuilder error = new StringBuilder();
            bool isError = false;
            
            if (txtID.Text == "")
            {
                isError = true;
                error.Append("订单号不能为空\n");
            }
            if (CustomerName == "")
            {
                isError = true;
                error.Append("客户姓名不能为空\n");
            }
            if (Address == "")
            {
                isError = true;
                error.Append("客户地址不能为空\n");
            }
            if (items.Count == 0)
            {
                isError = true;
                error.Append("请添加商品\n");
            }
            if (isError)
            {
                MessageBox.Show(error.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int ID = Convert.ToInt32(txtID.Text);
            Customer customer = new Customer(CustomerName, Address);
            DateTime Date = Convert.ToDateTime(dateTimePicker.Text);
            order = new Order(ID, customer, Date, items);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            SubFormItem subFormAddItem = new SubFormItem();
            DialogResult result = subFormAddItem.ShowDialog();
            if (result == DialogResult.OK)
            {
                items.Add(subFormAddItem.item);
                orderItemsBindingSource.ResetBindings(false);
            }
        }
    }
}
