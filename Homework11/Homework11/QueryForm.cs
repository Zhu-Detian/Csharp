using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework8
{
    public partial class QueryForm : Form
    {
        string[] QueryTypes = { "By ID", "By Customer", "By Product" };
        public int SelectedType { get; set; }
        public string Condition { get; set; }
        public QueryForm()
        {
            InitializeComponent();
            queryComboBox.DataSource = QueryTypes;
            queryComboBox.DataBindings.Add("SelectedIndex", this, "SelectedType");
            txtQuery.DataBindings.Add("Text", this, "Condition");
            queryComboBox.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            StringBuilder error = new StringBuilder();
            bool isError = false;
            if (queryComboBox.SelectedIndex == 0 && txtQuery.TextLength > 0)
            {
                int result;
                if (!int.TryParse(txtQuery.Text, out result))
                {
                    isError = true;
                    error.Append("查询条件非法");
                }
            }
            if (isError)
            {
                MessageBox.Show(error.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
