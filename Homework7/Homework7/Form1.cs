using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework7
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private double th1 = 30 ;
        private double th2 = 20 ;
        private double per1 = 0.6;
        private double per2 = 0.7;
        private double leng = 100.0;
        private int n = 0;
        public Form1()
        {
            InitializeComponent();
            txtN.Text = $"{n}";
            txtLeng.Text = $"{leng}";
            txtPer1.Text = $"{per1}";
            txtPer2.Text = $"{per2}";
            txtTh1.Text = $"{th1}";
            txtTh2.Text = $"{th2}";
        }

        private void drawCayLeyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1);

            drawCayLeyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayLeyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }

        private void drawLine(double x0, double y0, double x1, double y1)
        {
            Pen p = new Pen(colorDialogPen.Color);
            graphics.DrawLine(p, (int)x0, (int)y0, (int) x1, (int)y1);
        }

        private void trackBarN_Scroll(object sender, EventArgs e)
        {
            txtN.Text = $"{trackBarN.Value}";
        }

        private void TextBoxFloat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
            TextBox tb = sender as TextBox;
            if (e.KeyChar == '.' && (tb.Text.Contains('.') || tb.Text.Length == 0))
            {
                e.Handled = true;
            }
        }
        private void TextBoxRatio_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (e.KeyCode == Keys.Enter)
            {
                if (Convert.ToDouble(tb.Text) > 1.0)
                {
                    tb.Text = "1.0";
                }
            }
        }

        private void TextBoxRatio_Leave(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (Convert.ToDouble(tb.Text) > 1.0)
            {
                tb.Text = "1.0";
            }            
        }
        private void TextBoxAngle_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (e.KeyCode == Keys.Enter)
            {
                if (Convert.ToDouble(tb.Text) > 180.0)
                {
                    tb.Text = "180";
                }
            }
        }

        private void TextBoxAngle_Leave(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (Convert.ToDouble(tb.Text) > 180.0)
            {
                tb.Text = "180";
            }
        }
        private void TextBoxInt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == '\r'))
            {
                e.Handled = true;
            }
        }

        private void txtN_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Convert.ToInt32(txtN.Text) <= trackBarN.Maximum)
                    trackBarN.Value = Convert.ToInt32(txtN.Text);
                else
                {
                    txtN.Text = $"{trackBarN.Maximum}";
                    trackBarN.Value = trackBarN.Maximum;
                }
                trackBarN.Focus();
            }
        }

        private void txtN_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtN.Text) <= trackBarN.Maximum)
                trackBarN.Value = Convert.ToInt32(txtN.Text);
            else
            {
                txtN.Text = $"{trackBarN.Maximum}";
                trackBarN.Value = trackBarN.Maximum;
            }
        }

        private void labelPenColor_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialogPen.ShowDialog();
            if (result == DialogResult.OK)
            {
                Label label = sender as Label;
                label.ForeColor = colorDialogPen.Color;
            }
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            if (graphics == null)
                graphics = Canvas.CreateGraphics();
            graphics.Clear(this.BackColor);
            th1 = Convert.ToDouble(txtTh1.Text) * Math.PI / 180;
            th2 = Convert.ToDouble(txtTh2.Text) * Math.PI / 180;
            per1 = Convert.ToDouble(txtPer1.Text);
            per2 = Convert.ToDouble(txtPer2.Text);
            leng = Convert.ToDouble(txtLeng.Text);
            n = Convert.ToInt32(txtN.Text);
            drawCayLeyTree(n, Canvas.Width / 2, Canvas.Height, leng, - Math.PI / 2);
        }
    }
}
