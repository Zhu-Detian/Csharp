namespace Homework8
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.ordersGroupBox = new System.Windows.Forms.GroupBox();
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.detailsGroupBox = new System.Windows.Forms.GroupBox();
            this.detailsDataGridView = new System.Windows.Forms.DataGridView();
            this.goodsnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersDataTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.flowLayoutPanel1.SuspendLayout();
            this.ordersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            this.detailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailsDataGridView)).BeginInit();
            this.ordersDataTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAddOrder);
            this.flowLayoutPanel1.Controls.Add(this.btnDelete);
            this.flowLayoutPanel1.Controls.Add(this.btnEdit);
            this.flowLayoutPanel1.Controls.Add(this.btnSort);
            this.flowLayoutPanel1.Controls.Add(this.btnQuery);
            this.flowLayoutPanel1.Controls.Add(this.btnImport);
            this.flowLayoutPanel1.Controls.Add(this.btnExport);
            this.flowLayoutPanel1.Controls.Add(this.btnExit);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(692, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(101, 586);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddOrder.Location = new System.Drawing.Point(13, 13);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(75, 23);
            this.btnAddOrder.TabIndex = 0;
            this.btnAddOrder.Text = "Add";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.Location = new System.Drawing.Point(13, 42);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.Location = new System.Drawing.Point(13, 71);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQuery.Location = new System.Drawing.Point(13, 129);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 3;
            this.btnQuery.Text = "Query";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // ordersGroupBox
            // 
            this.ordersGroupBox.Controls.Add(this.ordersDataGridView);
            this.ordersGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersGroupBox.Location = new System.Drawing.Point(3, 3);
            this.ordersGroupBox.Name = "ordersGroupBox";
            this.ordersGroupBox.Padding = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.ordersGroupBox.Size = new System.Drawing.Size(686, 287);
            this.ordersGroupBox.TabIndex = 4;
            this.ordersGroupBox.TabStop = false;
            this.ordersGroupBox.Text = "Orders";
            // 
            // ordersDataGridView
            // 
            this.ordersDataGridView.AllowUserToAddRows = false;
            this.ordersDataGridView.AllowUserToDeleteRows = false;
            this.ordersDataGridView.AutoGenerateColumns = false;
            this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.orderTimeDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn});
            this.ordersDataGridView.DataSource = this.orderBindingSource;
            this.ordersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersDataGridView.Location = new System.Drawing.Point(10, 17);
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.RowTemplate.Height = 23;
            this.ordersDataGridView.Size = new System.Drawing.Size(666, 260);
            this.ordersDataGridView.TabIndex = 0;
            this.ordersDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordersDataGridView_CellClick);
            // 
            // detailsGroupBox
            // 
            this.detailsGroupBox.Controls.Add(this.detailsDataGridView);
            this.detailsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsGroupBox.Location = new System.Drawing.Point(3, 296);
            this.detailsGroupBox.Name = "detailsGroupBox";
            this.detailsGroupBox.Padding = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.detailsGroupBox.Size = new System.Drawing.Size(686, 287);
            this.detailsGroupBox.TabIndex = 5;
            this.detailsGroupBox.TabStop = false;
            this.detailsGroupBox.Text = "Details";
            // 
            // detailsDataGridView
            // 
            this.detailsDataGridView.AllowUserToAddRows = false;
            this.detailsDataGridView.AllowUserToDeleteRows = false;
            this.detailsDataGridView.AutoGenerateColumns = false;
            this.detailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goodsnameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn1});
            this.detailsDataGridView.DataSource = this.detailBindingSource;
            this.detailsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsDataGridView.Location = new System.Drawing.Point(10, 17);
            this.detailsDataGridView.Name = "detailsDataGridView";
            this.detailsDataGridView.RowTemplate.Height = 23;
            this.detailsDataGridView.Size = new System.Drawing.Size(666, 260);
            this.detailsDataGridView.TabIndex = 0;
            // 
            // goodsnameDataGridViewTextBoxColumn
            // 
            this.goodsnameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.goodsnameDataGridViewTextBoxColumn.HeaderText = "Product";
            this.goodsnameDataGridViewTextBoxColumn.Name = "goodsnameDataGridViewTextBoxColumn";
            this.goodsnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Goods";
            this.dataGridViewTextBoxColumn1.HeaderText = "Commodity";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Goods";
            this.dataGridViewTextBoxColumn2.HeaderText = "Commodity";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // ordersDataTableLayoutPanel
            // 
            this.ordersDataTableLayoutPanel.ColumnCount = 1;
            this.ordersDataTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ordersDataTableLayoutPanel.Controls.Add(this.detailsGroupBox, 0, 1);
            this.ordersDataTableLayoutPanel.Controls.Add(this.ordersGroupBox, 0, 0);
            this.ordersDataTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersDataTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.ordersDataTableLayoutPanel.Name = "ordersDataTableLayoutPanel";
            this.ordersDataTableLayoutPanel.RowCount = 2;
            this.ordersDataTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ordersDataTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ordersDataTableLayoutPanel.Size = new System.Drawing.Size(692, 586);
            this.ordersDataTableLayoutPanel.TabIndex = 6;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(13, 158);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 4;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(13, 187);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(13, 216);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExt_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(13, 100);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 7;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalPriceDataGridViewTextBoxColumn1
            // 
            this.totalPriceDataGridViewTextBoxColumn1.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn1.HeaderText = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn1.Name = "totalPriceDataGridViewTextBoxColumn1";
            this.totalPriceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // detailBindingSource
            // 
            this.detailBindingSource.DataSource = typeof(Homework6.OrderItem);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Width = 200;
            // 
            // orderTimeDataGridViewTextBoxColumn
            // 
            this.orderTimeDataGridViewTextBoxColumn.DataPropertyName = "OrderTime";
            this.orderTimeDataGridViewTextBoxColumn.HeaderText = "OrderTime";
            this.orderTimeDataGridViewTextBoxColumn.Name = "orderTimeDataGridViewTextBoxColumn";
            this.orderTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(Homework6.Order);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "xml";
            this.openFileDialog.FileName = "orders";
            this.openFileDialog.Filter = "XML文件|*.xml";
            this.openFileDialog.Title = "Import";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "xml";
            this.saveFileDialog.FileName = "orders";
            this.saveFileDialog.Filter = "XML文件|*.xml";
            this.saveFileDialog.Title = "Export";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 586);
            this.Controls.Add(this.ordersDataTableLayoutPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "OrderService";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ordersGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            this.detailsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.detailsDataGridView)).EndInit();
            this.ordersDataTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.detailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.GroupBox ordersGroupBox;
        private System.Windows.Forms.GroupBox detailsGroupBox;
        private System.Windows.Forms.BindingSource detailBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView ordersDataGridView;
        private System.Windows.Forms.DataGridView detailsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TableLayoutPanel ordersDataTableLayoutPanel;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

