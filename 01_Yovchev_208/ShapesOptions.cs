using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _01_Yovchev_208
{
    public partial class ShapesOptions : Form
    {
        public ShapesOptions(MyShapes shape1 )
        {
            InitializeComponent();
            shape = shape1;
            if (shape is Cylinder)
            {
                xcoor.Value = (shape as Cylinder).center.X;
                ycoor.Value = (shape as Cylinder).center.Y;
                zcoor.Value = (shape as Cylinder).center.Z;
                radius.Value = (shape as Cylinder).radius;
                height.Value = (shape as Cylinder).height;

            } else
                if (shape is Sphere)
                {
                    xcoor.Value = (shape as Sphere).center.X;
                    ycoor.Value = (shape as Sphere).center.Y;
                    zcoor.Value = (shape as Sphere).center.Z;
                    radius.Value = (shape as Sphere).radius;
                    height.Visible = false;
                    label3.Visible = false;
                    button1.Top = button1.Top - 25;
                    button2.Top = button2.Top - 25;
                    this.Height = this.Height - 30;
                }
        }

        private void ShapesOptions_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (shape is Cylinder)
            {
                (shape as Cylinder).center.X = (int)xcoor.Value;
                (shape as Cylinder).center.X = (int)xcoor.Value;
                (shape as Cylinder).center.X = (int)xcoor.Value;
                (shape as Cylinder).radius   = (int)radius.Value;
                (shape as Cylinder).height   = (int)height.Value;

            }
            else
                if (shape is Sphere)
                {
                    (shape as Sphere).center.X = (int)xcoor.Value;
                    (shape as Sphere).center.X = (int)xcoor.Value;
                    (shape as Sphere).center.X = (int)xcoor.Value;
                    (shape as Sphere).radius = (int)radius.Value;
                }
        }

       

    }
}
