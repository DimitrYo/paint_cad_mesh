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
    public partial class FillStyle : Form
    {
        public Brush brush;

        #region Initialize and PaintEvent and Brush

        public FillStyle(Brush fontbrush)
        {
            InitializeComponent();
            if (fontbrush is SolidBrush)
            {
                firstcolor = (fontbrush as SolidBrush).Color;
                solidbrushradio.Checked = true;
                button4.Visible = false;
                button3.CenterColor = firstcolor;
            }
            else
                if (fontbrush is LinearGradientBrush)
                {
                    firstcolor = (fontbrush as LinearGradientBrush).LinearColors[0];
                    secondcolor = (fontbrush as LinearGradientBrush).LinearColors[1];
                    linearGradient.Checked = true;
                    button3.CenterColor = firstcolor;
                    button4.CenterColor = secondcolor;
                    button4.Visible = true;
                }
                else
                    if (fontbrush is HatchBrush)
                    {
                        firstcolor = (fontbrush as HatchBrush).ForegroundColor;
                        secondcolor = (fontbrush as HatchBrush).BackgroundColor;
                        linearGradient.Checked = true;
                        button3.CenterColor = firstcolor;
                        button4.CenterColor = secondcolor;
                        button4.Visible = true;
                    }
            Invalidate();
        }

        #endregion

        private void FillStyle_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.panel1.CreateGraphics();
            if (solidbrushradio.Checked)
            {
                brush = new SolidBrush(firstcolor);
                g.Clear(firstcolor);
            }
            else
                if (linearGradient.Checked)
                {
                    brush = new LinearGradientBrush(new Point(0, 0), new Point(300, 300), firstcolor, secondcolor);
                    g.FillRectangle(brush, g.ClipBounds);
                }
                else
                    if (hatchbrushradio.Checked)
                    {
                        brush = new HatchBrush(HatchStyle.LightVertical, firstcolor, secondcolor);
                        g.FillRectangle(brush, g.ClipBounds);
                    }
            g.Dispose();
        }

        #region Buttons

        private void solidbrushradio_CheckedChanged(object sender, EventArgs e)
        {
            if (solidbrushradio.Checked)
            {
                button4.Visible = false;
            }
        }

        private void linearGradient_CheckedChanged_1(object sender, EventArgs e)
        {
            if (linearGradient.Checked)
            {
                button4.Visible = true;
                button4.CenterColor = secondcolor;
                Invalidate();
            }
        }


        private void hatchbrushradio_CheckedChanged(object sender, EventArgs e)
        {
            if (hatchbrushradio.Checked)            {
                button4.Visible = true;
                button4.CenterColor = secondcolor;
                Invalidate();
            }
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
                firstcolor = clDlg.Color;
                callingButton.CenterColor = firstcolor;
            }
            Invalidate();
            clDlg.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ColorButton callingButton = (ColorButton)sender;
            Point p = new Point(callingButton.Left, callingButton.Top + callingButton.Height);
            p = PointToScreen(p);

            ColorPaletteDialog clDlg = new ColorPaletteDialog(p.X, p.Y);

            clDlg.ShowDialog();
            if (clDlg.DialogResult == DialogResult.OK)
            {
                secondcolor = clDlg.Color;
                callingButton.CenterColor = secondcolor;
            }
            Invalidate();
            clDlg.Dispose();
        }

        #endregion

    }
}
