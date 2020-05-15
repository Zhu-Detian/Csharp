namespace Homework8
{
    partial class SubFormOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.orderInfoTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.labelID = new System.Windows.Forms.Label();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.orderButtonTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.submitTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.orderItemsGroupBox = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderInfoTableLayoutPanel.SuspendLayout();
            this.orderButtonTableLayoutPanel.SuspendLayout();
            this.submitTableLayoutPanel.SuspendLayout();
            this.orderItemsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // orderInfoTableLayoutPanel
            // 
            this.orderInfoTableLayoutPanel.ColumnCount = 4;
            this.orderInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.orderInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.orderInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.orderInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.orderInfoTableLayoutPanel.Controls.Add(this.labelID, 0, 0);
            this.orderInfoTableLayoutPanel.Controls.Add(this.labelCustomer, 0, 1);
            this.orderInfoTableLayoutPanel.Controls.Add(this.labelAddress, 2, 1);
            this.orderInfoTableLayoutPanel.Controls.Add(this.labelDate, 0, 2);
            this.orderInfoTableLayoutPanel.Controls.Add(this.txtID, 1, 0);
            this.orderInfoTableLayoutPanel.Controls.Add(this.txtCustomer, 1, 1);
            this.orderInfoTableLayoutPanel.Controls.Add(this.txtAddress, 3, 1);
            this.orderInfoTableLayoutPanel.Controls.Add(this.dateTimePicker, 1, 2);
            this.orderInfoTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.orderInfoTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.orderInfoTableLayoutPanel.Name = "orderInfoTableLayoutPanel";
            this.orderInfoTableLayoutPanel.Padding = new System.Windows.Forms.Padding(3);
            this.orderInfoTableLayoutPanel.RowCount = 3;
            this.orderInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.orderInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.orderInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.orderInfoTableLayoutPanel.Size = new System.Drawing.Size(685, 150);
            this.orderInfoTableLayoutPanel.TabIndex = 0;
            // 
            // labelID
            // 
            this.labelID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(82, 21);
            this.labelID.Margin = new System.Windows.Forms.Padding(5);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(17, 12);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID";
            // 
            // labelCustomer
            // 
            this.labelCustomer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Location = new System.Drawing.Point(46, 69);
            this.labelCustomer.Margin = new System.Windows.Forms.Padding(5);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(53, 12);
            this.labelCustomer.TabIndex = 1;
            this.labelCustomer.Text = "Customer";
            // 
            // labelAddress
            // 
            this.labelAddress.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(390, 69);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(5);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(47, 12);
            this.labelAddress.TabIndex = 2;
            this.labelAddress.Text = "Address";
            // 
            // labelDate
            // 
            this.labelDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(70, 117);
            this.labelDate.Margin = new System.Windows.Forms.Padding(5);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(29, 12);
            this.labelDate.TabIndex = 3;
            this.labelDate.Text = "Date";
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.Location = new System.Drawing.Point(107, 16);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(214, 21);
            this.txtID.TabIndex = 4;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxInt_KeyPress);
            // 
            // txtCustomer
            // 
            this.txtCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomer.Location = new System.Drawing.Point(107, 64);
            this.txtCustomer.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(214, 21);
            this.txtCustomer.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Location = new System.Drawing.Point(445, 64);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(217, 21);
            this.txtAddress.TabIndex = 6;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker.Location = new System.Drawing.Point(107, 112);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(214, 21);
            this.dateTimePicker.TabIndex = 7;
            // 
            // orderButtonTableLayoutPanel
            // 
            this.orderButtonTableLayoutPanel.ColumnCount = 3;
            this.orderButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.orderButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.orderButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.orderButtonTableLayoutPanel.Controls.Add(this.btnAddItem, 0, 0);
            this.orderButtonTableLayoutPanel.Controls.Add(this.submitTableLayoutPanel, 2, 0);
            this.orderButtonTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.orderButtonTableLayoutPanel.Location = new System.Drawing.Point(0, 150);
            this.orderButtonTableLayoutPanel.Name = "orderButtonTableLayoutPanel";
            this.orderButtonTableLayoutPanel.RowCount = 1;
            this.orderButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.orderButtonTableLayoutPanel.Size = new System.Drawing.Size(685, 50);
            this.orderButtonTableLayoutPanel.TabIndex = 1;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddItem.Location = new System.Drawing.Point(76, 13);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddItem.TabIndex = 0;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // submitTableLayoutPanel
            // 
            this.submitTableLayoutPanel.ColumnCount = 2;
            this.submitTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.submitTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.submitTableLayoutPanel.Controls.Add(this.btnSubmit, 1, 0);
            this.submitTableLayoutPanel.Controls.Add(this.btnCancel, 0, 0);
            this.submitTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.submitTableLayoutPanel.Location = new System.Drawing.Point(459, 3);
            this.submitTableLayoutPanel.Name = "submitTableLayoutPanel";
            this.submitTableLayoutPanel.RowCount = 1;
            this.submitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.submitTableLayoutPanel.Size = new System.Drawing.Size(223, 44);
            this.submitTableLayoutPanel.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmit.Location = new System.Drawing.Point(129, 10);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Location = new System.Drawing.Point(18, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // orderItemsGroupBox
            // 
            this.orderItemsGroupBox.Controls.Add(this.dataGridView1);
            this.orderItemsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderItemsGroupBox.Location = new System.Drawing.Point(0, 200);
            this.orderItemsGroupBox.Margin = new System.Windows.Forms.Padding(5);
            this.orderItemsGroupBox.Name = "orderItemsGroupBox";
            this.orderItemsGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.orderItemsGroupBox.Size = new System.Drawing.Size(685, 291);
            this.orderItemsGroupBox.TabIndex = 2;
            this.orderItemsGroupBox.TabStop = false;
            this.orderItemsGroupBox.Text = "Items";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderItemsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(5, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(675, 267);
            this.dataGridView1.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Product";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderItemsBindingSource
            // 
            this.orderItemsBindingSource.DataSource = typeof(Homework8.OrderItem);
            // 
            // SubFormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 491);
            this.Controls.Add(this.orderItemsGroupBox);
            this.Controls.Add(this.orderButtonTableLayoutPanel);
            this.Controls.Add(this.orderInfoTableLayoutPanel);
            this.Name = "SubFormOrder";
            this.Text = "Form2";
            this.orderInfoTableLayoutPanel.ResumeLayout(false);
            this.orderInfoTableLayoutPanel.PerformLayout();
            this.orderButtonTableLayoutPanel.ResumeLayout(false);
            this.submitTableLayoutPanel.ResumeLayout(false);
            this.orderItemsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel orderInfoTableLayoutPanel;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TableLayoutPanel orderButtonTableLayoutPanel;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox orderItemsGroupBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderItemsBindingSource;
        private System.Windows.Forms.TableLayoutPanel submitTableLayoutPanel;
        private System.Windows.Forms.Button btnCancel;
    }
}