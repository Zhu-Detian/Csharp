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
    public partial class SubFormItem : Form
    {
        public string Product { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public OrderItem item = new OrderItem();
        public SubFormItem()
        {
            Product = "";
            InitializeComponent();
            txtProduct.DataBindings.Add("Text", this, "Product");
            txtPrice.DataBindings.Add("Text", this, "Price");
            txtQuantity.DataBindings.Add("Text", this, "Quantity");
        }

        private void TextBoxFloat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
            TextBox tb = sender as TextBox;
            if (e.KeyChar == '.' && (tb.Text.Contains('.') || tb.TextLength == 0))
            {
                e.Handled = true;
            }
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            StringBuilder error = new StringBuilder();
            bool isError = false;
            if (Product.Length == 0)
            {
                isError = true;
                error.Append("商品名不能为空\n");
            }
            if (Quantity == 0)
            {
                isError = true;
                error.Append("商品数量不能为0\n");
            }
            if (isError)
            {
                MessageBox.Show(error.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Commodity goods = new Commodity(Product, Price);
            this.item = new OrderItem(goods, Quantity);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
