namespace Homework8
{
    partial class SubFormItem
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
            this.addItemTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.buttonTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.addItemTableLayoutPanel.SuspendLayout();
            this.buttonTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addItemTableLayoutPanel
            // 
            this.addItemTableLayoutPanel.ColumnCount = 2;
            this.addItemTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.addItemTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.addItemTableLayoutPanel.Controls.Add(this.lblProductName, 0, 0);
            this.addItemTableLayoutPanel.Controls.Add(this.lblPrice, 0, 1);
            this.addItemTableLayoutPanel.Controls.Add(this.lblQuantity, 0, 2);
            this.addItemTableLayoutPanel.Controls.Add(this.txtProduct, 1, 0);
            this.addItemTableLayoutPanel.Controls.Add(this.txtPrice, 1, 1);
            this.addItemTableLayoutPanel.Controls.Add(this.txtQuantity, 1, 2);
            this.addItemTableLayoutPanel.Controls.Add(this.buttonTableLayoutPanel, 1, 3);
            this.addItemTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addItemTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.addItemTableLayoutPanel.Name = "addItemTableLayoutPanel";
            this.addItemTableLayoutPanel.RowCount = 4;
            this.addItemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.addItemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.addItemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.addItemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.addItemTableLayoutPanel.Size = new System.Drawing.Size(258, 204);
            this.addItemTableLayoutPanel.TabIndex = 0;
            // 
            // lblProductName
            // 
            this.lblProductName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(25, 19);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(5);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(47, 12);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Product";
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(37, 70);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(5);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(35, 12);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Price";
            // 
            // lblQuantity
            // 
            this.lblQuantity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(19, 121);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(5);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(53, 12);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtProduct
            // 
            this.txtProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProduct.Location = new System.Drawing.Point(80, 15);
            this.txtProduct.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(158, 21);
            this.txtProduct.TabIndex = 3;
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrice.Location = new System.Drawing.Point(80, 66);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(158, 21);
            this.txtPrice.TabIndex = 4;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxFloat_KeyPress);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantity.Location = new System.Drawing.Point(80, 117);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(158, 21);
            this.txtQuantity.TabIndex = 5;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxInt_KeyPress);
            // 
            // buttonTableLayoutPanel
            // 
            this.buttonTableLayoutPanel.ColumnCount = 2;
            this.buttonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonTableLayoutPanel.Controls.Add(this.btnCancel, 0, 0);
            this.buttonTableLayoutPanel.Controls.Add(this.btnOK, 1, 0);
            this.buttonTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonTableLayoutPanel.Location = new System.Drawing.Point(80, 156);
            this.buttonTableLayoutPanel.Name = "buttonTableLayoutPanel";
            this.buttonTableLayoutPanel.RowCount = 1;
            this.buttonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonTableLayoutPanel.Size = new System.Drawing.Size(175, 45);
            this.buttonTableLayoutPanel.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Location = new System.Drawing.Point(6, 11);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOK.Location = new System.Drawing.Point(93, 11);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // SubFormItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(258, 204);
            this.Controls.Add(this.addItemTableLayoutPanel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(274, 243);
            this.MinimumSize = new System.Drawing.Size(274, 243);
            this.Name = "SubFormItem";
            this.Text = "Add Item";
            this.addItemTableLayoutPanel.ResumeLayout(false);
            this.addItemTableLayoutPanel.PerformLayout();
            this.buttonTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel addItemTableLayoutPanel;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TableLayoutPanel buttonTableLayoutPanel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}