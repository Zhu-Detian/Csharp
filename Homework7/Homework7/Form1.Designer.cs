namespace Homework7
{
    partial class Form1
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
            this.trackBarN = new System.Windows.Forms.TrackBar();
            this.labelN = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.InputPanel = new System.Windows.Forms.Panel();
            this.btnDraw = new System.Windows.Forms.Button();
            this.labelPenColor = new System.Windows.Forms.Label();
            this.txtTh2 = new System.Windows.Forms.TextBox();
            this.txtTh1 = new System.Windows.Forms.TextBox();
            this.labelTh2 = new System.Windows.Forms.Label();
            this.labelTh1 = new System.Windows.Forms.Label();
            this.txtPer2 = new System.Windows.Forms.TextBox();
            this.labelPer2 = new System.Windows.Forms.Label();
            this.txtPer1 = new System.Windows.Forms.TextBox();
            this.labelPer1 = new System.Windows.Forms.Label();
            this.txtLeng = new System.Windows.Forms.TextBox();
            this.labelLeng = new System.Windows.Forms.Label();
            this.Canvas = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.colorDialogPen = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarN)).BeginInit();
            this.InputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBarN
            // 
            this.trackBarN.Location = new System.Drawing.Point(113, 3);
            this.trackBarN.Maximum = 20;
            this.trackBarN.Name = "trackBarN";
            this.trackBarN.Size = new System.Drawing.Size(203, 45);
            this.trackBarN.TabIndex = 0;
            this.trackBarN.Scroll += new System.EventHandler(this.trackBarN_Scroll);
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(3, 12);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(77, 12);
            this.labelN.TabIndex = 1;
            this.labelN.Text = "递归深度N = ";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(79, 8);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(31, 21);
            this.txtN.TabIndex = 2;
            this.txtN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxInt_KeyPress);
            this.txtN.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtN_KeyUp);
            this.txtN.Leave += new System.EventHandler(this.txtN_Leave);
            // 
            // InputPanel
            // 
            this.InputPanel.AutoSize = true;
            this.InputPanel.Controls.Add(this.btnDraw);
            this.InputPanel.Controls.Add(this.labelPenColor);
            this.InputPanel.Controls.Add(this.txtTh2);
            this.InputPanel.Controls.Add(this.txtTh1);
            this.InputPanel.Controls.Add(this.labelTh2);
            this.InputPanel.Controls.Add(this.labelTh1);
            this.InputPanel.Controls.Add(this.txtPer2);
            this.InputPanel.Controls.Add(this.labelPer2);
            this.InputPanel.Controls.Add(this.txtPer1);
            this.InputPanel.Controls.Add(this.labelPer1);
            this.InputPanel.Controls.Add(this.txtLeng);
            this.InputPanel.Controls.Add(this.labelLeng);
            this.InputPanel.Controls.Add(this.trackBarN);
            this.InputPanel.Controls.Add(this.txtN);
            this.InputPanel.Controls.Add(this.labelN);
            this.InputPanel.Location = new System.Drawing.Point(12, 13);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(350, 540);
            this.InputPanel.TabIndex = 3;
            // 
            // btnDraw
            // 
            this.btnDraw.AutoSize = true;
            this.btnDraw.Font = new System.Drawing.Font("宋体", 20F);
            this.btnDraw.Location = new System.Drawing.Point(107, 329);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(92, 37);
            this.btnDraw.TabIndex = 14;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // labelPenColor
            // 
            this.labelPenColor.AutoSize = true;
            this.labelPenColor.Font = new System.Drawing.Font("宋体", 20F);
            this.labelPenColor.Location = new System.Drawing.Point(95, 282);
            this.labelPenColor.Name = "labelPenColor";
            this.labelPenColor.Size = new System.Drawing.Size(120, 27);
            this.labelPenColor.TabIndex = 13;
            this.labelPenColor.Text = "画笔颜色";
            this.labelPenColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPenColor.Click += new System.EventHandler(this.labelPenColor_Click);
            // 
            // txtTh2
            // 
            this.txtTh2.Location = new System.Drawing.Point(106, 205);
            this.txtTh2.Name = "txtTh2";
            this.txtTh2.Size = new System.Drawing.Size(93, 21);
            this.txtTh2.TabIndex = 12;
            this.txtTh2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxFloat_KeyPress);
            this.txtTh2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxAngle_KeyUp);
            this.txtTh2.Leave += new System.EventHandler(this.TextBoxAngle_Leave);
            // 
            // txtTh1
            // 
            this.txtTh1.Location = new System.Drawing.Point(106, 165);
            this.txtTh1.Name = "txtTh1";
            this.txtTh1.Size = new System.Drawing.Size(93, 21);
            this.txtTh1.TabIndex = 11;
            this.txtTh1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxFloat_KeyPress);
            this.txtTh1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxAngle_KeyUp);
            this.txtTh1.Leave += new System.EventHandler(this.TextBoxAngle_Leave);
            // 
            // labelTh2
            // 
            this.labelTh2.AutoSize = true;
            this.labelTh2.Location = new System.Drawing.Point(5, 210);
            this.labelTh2.Name = "labelTh2";
            this.labelTh2.Size = new System.Drawing.Size(101, 12);
            this.labelTh2.TabIndex = 10;
            this.labelTh2.Text = "左分支角度Th2 = ";
            // 
            // labelTh1
            // 
            this.labelTh1.AutoSize = true;
            this.labelTh1.Location = new System.Drawing.Point(5, 170);
            this.labelTh1.Name = "labelTh1";
            this.labelTh1.Size = new System.Drawing.Size(95, 12);
            this.labelTh1.TabIndex = 9;
            this.labelTh1.Text = "右分支角度Th1 =";
            // 
            // txtPer2
            // 
            this.txtPer2.Location = new System.Drawing.Point(124, 125);
            this.txtPer2.Name = "txtPer2";
            this.txtPer2.Size = new System.Drawing.Size(75, 21);
            this.txtPer2.TabIndex = 8;
            this.txtPer2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxFloat_KeyPress);
            this.txtPer2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxRatio_KeyUp);
            this.txtPer2.Leave += new System.EventHandler(this.TextBoxRatio_Leave);
            // 
            // labelPer2
            // 
            this.labelPer2.AutoSize = true;
            this.labelPer2.Location = new System.Drawing.Point(5, 130);
            this.labelPer2.Name = "labelPer2";
            this.labelPer2.Size = new System.Drawing.Size(119, 12);
            this.labelPer2.TabIndex = 7;
            this.labelPer2.Text = "左分支长度比Per2 = ";
            // 
            // txtPer1
            // 
            this.txtPer1.Location = new System.Drawing.Point(124, 85);
            this.txtPer1.Name = "txtPer1";
            this.txtPer1.Size = new System.Drawing.Size(75, 21);
            this.txtPer1.TabIndex = 6;
            this.txtPer1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxFloat_KeyPress);
            this.txtPer1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxRatio_KeyUp);
            this.txtPer1.Leave += new System.EventHandler(this.TextBoxRatio_Leave);
            // 
            // labelPer1
            // 
            this.labelPer1.AutoSize = true;
            this.labelPer1.Location = new System.Drawing.Point(5, 90);
            this.labelPer1.Name = "labelPer1";
            this.labelPer1.Size = new System.Drawing.Size(119, 12);
            this.labelPer1.TabIndex = 5;
            this.labelPer1.Text = "右分支长度比Per1 = ";
            // 
            // txtLeng
            // 
            this.txtLeng.Location = new System.Drawing.Point(100, 45);
            this.txtLeng.Name = "txtLeng";
            this.txtLeng.Size = new System.Drawing.Size(99, 21);
            this.txtLeng.TabIndex = 4;
            this.txtLeng.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxFloat_KeyPress);
            // 
            // labelLeng
            // 
            this.labelLeng.AutoSize = true;
            this.labelLeng.Location = new System.Drawing.Point(5, 50);
            this.labelLeng.Name = "labelLeng";
            this.labelLeng.Size = new System.Drawing.Size(95, 12);
            this.labelLeng.TabIndex = 3;
            this.labelLeng.Text = "主干长度Leng = ";
            // 
            // Canvas
            // 
            this.Canvas.AutoSize = true;
            this.Canvas.Location = new System.Drawing.Point(365, 13);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(570, 540);
            this.Canvas.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // colorDialogPen
            // 
            this.colorDialogPen.AnyColor = true;
            this.colorDialogPen.ShowHelp = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 561);
            this.Controls.Add(this.Canvas);
            this.Controls.Add(this.InputPanel);
            this.Name = "Form1";
            this.Text = "CayleyTree";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarN)).EndInit();
            this.InputPanel.ResumeLayout(false);
            this.InputPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarN;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Panel InputPanel;
        private System.Windows.Forms.Panel Canvas;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelLeng;
        private System.Windows.Forms.TextBox txtLeng;
        private System.Windows.Forms.Label labelPer1;
        private System.Windows.Forms.TextBox txtPer1;
        private System.Windows.Forms.Label labelPer2;
        private System.Windows.Forms.TextBox txtPer2;
        private System.Windows.Forms.TextBox txtTh2;
        private System.Windows.Forms.TextBox txtTh1;
        private System.Windows.Forms.Label labelTh2;
        private System.Windows.Forms.Label labelTh1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label labelPenColor;
        private System.Windows.Forms.ColorDialog colorDialogPen;
        private System.Windows.Forms.Button btnDraw;
    }
}

