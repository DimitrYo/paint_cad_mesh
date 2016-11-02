using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace _01_Yovchev_208
{
    public partial class LineStyle : Form
    {
        public LineStyle(Pen pens )
        {
            InitializeComponent();
            pen = pens;
            button3.CenterColor = pen.Color;
            switch (pen.DashStyle)
            {
                case DashStyle.Dash:
                    {
                        dashradio.Checked = true; 
                    } break;
                case DashStyle.DashDot:
                    {
                        dashdotradio.Checked = true;
                    }break;
                case DashStyle.Solid:
                    {
                        solidradio.Checked = true;
                    } break;
                case DashStyle.Dot:
                    {
                        dotradio.Checked = true;
                    }break;
            }
        }

        private void line_width_ValueChanged(object sender, EventArgs e)
        {
            pen.Width = (float)line_width.Value;
        }

        private void LineStyle_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.panel1.CreateGraphics();
            g.Clear(Color.White);
            g.DrawLine(pen, 0, 0, panel1.Width, panel1.Height);
            g.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorButton callingButton = (ColorButton)sender;
            Point p = new Point(callingButton.Left, callingButton.Top + callingButton.Height);
            p = PointToScreen(p);
            ColorPaletteDialog clDlg = new ColorPaletteDialog(p.X, p.Y);
            clDlg.ShowDialog();
            if (clDlg.DialogResult == DialogResult.OK)
            {
                pen.Color = clDlg.Color;
                callingButton.CenterColor = pen.Color;
            }
            Invalidate();
            clDlg.Dispose();
        }

        private void solidradio_CheckedChanged(object sender, EventArgs e)
        {
            if (solidradio.Checked)
                pen.DashStyle = DashStyle.Solid;
            Invalidate();
        }

        private void dotradio_CheckedChanged(object sender, EventArgs e)
        {
            if (dotradio.Checked)
                pen.DashStyle = DashStyle.Dot;
            Invalidate();
        }

        private void dashdotradio_CheckedChanged(object sender, EventArgs e)
        {
            if (dashdotradio.Checked)
                pen.DashStyle = DashStyle.DashDot;
            Invalidate();
        }

        private void dashradio_CheckedChanged(object sender, EventArgs e)
        {
            if (dashradio.Checked)
                pen.DashStyle = DashStyle.Dash;
            Invalidate();
        }
    }
}
