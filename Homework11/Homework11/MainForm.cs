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
    public partial class MainForm : Form
    {
        private OrderService os = new OrderService();
        private List<Order> selectedOrders = new List<Order> { };
        public MainForm()
        {
            InitializeComponent();
            os.orders = DBManager.LoadData();
            orderBindingSource.DataSource = os.orders;
        }
        
        private void Alert(string message)
        {
            MessageBox.Show(message, "失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void RefreshDataGridViews()
        {
            orderBindingSource.ResetBindings(false);
            Order current = orderBindingSource.Current as Order;
            if (current != null)
            {
                detailBindingSource.DataSource = current.orderItems;
                detailBindingSource.ResetBindings(false);
            }
        }

        private void ordersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Order current = orderBindingSource.Current as Order;
            detailBindingSource.DataSource = current.orderItems;
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            SubFormOrder subFormAdd = new SubFormOrder("Add Order", "", "", "", DateTime.Now.ToString());
            DialogResult result = subFormAdd.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    os.AppendOrder(subFormAdd.NewOrder);
                    RefreshDataGridViews();
                }
                catch (OrderException exception)
                {
                    Alert(exception.Message);
                }
            }
        }

        private void btnExt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Order current = orderBindingSource.Current as Order;
            if (current == null) return;
            try
            {
                os.Delete(current.ID);
                RefreshDataGridViews();
            }
            catch (OrderException exception)
            {
                Alert(exception.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Order current = orderBindingSource.Current as Order;
            if (current == null) return;
            SubFormOrder subFormEdit = new SubFormOrder("Edit Order", current.ID.ToString(), current.User.Name, current.User.Address, current.OrderTime.ToString(), current.orderItems);
            DialogResult result = subFormEdit.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    os.Modify(subFormEdit.NewOrder);
                    RefreshDataGridViews();
                }
                catch (OrderException exception)
                {
                    Alert(exception.Message);
                }
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            os.Sort();
            RefreshDataGridViews();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            QueryForm queryForm = new QueryForm();
            DialogResult result = queryForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (queryForm.Condition == "" || queryForm.Condition == null)
                {
                    orderBindingSource.DataSource = os.orders;
                } else
                {
                    string condition = queryForm.Condition;
                    switch (queryForm.SelectedType)
                    {
                        case 0:
                            {
                                selectedOrders.Clear();
                                Order ret = DBManager.InquireByID(Convert.ToInt32(condition));
                                if (ret != null) selectedOrders.Add(ret);
                                break;
                            }
                        case 1:
                            {
                                List<Order> retList = DBManager.InquireByCustomer(condition);
                                if (retList == null) selectedOrders.Clear();
                                else selectedOrders = retList;
                                break;
                            }
                        case 2:
                            {
                                List<Order> retList = DBManager.InquireByCommodity(condition);
                                if (retList == null) selectedOrders.Clear();
                                else selectedOrders = retList;
                                break;
                            }
                    }
                    orderBindingSource.DataSource = selectedOrders;
                }
                RefreshDataGridViews();
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                os.Import(openFileDialog.FileName);
                orderBindingSource.DataSource = os.orders;
                RefreshDataGridViews();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                os.Export(saveFileDialog.FileName);
            }
        }
    }
}
