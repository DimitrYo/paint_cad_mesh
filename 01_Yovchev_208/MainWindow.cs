using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
namespace _01_Yovchev_208
{
    /* Внимание єтот код может нанести непоправий вред вашему здоровью. 
     * Код можно просматривать с 18 лет при присуствие взролых.
     */

  /* 
  * меню 80 линия 
  * рисование 90 баги 
  * ресизинг  0
  * контекстное меню 0
  */

    #region Инициализация главной формы

    public partial class MainWindow : Form
        {
    
        public MainWindow()
        {
            
            InitializeComponent();

            documentischanged = false;
            linepoints = new List<Point3D>();
            shapes = new System.Collections.ArrayList();
            Program.Zoom = 1.0f;
            isResizing = false;
            selectshape = false;
            selectshapeindex = -1;
            shapedraw = 1;
            Polygon.idline = 0;
            Cylinder.idcylinder = 0;
            Sphere.idsphere = 0;
            pointselectednumber = -1;
            selectshapeindex = -1;
            resizepoint1 = new Point3D();
            resizepoint2 = new Point3D();
            rezpol = new Point3D();
            sizeOptions.Enabled = false;
            contextmenuclicked = false;

            linecolocrbutton.BackColor = Color.LawnGreen;
            fillcolorbutton.BackColor = Color.LightBlue;
            linepen = new Pen(Color.LawnGreen, 2);
            fillbrush = new SolidBrush(Color.LightBlue);
            fontbrush = new SolidBrush(Color.White);

            showhidegrid = false;
            lockgrid = false;
            gridsize = 20;
            DragP = new Point3D();

            polygonStripButton1.Checked = true;
            cylindertoolStripButton.Checked = false;
            spheretoolStripButton.Checked = false;
            polygonToolStripMenuItem.Checked = true;
            cylinderToolStripMenuItem.Checked = false;
            sphereToolStripMenuItem.Checked = false;
            selectStripButton2.Checked = false;
            deleteselected.Enabled = false;

            xz = new Bitmap(this.panelxz.Width, this.panelxz.Height);
            yz = new Bitmap(this.panelyz.Width, this.panelyz.Height);
            xy = new Bitmap(this.panelxy.Width, this.panelxy.Height);

            bufxz = new Bitmap(xz);
            bufyz = new Bitmap(yz);
            bufxy = new Bitmap(xy);
            
            xzpanel = this.panelxz.CreateGraphics();
            xzpanel.SmoothingMode = SmoothingMode.HighQuality;
            yzpanel = this.panelyz.CreateGraphics();
            yzpanel.SmoothingMode = SmoothingMode.HighQuality;
            xypanel = this.panelxy.CreateGraphics();
            xypanel.SmoothingMode = SmoothingMode.HighQuality;
            toolStripStatusLabel4.Text = " Hello World!";
            ReDraw();
     
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (documentischanged == true)
            {
                DialogResult result = MessageBox.Show("Do you want to save the changes?", "Exit from Autocad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                switch (result)
                {
                    case DialogResult.OK:
                        {
                            e.Cancel = false;
                            saveToolStripButton.PerformClick();
                        } break;
                    case DialogResult.Ignore:
                        {
                            e.Cancel = false;
                        } break;
                    case DialogResult.Cancel:
                        {
                            e.Cancel = true;
                        } break;
                }
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer,
            true);
            this.UpdateStyles();
            isDragging = false;
        }

    #endregion

    #region Меню главной формы

        #region MenuFile

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (documentischanged)
            {
                DialogResult result = MessageBox.Show("Do you want to save the changes?", "Exit from Autocad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    saveToolStripButton.PerformClick();
                    return;
                }

                if (result == DialogResult.Cancel)
                    return;
            }

            shapes.Clear();
            ReDraw();
            documentischanged = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (documentischanged)
            {
                DialogResult saveExit = MessageBox.Show("Хотите сохранить изменения?", "Autocad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (saveExit == DialogResult.Yes)
                {
                    saveasToolStripMenuItem.PerformClick();
                    return;
                }

                if (saveExit == DialogResult.Cancel)
                    return;
            }
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel4.Text = "Saving information...";
            if (documentischanged)
            {
                if (filename != null)
                {
                    FileStream fs = new FileStream(filename, FileMode.Create);
                    BinaryFormatter formatter = new BinaryFormatter();
                    try
                    {
                        if (fs != null)
                        formatter.Serialize(fs, shapes);
                    }
                    catch (SerializationException ex)
                    {
                        MessageBox.Show("Serialization Error:  " + ex.Message);
                        throw;
                    }
                    finally
                    {
                        fs.Close();
                        toolStripStatusLabel4.Text = "Saving successfull...";
                    }
                }
                else
                    saveFileDialog1.ShowDialog();
            }
                else
                    saveFileDialog1.ShowDialog();
            
        }
      
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            documentischanged = false;

            FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open);
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                shapes.Clear();
                shapes = (System.Collections.ArrayList)formatter.Deserialize(fs);
            }
            catch (SerializationException ex)
            {
                MessageBox.Show("Deserialization Error:  " + ex.Message);
                throw;
            }
            finally
            {

                fs.Close();
            }

            filename = openFileDialog1.FileName;
            ReDraw();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            filename = saveFileDialog1.FileName;
            try
            {
                formatter.Serialize(fs, shapes);
            }
            catch (SerializationException ex)
            {
                MessageBox.Show("Serialization Error:  " + ex.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }

            documentischanged = false;
        }

        private void sizeOptions_Click(object sender, EventArgs e)
        {
            if (selectshapeindex != -1)
                if ((shapes[selectshapeindex] is Cylinder) || (shapes[selectshapeindex] is Sphere))
                {
                    ShapesOptions sizeoptions = new ShapesOptions((MyShapes)shapes[selectshapeindex]);
                    DialogResult result = sizeoptions.ShowDialog();
                    if (result == DialogResult.OK)
                    {

                        shapes[selectshapeindex] = sizeoptions.shape;

                        ReDraw();
                    }
                    sizeoptions.Dispose();
                }
        }

        private void contextmenu_Click(object sender, EventArgs e)
        {
            contextmenuclicked = true;
        }

        #endregion

        #region MenuFigures 

        private void polygonStripButton1_Click(object sender, EventArgs e)
        {
            polygonStripButton1.Checked = true;
            cylindertoolStripButton.Checked = false;
            spheretoolStripButton.Checked = false;
            polygonToolStripMenuItem.Checked = true;
            cylinderToolStripMenuItem.Checked = false;
            sphereToolStripMenuItem.Checked = false;
            selectStripButton2.Checked = false;
            shapedraw = 1;
            linestartdraw = false;
            linepoints.Clear();
            selectshape = false;
            selectshapeindex = -1;
            linecolocrbutton.BackColor = linepen.Color;
            fillcolorbutton.BackColor = (new MyBrush(fillbrush)).color1;
            ClearSelectedShape();
            ReDraw();
        }
        
        private void cylindertoolStripButton_Click(object sender, EventArgs e)
        {
            polygonStripButton1.Checked = false;
            cylindertoolStripButton.Checked = true;
            spheretoolStripButton.Checked = false;
            polygonToolStripMenuItem.Checked = false;
            cylinderToolStripMenuItem.Checked = true;
            sphereToolStripMenuItem.Checked = false;
            selectStripButton2.Checked = false;
            shapedraw = 2;
            linestartdraw = false;
            linepoints.Clear();
            selectshape = false;
            linecolocrbutton.BackColor = linepen.Color;
            fillcolorbutton.BackColor = (new MyBrush(fillbrush)).color1;
            selectshapeindex = -1;
            ClearSelectedShape();
            ReDraw();
        }
        
        private void spheretoolStripButton_Click(object sender, EventArgs e)
        {
            shapedraw = 3;
            polygonStripButton1.Checked = false;
            cylindertoolStripButton.Checked = false;
            spheretoolStripButton.Checked = true;
            polygonToolStripMenuItem.Checked = false;
            cylinderToolStripMenuItem.Checked = false;
            sphereToolStripMenuItem.Checked = true;
            selectStripButton2.Checked = false;
            linestartdraw = false;
            linepoints.Clear();
            linecolocrbutton.BackColor = linepen.Color;
            fillcolorbutton.BackColor = (new MyBrush(fillbrush)).color1;
            selectshape = false;
            selectshapeindex = -1;
            ClearSelectedShape();
            ReDraw();
        }

        private void selectStripButton2_Click(object sender, EventArgs e)
        {
            shapedraw = 0;
            selectStripButton2.Checked = true;
            polygonStripButton1.Checked = false;
            cylindertoolStripButton.Checked = false;
            spheretoolStripButton.Checked = false;
            polygonToolStripMenuItem.Checked = false;
            cylinderToolStripMenuItem.Checked = false;
            sphereToolStripMenuItem.Checked = false;
            linestartdraw = false;
            linepoints.Clear();
            selectshape = false;
            linecolocrbutton.BackColor = linepen.Color;
            fillcolorbutton.BackColor = (new MyBrush(fillbrush)).color1;
            selectshapeindex = -1;
            ClearSelectedShape();
            ReDraw();
        }

        private void deleteselected_Click(object sender, EventArgs e)        
        {
            if (selectshape)
            {
                for (int i = 0; i < shapes.Count; i++)
                {
                    if ((shapes[i] as MyShapes).isselected)
                    {
                        shapes.RemoveAt(i);
                        i--;
                    }
                }
                selectshape = false;
                deleteselected.Enabled = false;
                ReDraw();
            }
        }

        #endregion

        #region MenuView


        private void selectallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (shapes.Count != 0)
            {
                selectshape = true;
            //    selectall = true;
                foreach (MyShapes s in shapes)
                {
                    s.isselected = true;
                }
                deleteselected.Enabled = true;
                sizeOptions.Enabled = true;
                ReDraw();
            }
            else
                MessageBox.Show("No shapes");
        }

        private void zoonInToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Program.Zoom < 4)
            {
           //     zoomischanged = true;
                Program.Zoom *= 2;
                ReDraw();
                toolStripStatusLabel4.Text = "ZoomIn: " + Program.Zoom + "X";
            }
            else
                toolStripStatusLabel4.Text = "MaxZoomIn is " + Program.Zoom + "X"; 
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
         //   zoomischanged = true;
            if (Program.Zoom > 0.25)
            {
          //      zoomischanged = true;
                Program.Zoom = Program.Zoom / 2;
                ReDraw();
                toolStripStatusLabel4.Text = "ZoomOut: " + Program.Zoom + "X";
            } else
                toolStripStatusLabel4.Text = "MinZoom is " + Program.Zoom + "X"; 
        }

        #endregion 

        #region MenuTools
        

        private void fillStyleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FillStyle fillstyleform = new FillStyle(fillbrush);
            DialogResult result = fillstyleform.ShowDialog();
            if (result == DialogResult.OK)
            {
                bool changeshape = false;
                if (!contextmenuclicked)
                    foreach (MyShapes s in shapes)
                    {
                        if (s.isselected)
                        {
                            s.b1 = new MyBrush(fillstyleform.brush);
                            changeshape = true;
                             
                        }
                    }
                else
                {
                    (shapes[selectshapeindex] as MyShapes).b1 = new MyBrush(fillstyleform.brush);
                    changeshape = true;
                    contextmenuclicked = false;
                }
                if (!changeshape)
                {
                    fillbrush = fillstyleform.brush;
                    fillcolorbutton.BackColor = fillstyleform.firstcolor;
                }
                ReDraw();
            }
            fillstyleform.Dispose();
        }

        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LineStyle lineform = new LineStyle(linepen);
            DialogResult result =  lineform.ShowDialog();
            if (result == DialogResult.OK)
            {              

                bool changeshape = false;
                if (!contextmenuclicked)
                foreach (MyShapes s in shapes)  
                {
                    if (s.isselected)
                    {
                        s.p1 = new MyPen(lineform.pen);
                        changeshape = true;
                        linecolocrbutton.BackColor = lineform.pen.Color;
                    }
                } else
                {
                    (shapes[selectshapeindex] as MyShapes).p1 = new MyPen(lineform.pen);
                    changeshape = true;
                    contextmenuclicked = false;
                }
                if (!changeshape)
                {
                    linepen = lineform.pen;
                    linecolocrbutton.BackColor = linepen.Color;
                }
                ReDraw();
            }
            lineform.Dispose();
        }

        private void backgroundStyleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackgroudStyle backctyleform = new BackgroudStyle(fontbrush);
            DialogResult result =  backctyleform.ShowDialog();
            if (result == DialogResult.OK)
            {
                fontbrush = backctyleform.brush;
                ReDraw();
            }
            backctyleform.Dispose();
        }

        private void showhideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowHideGrid griddialog = new ShowHideGrid(showhidegrid, lockgrid, gridsize);
            DialogResult result = griddialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                lockgrid = griddialog.lock_grid;
                showhidegrid = griddialog.showhide_grid;
                gridsize = griddialog.grid_size;
            }
            ReDraw();
            griddialog.Dispose();
        }

        private void fillcolorbutton_Click(object sender, EventArgs e)
        {
            Button b1 = (Button)sender;
            Point p = new Point(b1.Left, b1.Top + b1.Height);
            p = PointToScreen(p);
            ColorPaletteDialog clDlg = new ColorPaletteDialog(p.X, p.Y);
            clDlg.ShowDialog();
            if (clDlg.DialogResult == DialogResult.OK)
            {
                b1.BackColor = clDlg.Color;
                bool changeshape = false;
                foreach (MyShapes s in shapes)
                {
                    if (s.isselected)
                    {
                        s.b1.color1 = clDlg.Color;
                        changeshape = true;
                    }
                }
                if (!changeshape)
                {
                    MyBrush b = new MyBrush(fillbrush);
                    b.color1 = clDlg.Color;
                    fillbrush = b.getbrush();
                }
                ReDraw();
            }
            clDlg.Dispose();
            Invalidate();
        }

        private void linecolocrbutton_Click(object sender, EventArgs e)
        {
            Button b1 = (Button)sender;
            Point p = new Point(b1.Left, b1.Top + b1.Height);
            p = PointToScreen(p);
            ColorPaletteDialog clDlg = new ColorPaletteDialog(p.X, p.Y);
            clDlg.ShowDialog();
            if (clDlg.DialogResult == DialogResult.OK)
            {
                b1.BackColor = clDlg.Color;
                bool changeshape = false;
                foreach (MyShapes s in shapes)
                {
                    if (s.isselected)
                    {
                        s.p1 = new MyPen(new Pen(clDlg.Color, s.p1.getPen().Width));
                        changeshape = true;
                    }
                }
                if (!changeshape)
                    linepen = new Pen(clDlg.Color, linepen.Width);
                ReDraw();
            }
            clDlg.Dispose();
            Invalidate();
        }

        #endregion

        #region MenuHelp

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kurs Work Student Second year of study Yovchev D. K.", "About");
        }

        #endregion

    #endregion

    #region HelpsFunctions

        public void findresizer(MyShapes shape)
        {
            try
            {
                if (shape is Polygon)
                {
                    List<int> x1 = new List<int>();
                    List<int> y1 = new List<int>();
                    List<int> z1 = new List<int>();

                    foreach (Point3D p in (shape as Polygon).points)
                    {
                        x1.Add(p.X);
                        y1.Add(p.Y);
                        z1.Add(p.Z);
                    }
                    int minx = x1.Min();
                    int miny = y1.Min();
                    int minz = z1.Min();
                    int maxx = x1.Max();
                    int maxy = y1.Max();
                    int maxz = z1.Max();

                    resizepoint1 = new Point3D(minx, miny, minz);
                    resizepoint2 = new Point3D(maxx, maxy, maxz);
                    x1.Clear();
                    y1.Clear();
                    z1.Clear();

                }
                else
                    if (shape is Cylinder)
                    {
                        int minx = (shape as Cylinder).center.X - (shape as Cylinder).radius;
                        int maxx = (shape as Cylinder).center.X + (shape as Cylinder).radius;
                        int miny = (shape as Cylinder).center.Y - (shape as Cylinder).radius;
                        int maxy = (shape as Cylinder).center.Y + (shape as Cylinder).radius;
                        int minz = (shape as Cylinder).center.Z - (shape as Cylinder).height;
                        int maxz = (shape as Cylinder).center.Z;

                        resizepoint1 = new Point3D(minx, miny, minz);
                        resizepoint2 = new Point3D(maxx, maxy, maxz);
                    }
                    else if (shape is Sphere)
                    {
                        int minx = (shape as Sphere).center.X - (shape as Sphere).radius;
                        int maxx = (shape as Sphere).center.X + (shape as Sphere).radius;
                        int miny = (shape as Sphere).center.Y - (shape as Sphere).radius;
                        int maxy = (shape as Sphere).center.Y + (shape as Sphere).radius;
                        int minz = (shape as Sphere).center.Z - (shape as Sphere).radius; ;
                        int maxz = (shape as Sphere).center.Z + (shape as Sphere).radius;

                        resizepoint1 = new Point3D(minx, miny, minz);
                        resizepoint2 = new Point3D(maxx, maxy, maxz);
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("\tError in resize:\n\t " + ex.Message);
            }
        }

        public void drawresizer()
        {
            int minx = resizepoint1.X;
            int miny = resizepoint1.Y;
            int minz = resizepoint1.Z;
            int maxx = resizepoint2.X;
            int maxy = resizepoint2.Y;
            int maxz = resizepoint2.Z;

            
            SolidBrush brush;
            Pen pen = new Pen(Color.Black, 1);
            pen.DashStyle = DashStyle.Dot;
            if (!isResizing)
            { brush = new SolidBrush(Color.BlueViolet); }
            else
            { brush = new SolidBrush(Color.LightCoral); }

            Program.xzbuff.DrawRectangle(pen, minx - 4, minz - 4, maxx - minx + 8, maxz - minz + 8);
            Program.yzbuff.DrawRectangle(pen, miny - 4, minz - 4, maxy - miny + 8, maxz - minz + 8);
            Program.xybuff.DrawRectangle(pen, minx - 4, miny - 4, maxx - minx + 8, maxy - miny + 8);

            Program.xzbuff.FillRectangle(brush, maxx + 4, maxz + 4, 6, 6);
            Program.yzbuff.FillRectangle(brush, maxy + 4, maxz + 4, 6, 6);
            Program.xybuff.FillRectangle(brush, maxx + 4, maxy + 4, 6, 6);

            pen.Dispose();
            brush.Dispose();
        }

        private void ReDraw()
        {
            Graphics g1 = Graphics.FromImage((Image)xz);
            Graphics g2 = Graphics.FromImage((Image)yz);
            Graphics g3 = Graphics.FromImage((Image)xy);

            g1.FillRectangle(fontbrush, new Rectangle(new Point(0, 0), xz.Size));
            g2.FillRectangle(fontbrush, new Rectangle(new Point(0, 0), yz.Size));
            g3.FillRectangle(fontbrush, new Rectangle(new Point(0, 0), xy.Size));

            g1.Dispose();
            g2.Dispose();
            g3.Dispose();

            DrawGrid();

            bufxy.Dispose();
            bufyz.Dispose();
            bufxy.Dispose();
           
            bufxz = new Bitmap(xz);
            bufyz = new Bitmap(yz);
            bufxy = new Bitmap(xy);

            Program.xzbuff = Graphics.FromImage((Image)bufxz);
            Program.yzbuff = Graphics.FromImage((Image)bufyz);
            Program.xybuff = Graphics.FromImage((Image)bufxy);

        /*    Program.xzbuff.PageScale = Program.Zoom;
            Program.yzbuff.PageScale = Program.Zoom;
            Program.xybuff.PageScale = Program.Zoom;*/

            Program.xzbuff.ScaleTransform(Program.Zoom, Program.Zoom);
            Program.yzbuff.ScaleTransform(Program.Zoom, Program.Zoom);
            Program.xybuff.ScaleTransform(Program.Zoom, Program.Zoom);

            Program.xzbuff.SmoothingMode = SmoothingMode.HighQuality;
            Program.yzbuff.SmoothingMode = SmoothingMode.HighQuality;
            Program.xybuff.SmoothingMode = SmoothingMode.HighQuality;
          
            foreach (MyShapes sh in shapes)
            {
                sh.Draw();
            }

            if ((selectshapeindex != -1)&&(!isResizing)&&selectshape&&(shapes.Count != 0 ))
            {
                findresizer((MyShapes)shapes[selectshapeindex]);
                drawresizer();
            }
            if (selectshape)
            drawresizer();

            xzpanel.DrawImage((Image)bufxz, 0, 0);
            yzpanel.DrawImage((Image)bufyz, 0, 0);
            xypanel.DrawImage((Image)bufxy, 0, 0);

            Program.xzbuff.Dispose();
            Program.yzbuff.Dispose();
            Program.xybuff.Dispose();

            xz.Dispose();
            yz.Dispose();
            xy.Dispose();

            xz = new Bitmap(bufxz);
            yz = new Bitmap(bufyz);
            xy = new Bitmap(bufxy);
        }

        private void DrawGrid()
        {
            if (showhidegrid)
            {
                Graphics g1 = Graphics.FromImage((Image)xz);
                Graphics g2 = Graphics.FromImage((Image)yz);
                Graphics g3 = Graphics.FromImage((Image)xy);
                Pen gridpen = new Pen(Color.Black, 1);
                for (int k = gridsize; k < bufxz.Width; k += gridsize)
                {
                    g1.DrawLine(gridpen, k, 0, k, bufxz.Height);
                    g1.DrawLine(gridpen, 0, k, bufxz.Width, k);
                }
                for (int k = gridsize; k < bufyz.Width; k += gridsize)
                {
                    g2.DrawLine(gridpen, k, 0, k, bufxz.Height);
                    g2.DrawLine(gridpen, 0, k, bufxz.Width, k);
                }
                for (int k = gridsize; k < bufxy.Width; k += gridsize)
                {
                    g3.DrawLine(gridpen, k, 0, k, bufxz.Height);
                    g3.DrawLine(gridpen, 0, k, bufxz.Width, k);
                }
                g1.Dispose();
                g2.Dispose();
                g3.Dispose();
            }
        }

        private Point LockGrid(Point P)
        {
            if (lockgrid)
            {
                int x, y;
                x = ((int)Math.Round(Convert.ToDouble(P.X) / Convert.ToDouble(gridsize))) * gridsize;
                y = ((int)Math.Round(Convert.ToDouble(P.Y) / Convert.ToDouble(gridsize))) * gridsize;
                Point p1 = new Point(x, y);
                return p1;
            }
            return P;
        }

        private Point ScalePoint(Point P)
        {
            Point point = P;
            point.X = (int)(P.X / Program.Zoom);
            point.Y = (int)(P.Y / Program.Zoom);
            return point;
        }

        private void ClearSelectedShape()
        {
            foreach (MyShapes s in shapes)
            {
                s.isselected = false;
            }
        }

        #endregion

    #region Рисование

        #region PanelXZ

        private void panelxz_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                startdraw = LockGrid( ScalePoint(e.Location));
                if (shapedraw == 0)
            {
                startdraw = ScalePoint(e.Location);
                isResizing = false;
                isDragging = false;
                if ((Math.Abs(startdraw.X - resizepoint2.X-7) <= 3) && (Math.Abs(startdraw.Y - resizepoint2.Z-7) <= 3) && selectshape)
                {
                    this.Cursor = Cursors.SizeNWSE;
                    isResizing = true;
                    selectshape = true;
                    rezpol = new Point3D(resizepoint2.X, resizepoint2.Y, resizepoint2.Z);
                    ReDraw();
                    return;
                }
                else
                {
                //    selectall = false;
                    selectshape = false;
                    for (int l = shapes.Count - 1; l >= 0; l--)
                    {
                        MyShapes s = (MyShapes)shapes[l];
                        if (s.isxz(startdraw))
                        {
                            s.isselected = true;
                            selectshape = true;
                            isDragging = true;
                            this.Cursor = Cursors.SizeAll;
                            linecolocrbutton.BackColor = s.p1.pen_color;
                            fillcolorbutton.BackColor = s.b1.color1;
                            if (s is Polygon)
                            {
                                this.Cursor = this.DefaultCursor;
                                {
                                    if ((pointselectednumber = (s as Polygon).inxzpoint(startdraw)) != -1)
                                    {
                                        DragP.X = (s as Polygon).points[pointselectednumber].X;
                                        DragP.Z = (s as Polygon).points[pointselectednumber].Z;
                                        this.Cursor = Cursors.SizeAll;
                                    } 
                                } 
                                selectshapeindex = l;

                            }
                            else
                                if (s is Cylinder)
                                {
                                    DragP.X = (s as Cylinder).center.X - startdraw.X;
                                    DragP.Z = (s as Cylinder).center.Z - startdraw.Y;
                                    selectshapeindex = l;
                                }
                                else
                                    if (s is Sphere)
                                    {
                                        DragP.X = (s as Sphere).center.X - startdraw.X;
                                        DragP.Z = (s as Sphere).center.Z - startdraw.Y;
                                        selectshapeindex = l;
                                    }
                            startdraw = LockGrid(ScalePoint(e.Location));
                            toolStripStatusLabel4.Text = s.name;
                            deleteselected.Enabled = true;
                            sizeOptions.Enabled = true;
                            break;
                        }
                    }


                    if (!selectshape)
                    {
                        ClearSelectedShape();
                        selectshape = false;
                        deleteselected.Enabled = false;
                        sizeOptions.Enabled = false;
                        selectshapeindex = -1;
                        linecolocrbutton.BackColor = linepen.Color;
                        fillcolorbutton.BackColor =   (new MyBrush(fillbrush)).color1;
                    }
                }
                ReDraw();
            }
            }
                // Context menu
            else if (e.Button == MouseButtons.Right)
            {
                if (shapedraw == 0)
                {
                    selectshape = false;
                    for (int l = shapes.Count - 1; l >= 0; l--)
                    {
                        MyShapes s = (MyShapes)shapes[l];
                        if (s.isxz(ScalePoint(e.Location)))
                        {
                            s.isselected = true;
                            selectshape = true;
                            linecolocrbutton.BackColor = s.p1.pen_color;
                            fillcolorbutton.BackColor = s.b1.color1;
                            if (s is Polygon)
                            {
                                contextmenufillstyle.Visible = false;
                                contextmenusizeoptions.Visible = false;
                                selectshapeindex = l;

                            }
                            else
                                if ((s is Cylinder) || (s is Sphere))
                                {
                                    contextmenufillstyle.Visible = true;
                                    contextmenusizeoptions.Visible = true;
                                    selectshapeindex = l;
                                }
                            contextmenudeleteselected.Visible = true;
                            contextmenubaskstyle.Visible = false;
                            toolStripStatusLabel4.Text = s.name;
                            deleteselected.Enabled = true;
                            sizeOptions.Enabled = true;
                            break;
                        }
                    }
                    if (!selectshape)
                    {
                        contextmenufillstyle.Visible = false;
                        contextmenusizeoptions.Visible = false;
                        contextmenusizeoptions.Visible = false;
                        contextmenudeleteselected.Visible = false;
                        contextmenubaskstyle.Visible = true;
                        contextmenulinestyle.Visible = false;
                        contextmenu.Visible = false;

                        ClearSelectedShape();
                        selectshape = false;
                        deleteselected.Enabled = false;
                        sizeOptions.Enabled = false;
                        selectshapeindex = -1;
                        linecolocrbutton.BackColor = linepen.Color;
                        fillcolorbutton.BackColor = (new MyBrush(fillbrush)).color1;
                    }
                    ReDraw();
                }
                else
                {
                    contextmenufillstyle.Visible = false;
                    contextmenusizeoptions.Visible = false;
                    contextmenusizeoptions.Visible = false;
                    contextmenudeleteselected.Visible = false;
                    contextmenubaskstyle.Visible = false;
                    contextmenulinestyle.Visible = false;
                }
            }
        }

        private void panelxz_MouseMove(object sender, MouseEventArgs e)
        {
            enddraw = LockGrid(ScalePoint(e.Location));
            if (shapedraw == 0)
            {
                if (e.Button == MouseButtons.Left)
                    if (isResizing)
                    {
                        enddraw = ScalePoint(e.Location);
                        resizepoint2.X = enddraw.X;
                        resizepoint2.Z = enddraw.Y;
                        ReDraw();
                    } else
                    if (isDragging)
                    {
                        {
                           // foreach(MyShapes sh in shapes)
                            if ( selectshapeindex != -1)
                            {
                                MyShapes sh = (MyShapes)shapes[selectshapeindex];
                                if (sh.isselected)
                                {
                                  //  enddraw = LockGrid(ScalePoint(e.Location));
                                    if (sh is Polygon)
                                    {
                                        if (pointselectednumber != -1)
                                        {
                                            (sh as Polygon).points[pointselectednumber].X = enddraw.X; 
                                            (sh as Polygon).points[pointselectednumber].Z = enddraw.Y; 
                                        }
                                    }
                                    else
                                        if (sh is Cylinder)
                                        {
                                            (sh as Cylinder).center.X = DragP.X + enddraw.X;
                                            (sh as Cylinder).center.Z = DragP.Z + enddraw.Y;
                                        //    break;
                                        }
                                        else
                                            if (sh is Sphere)
                                            {
                                                (sh as Sphere).center.X = DragP.X + enddraw.X;
                                                (sh as Sphere).center.Z = DragP.Z + enddraw.Y;
                                      //          break;
                                            }
                                }
                            }
                        }
                        ReDraw();
                    }

            } else
                    if (shapedraw == 1)
                    {
                        enddraw = LockGrid(ScalePoint(e.Location));
                        PanelsDraw(1);
                    }
                    else
                        if (e.Button == MouseButtons.Left)
                        {
                            enddraw = LockGrid(ScalePoint(e.Location));
                            PanelsDraw(1);
                        }
        }

        private void panelxz_MouseUp(object sender, MouseEventArgs e)
        {
           if (e.Button == MouseButtons.Left)
           {
               xz.Dispose();
               yz.Dispose();
               xy.Dispose();
               xz = new Bitmap(bufxz);
               yz = new Bitmap(bufyz);
               xy = new Bitmap(bufxy);
               switch (shapedraw)
               {
                   case 0:
                       {
                           if (isResizing)
                           {
                               if (shapes[selectshapeindex] is Cylinder)
                               {
                                   MyShapes s = (MyShapes)shapes[selectshapeindex];
                                   Point point1 = new Point(resizepoint1.X, resizepoint1.Z);
                                   Point point2 = new Point(resizepoint2.X, resizepoint2.Z);
                                   shapes[selectshapeindex] = new Cylinder(point1, point2, Math.Abs((point2.X - point1.X) / 2), Math.Abs(point2.Y - point1.Y), 1);
                                   (shapes[selectshapeindex] as Cylinder).p1 = s.p1;
                                   (shapes[selectshapeindex] as Cylinder).b1 = s.b1;
                                   ((MyShapes)shapes[selectshapeindex]).isselected = true;
                               } else
                                   if (shapes[selectshapeindex] is Sphere)
                                   {
                                       MyShapes s = (MyShapes)shapes[selectshapeindex];
                                       Point point1 = new Point(resizepoint1.X, resizepoint1.Z);
                                       Point point2 = new Point(resizepoint2.X, resizepoint2.Z);
                                       shapes[selectshapeindex] = new Sphere(point1, point2, Math.Abs((point2.Y - point1.Y) / 2), 1);
                                       (shapes[selectshapeindex] as Sphere).p1 = s.p1;
                                       (shapes[selectshapeindex] as Sphere).b1 = s.b1;
                                       ((MyShapes)shapes[selectshapeindex]).isselected = true;
                                   }
                                   else if (shapes[selectshapeindex] is Polygon)
                                   {
                                     /*  for (int i = 0; i < (shapes[selectshapeindex] as Polygon).points.Count;i++ )
                                       {
                                          Point3D  p3d = (shapes[selectshapeindex] as Polygon).points[i];
                                           {
                                               if (p3d.Z == resizepoint1.Z)
                                                   p3d.X = p3d.X + resizepoint2.X - rezpol.X;
                                               else
                                                   if (p3d.X == resizepoint1.X)
                                                       p3d.Z += resizepoint2.Z - rezpol.Z;
                                                   else
                                                   {
                                                       p3d.X += resizepoint2.X - rezpol.X;
                                                       p3d.Z += resizepoint2.Z - rezpol.Z;
                                                   }
                                               (shapes[selectshapeindex] as Polygon).points[i] = p3d;
                                           }

                                       }*/
                                       if (((resizepoint2.X - resizepoint1.X) > 0) && ((rezpol.X - resizepoint1.X) > 0) && ((resizepoint2.Z - resizepoint1.Z) > 0) && ((rezpol.Z - resizepoint1.Z) > 0))
                                       for (int i = 0; i < (shapes[selectshapeindex] as Polygon).points.Count; i++)
                                       {
                                           Point3D p3d = (shapes[selectshapeindex] as Polygon).points[i];
                                           {

                                               if ((p3d.Z == resizepoint1.Z) && (p3d.X == resizepoint1.X))
                                               {
                                               }
                                               else
                                                   if (p3d.Z == resizepoint1.Z)
                                                       p3d.X = Convert.ToInt32(Convert.ToDouble(p3d.X) * Convert.ToDouble(Math.Abs(resizepoint2.X - resizepoint1.X)) / Convert.ToDouble(Math.Abs(rezpol.X - resizepoint1.X)));
                                                   else
                                                       if (p3d.X == resizepoint1.X)
                                                           p3d.Z = Convert.ToInt32(Convert.ToDouble(p3d.Z) * Convert.ToDouble(Math.Abs(resizepoint2.Z - resizepoint1.Z)) / Convert.ToDouble(Math.Abs(rezpol.Z - resizepoint1.Z)));
                                                       else
                                                       {
                                                           p3d.X = Convert.ToInt32(Convert.ToDouble(p3d.X) * Convert.ToDouble(Math.Abs(resizepoint2.X - resizepoint1.X)) / Convert.ToDouble(Math.Abs(rezpol.X - resizepoint1.X)));
                                                           p3d.Z = Convert.ToInt32(Convert.ToDouble(p3d.Z) * Convert.ToDouble(Math.Abs(resizepoint2.Z - resizepoint1.Z)) / Convert.ToDouble(Math.Abs(rezpol.Z - resizepoint1.Z)));
                                                       }
                                           }
                                           (shapes[selectshapeindex] as Polygon).points[i] = p3d;
                                       }
                                   }
                               //  selectshapeindex = -1;
                               isResizing = false;
                               documentischanged = true;
                               this.Cursor = this.DefaultCursor;
                               ReDraw();
                           }
                           else
                           if (isDragging)
                           {
                               pointselectednumber = -1;
                            //   selectshapeindex = -1;
                               isDragging = false;
                               documentischanged = true;
                               this.Cursor = this.DefaultCursor;
                           }
                       } break;
                   case 2:
                        {
                            Cylinder.idcylinder++;
                            Cylinder p12 = new Cylinder(startdraw, enddraw, Math.Abs((enddraw.X - startdraw.X) / 2), Math.Abs(enddraw.Y - startdraw.Y), 1);
                            p12.p1 = new MyPen(linepen);
                            p12.b1 = new MyBrush(fillbrush);
                            shapes.Add(p12);
                            documentischanged = true;
                       } break;
                   case 3:
                       {
                           Sphere.idsphere++;
                            Sphere p123 = new Sphere(startdraw, enddraw, Math.Abs((enddraw.Y - startdraw.Y) / 2), 1);
                            p123.p1 = new MyPen(linepen);
                            p123.b1 = new MyBrush(fillbrush);
                            shapes.Add(p123);
                            documentischanged = true;
                        } break;
               }
            }
        }
            
        private void panelxz_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            if (shapedraw == 1)
            {

                {
                    Point g1 = LockGrid(ScalePoint(e.Location));
                    linepoints.Add(new Point3D(g1.X, g1.X, g1.Y));
                    linestartdraw = true;
                }
            }         
        }

        private void panelxz_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                if (shapedraw == 1)
                {
                    if (linepoints.Count > 0)
                    {
                        Polygon.idline++;
                        Polygon pol = new Polygon(linepen, fillbrush, linepoints);
                        shapes.Add(pol);
                        documentischanged = true;
                    } 
                    linestartdraw = false;
                    linepoints.Clear();
                }
        }

        private void panelxz_MouseLeave(object sender, EventArgs e)
        {
            isDragging = false;
            xzpanel.DrawImage((Image)xz, 0, 0);
            yzpanel.DrawImage((Image)yz, 0, 0);
            xypanel.DrawImage((Image)xy, 0, 0);
        }

        private void panelxz_Paint(object sender, PaintEventArgs e)
        {
            xzpanel.DrawImage(xz, 0, 0);
        }

        #endregion

        #region PanelYZ

        private void panelyz_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                startdraw = LockGrid(ScalePoint(e.Location));
                if (shapedraw == 0)
                {
                    startdraw = ScalePoint(e.Location);
                    isResizing = false;
                    isDragging = false;
                    if ((Math.Abs(startdraw.X - resizepoint2.Y - 7) <= 3) && (Math.Abs(startdraw.Y - resizepoint2.Z - 7) <= 3) && selectshape)
                    {
                        this.Cursor = Cursors.SizeNWSE;
                        isResizing = true;
                        selectshape = true;
                        rezpol = new Point3D(resizepoint2.X, resizepoint2.Y, resizepoint2.Z);
                        ReDraw();
                        return;
                    }
                    else
                    {
                        //    selectall = false;
                        selectshape = false;
                        for (int l = shapes.Count - 1; l >= 0; l--)
                        {
                            MyShapes s = (MyShapes)shapes[l];
                            if (s.isyz(startdraw))
                            {
                                s.isselected = true;
                                selectshape = true;
                                isDragging = true;
                                this.Cursor = Cursors.SizeAll;
                                linecolocrbutton.BackColor = s.p1.pen_color;
                                fillcolorbutton.BackColor = s.b1.color1;
                                if (s is Polygon)
                                {
                                    this.Cursor = this.DefaultCursor;
                                    {
                                        if ((pointselectednumber = (s as Polygon).inyzpoint(startdraw)) != -1)
                                        {
                                            DragP.Y = (s as Polygon).points[pointselectednumber].Y;
                                            DragP.Z = (s as Polygon).points[pointselectednumber].Z;
                                            this.Cursor = Cursors.SizeAll;
                                        }
                                    }
                                    selectshapeindex = l;

                                }
                                else
                                    if (s is Cylinder)
                                    {
                                        DragP.Y = (s as Cylinder).center.Y - startdraw.X;
                                        DragP.Z = (s as Cylinder).center.Z - startdraw.Y;
                                        selectshapeindex = l;
                                    }
                                    else
                                        if (s is Sphere)
                                        {
                                            DragP.Y = (s as Sphere).center.Y - startdraw.X;
                                            DragP.Z = (s as Sphere).center.Z - startdraw.Y;
                                            selectshapeindex = l;
                                        }
                                startdraw = LockGrid(ScalePoint(e.Location));
                                toolStripStatusLabel4.Text = s.name;
                                deleteselected.Enabled = true;
                                sizeOptions.Enabled = true;
                                break;
                            }
                        }


                        if (!selectshape)
                        {
                            ClearSelectedShape();
                            selectshape = false;
                            deleteselected.Enabled = false;
                            sizeOptions.Enabled = false;
                            selectshapeindex = -1;
                            linecolocrbutton.BackColor = linepen.Color;
                            fillcolorbutton.BackColor = (new MyBrush(fillbrush)).color1;
                        }
                    }
                    ReDraw();
                }
            }
            // Context menu
            else if (e.Button == MouseButtons.Right)
            {
                if (shapedraw == 0)
                {
                    selectshape = false;
                    for (int l = shapes.Count - 1; l >= 0; l--)
                    {
                        MyShapes s = (MyShapes)shapes[l];
                        if (s.isyz(ScalePoint(e.Location)))
                        {
                            s.isselected = true;
                            selectshape = true;
                            linecolocrbutton.BackColor = s.p1.pen_color;
                            fillcolorbutton.BackColor = s.b1.color1;
                            if (s is Polygon)
                            {
                                contextmenufillstyle.Visible = false;
                                contextmenusizeoptions.Visible = false;
                                selectshapeindex = l;

                            }
                            else
                                if ((s is Cylinder) || (s is Sphere))
                                {
                                    contextmenufillstyle.Visible = true;
                                    contextmenusizeoptions.Visible = true;
                                    selectshapeindex = l;
                                }
                            contextmenudeleteselected.Visible = true;
                            contextmenubaskstyle.Visible = false;
                            toolStripStatusLabel4.Text = s.name;
                            deleteselected.Enabled = true;
                            sizeOptions.Enabled = true;
                            break;
                        }
                    }
                    if (!selectshape)
                    {
                        contextmenufillstyle.Visible = false;
                        contextmenusizeoptions.Visible = false;
                        contextmenusizeoptions.Visible = false;
                        contextmenudeleteselected.Visible = false;
                        contextmenubaskstyle.Visible = true;
                        contextmenulinestyle.Visible = false;
                        contextmenu.Visible = false;

                        ClearSelectedShape();
                        selectshape = false;
                        deleteselected.Enabled = false;
                        sizeOptions.Enabled = false;
                        selectshapeindex = -1;
                        linecolocrbutton.BackColor = linepen.Color;
                        fillcolorbutton.BackColor = (new MyBrush(fillbrush)).color1;
                    }
                    ReDraw();
                }
                else
                {
                    contextmenufillstyle.Visible = false;
                    contextmenusizeoptions.Visible = false;
                    contextmenusizeoptions.Visible = false;
                    contextmenudeleteselected.Visible = false;
                    contextmenubaskstyle.Visible = false;
                    contextmenulinestyle.Visible = false;
                }
            }
        }

        private void panelyz_MouseMove(object sender, MouseEventArgs e)
        {
            enddraw = LockGrid(ScalePoint(e.Location));
            if (shapedraw == 0)
            {
                if (e.Button == MouseButtons.Left)
                    if (isResizing)
                    {
                        enddraw = ScalePoint(e.Location);
                        resizepoint2.Y = enddraw.X;
                        resizepoint2.Z = enddraw.Y;
                        ReDraw();
                    }
                    else
                        if (isDragging)
                        {
                            {
                                // foreach(MyShapes sh in shapes)
                                if (selectshapeindex != -1)
                                {
                                    MyShapes sh = (MyShapes)shapes[selectshapeindex];
                                    if (sh.isselected)
                                    {
                                        //  enddraw = LockGrid(ScalePoint(e.Location));
                                        if (sh is Polygon)
                                        {
                                            if (pointselectednumber != -1)
                                            {
                                                (sh as Polygon).points[pointselectednumber].Y = enddraw.X;
                                                (sh as Polygon).points[pointselectednumber].Z = enddraw.Y;
                                            }
                                        }
                                        else
                                            if (sh is Cylinder)
                                            {
                                                (sh as Cylinder).center.Y = DragP.Y + enddraw.X;
                                                (sh as Cylinder).center.Z = DragP.Z + enddraw.Y;
                                                //    break;
                                            }
                                            else
                                                if (sh is Sphere)
                                                {
                                                    (sh as Sphere).center.Y = DragP.Y + enddraw.X;
                                                    (sh as Sphere).center.Z = DragP.Z + enddraw.Y;
                                                    //          break;
                                                }
                                    }
                                }
                            }
                            ReDraw();
                        }

            }
            else
                if (shapedraw == 1)
                {
                    enddraw = LockGrid(ScalePoint(e.Location));
                    PanelsDraw(2);
                }
                else
                    if (e.Button == MouseButtons.Left)
                    {
                        enddraw = LockGrid(ScalePoint(e.Location));
                        PanelsDraw(2);
                    }
        }

        private void panelyz_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                xz.Dispose();
                yz.Dispose();
                xy.Dispose();
                xz = new Bitmap(bufxz);
                yz = new Bitmap(bufyz);
                xy = new Bitmap(bufxy);
                switch (shapedraw)
                {
                    case 0:
                        {
                            if (isResizing)
                            {
                                if (shapes[selectshapeindex] is Cylinder)
                                {
                                    MyShapes s = (MyShapes)shapes[selectshapeindex];
                                    Point point1 = new Point(resizepoint1.Y, resizepoint1.Z);
                                    Point point2 = new Point(resizepoint2.Y, resizepoint2.Z);
                                    shapes[selectshapeindex] = new Cylinder(point1, point2, Math.Abs((point2.X - point1.X) / 2), Math.Abs(point2.Y - point1.Y), 2);
                                    (shapes[selectshapeindex] as Cylinder).p1 = s.p1;
                                    (shapes[selectshapeindex] as Cylinder).b1 = s.b1;
                                    ((MyShapes)shapes[selectshapeindex]).isselected = true;
                                }
                                else
                                    if (shapes[selectshapeindex] is Sphere)
                                    {
                                        MyShapes s = (MyShapes)shapes[selectshapeindex];
                                        Point point1 = new Point(resizepoint1.Y, resizepoint1.Z);
                                        Point point2 = new Point(resizepoint2.Y, resizepoint2.Z);
                                        shapes[selectshapeindex] = new Sphere(point1, point2, Math.Abs((point2.Y - point1.Y) / 2), 2);
                                        (shapes[selectshapeindex] as Sphere).p1 = s.p1;
                                        (shapes[selectshapeindex] as Sphere).b1 = s.b1;
                                        ((MyShapes)shapes[selectshapeindex]).isselected = true;
                                    }
                                    else if (shapes[selectshapeindex] is Polygon)
                                    {
                                           if (((resizepoint2.X - resizepoint1.X) > 0) && ((rezpol.X - resizepoint1.X) > 0) && ((resizepoint2.Z - resizepoint1.Z) > 0) && ((rezpol.Z - resizepoint1.Z) > 0))
                                            for (int i = 0; i < (shapes[selectshapeindex] as Polygon).points.Count; i++)
                                            {
                                                Point3D p3d = (shapes[selectshapeindex] as Polygon).points[i];
                                                {

                                                    if ((p3d.Z == resizepoint1.Z) && (p3d.Y == resizepoint1.Y))
                                                    {
                                                    }
                                                    else
                                                        if (p3d.Z == resizepoint1.Z)
                                                            p3d.Y = Convert.ToInt32(Convert.ToDouble(p3d.Y) * Convert.ToDouble(Math.Abs(resizepoint2.Y - resizepoint1.Y)) / Convert.ToDouble(Math.Abs(rezpol.Y - resizepoint1.Y)));
                                                        else
                                                            if (p3d.Y == resizepoint1.Y)
                                                                p3d.Z = Convert.ToInt32(Convert.ToDouble(p3d.Z) * Convert.ToDouble(Math.Abs(resizepoint2.Z - resizepoint1.Z)) / Convert.ToDouble(Math.Abs(rezpol.Z - resizepoint1.Z)));
                                                            else
                                                            {
                                                                p3d.Y = Convert.ToInt32(Convert.ToDouble(p3d.Y) * Convert.ToDouble(Math.Abs(resizepoint2.Y - resizepoint1.Y)) / Convert.ToDouble(Math.Abs(rezpol.Y - resizepoint1.Y)));
                                                                p3d.Z = Convert.ToInt32(Convert.ToDouble(p3d.Z) * Convert.ToDouble(Math.Abs(resizepoint2.Z - resizepoint1.Z)) / Convert.ToDouble(Math.Abs(rezpol.Z - resizepoint1.Z)));
                                                            }
                                                }
                                                (shapes[selectshapeindex] as Polygon).points[i] = p3d;
                                            }
                                    }
                                //  selectshapeindex = -1;
                                isResizing = false;
                                documentischanged = true;
                                this.Cursor = this.DefaultCursor;
                                ReDraw();
                            }
                            else
                                if (isDragging)
                                {
                                    pointselectednumber = -1;
                                    //   selectshapeindex = -1;
                                    isDragging = false;
                                    documentischanged = true;
                                    this.Cursor = this.DefaultCursor;
                                }
                        } break;
                    case 2:
                        {
                            Cylinder.idcylinder++;
                            Cylinder p12 = new Cylinder(startdraw, enddraw, Math.Abs((enddraw.X - startdraw.X) / 2), Math.Abs(enddraw.Y - startdraw.Y), 2);
                            p12.p1 = new MyPen(linepen);
                            p12.b1 = new MyBrush(fillbrush);
                            shapes.Add(p12);
                            documentischanged = true;
                        } break;
                    case 3:
                        {
                            Sphere.idsphere++;
                            Sphere p123 = new Sphere(startdraw, enddraw, Math.Abs((enddraw.Y - startdraw.Y) / 2), 2);
                            p123.p1 = new MyPen(linepen);
                            p123.b1 = new MyBrush(fillbrush);
                            shapes.Add(p123);
                            documentischanged = true;
                        } break;
                }
            }
        }

        private void panelyz_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                if (shapedraw == 1)
                {

                    {
                        Point g1 = LockGrid(ScalePoint(e.Location));
                        linepoints.Add(new Point3D(g1.X, g1.X, g1.Y));
                        linestartdraw = true;
                    }
                }
        }

        private void panelyz_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                if (shapedraw == 1)
                {
                    if (linepoints.Count > 0)
                    {
                        Polygon.idline++;
                        Polygon pol = new Polygon(linepen, fillbrush, linepoints);
                        shapes.Add(pol);
                        documentischanged = true;
                    }
                    linestartdraw = false;
                    linepoints.Clear();
                }
        }

        private void panelyz_MouseLeave(object sender, EventArgs e)
        {
            isDragging = false;
            xzpanel.DrawImage((Image)xz, 0, 0);
            yzpanel.DrawImage((Image)yz, 0, 0);
            xypanel.DrawImage((Image)xy, 0, 0);
        }

        private void panelyz_Paint(object sender, PaintEventArgs e)
        {
            yzpanel.DrawImage(yz, 0, 0);
        }

        #endregion

        #region PanelXY

        private void panelxy_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                startdraw = LockGrid(ScalePoint(e.Location));
                if (shapedraw == 0)
                {
                    startdraw = ScalePoint(e.Location);
                    isResizing = false;
                    isDragging = false;
                    if ((Math.Abs(startdraw.X - resizepoint2.X - 7) <= 3) && (Math.Abs(startdraw.Y - resizepoint2.Y - 7) <= 3) && selectshape)
                    {
                        this.Cursor = Cursors.SizeNWSE;
                        isResizing = true;
                        selectshape = true;
                        rezpol = new Point3D(resizepoint2.X, resizepoint2.Y, resizepoint2.Z);
                        ReDraw();
                        return;
                    }
                    else
                    {
                        //    selectall = false;
                        selectshape = false;
                        for (int l = shapes.Count - 1; l >= 0; l--)
                        {
                            MyShapes s = (MyShapes)shapes[l];
                            if (s.isxy(startdraw))
                            {
                                s.isselected = true;
                                selectshape = true;
                                isDragging = true;
                                this.Cursor = Cursors.SizeAll;
                                linecolocrbutton.BackColor = s.p1.pen_color;
                                fillcolorbutton.BackColor = s.b1.color1;
                                if (s is Polygon)
                                {
                                    this.Cursor = this.DefaultCursor;
                                    {
                                        if ((pointselectednumber = (s as Polygon).inxypoint(startdraw)) != -1)
                                        {
                                            DragP.X = (s as Polygon).points[pointselectednumber].X;
                                            DragP.Y = (s as Polygon).points[pointselectednumber].Y;
                                            this.Cursor = Cursors.SizeAll;
                                        }
                                    }
                                    selectshapeindex = l;

                                }
                                else
                                    if (s is Cylinder)
                                    {
                                        DragP.X = (s as Cylinder).center.X - startdraw.X;
                                        DragP.Y = (s as Cylinder).center.Y - startdraw.Y;
                                        selectshapeindex = l;
                                    }
                                    else
                                        if (s is Sphere)
                                        {
                                            DragP.X = (s as Sphere).center.X - startdraw.X;
                                            DragP.Y = (s as Sphere).center.Y - startdraw.Y;
                                            selectshapeindex = l;
                                        }
                                startdraw = LockGrid(ScalePoint(e.Location));
                                toolStripStatusLabel4.Text = s.name;
                                deleteselected.Enabled = true;
                                sizeOptions.Enabled = true;
                                break;
                            }
                        }


                        if (!selectshape)
                        {
                            ClearSelectedShape();
                            selectshape = false;
                            deleteselected.Enabled = false;
                            sizeOptions.Enabled = false;
                            selectshapeindex = -1;
                            linecolocrbutton.BackColor = linepen.Color;
                            fillcolorbutton.BackColor = (new MyBrush(fillbrush)).color1;
                        }
                    }
                    ReDraw();
                }
            }
            // Context menu
            else if (e.Button == MouseButtons.Right)
            {
                if (shapedraw == 0)
                {
                    selectshape = false;
                    for (int l = shapes.Count - 1; l >= 0; l--)
                    {
                        MyShapes s = (MyShapes)shapes[l];
                        if (s.isxy(ScalePoint(e.Location)))
                        {
                            s.isselected = true;
                            selectshape = true;
                            linecolocrbutton.BackColor = s.p1.pen_color;
                            fillcolorbutton.BackColor = s.b1.color1;
                            if (s is Polygon)
                            {
                                contextmenufillstyle.Visible = false;
                                contextmenusizeoptions.Visible = false;
                                selectshapeindex = l;

                            }
                            else
                                if ((s is Cylinder) || (s is Sphere))
                                {
                                    contextmenufillstyle.Visible = true;
                                    contextmenusizeoptions.Visible = true;
                                    selectshapeindex = l;
                                }
                            contextmenudeleteselected.Visible = true;
                            contextmenubaskstyle.Visible = false;
                            toolStripStatusLabel4.Text = s.name;
                            deleteselected.Enabled = true;
                            sizeOptions.Enabled = true;
                            break;
                        }
                    }
                    if (!selectshape)
                    {
                        contextmenufillstyle.Visible = false;
                        contextmenusizeoptions.Visible = false;
                        contextmenusizeoptions.Visible = false;
                        contextmenudeleteselected.Visible = false;
                        contextmenubaskstyle.Visible = true;
                        contextmenulinestyle.Visible = false;
                        contextmenu.Visible = false;

                        ClearSelectedShape();
                        selectshape = false;
                        deleteselected.Enabled = false;
                        sizeOptions.Enabled = false;
                        selectshapeindex = -1;
                        linecolocrbutton.BackColor = linepen.Color;
                        fillcolorbutton.BackColor = (new MyBrush(fillbrush)).color1;
                    }
                    ReDraw();
                }
                else
                {
                    contextmenufillstyle.Visible = false;
                    contextmenusizeoptions.Visible = false;
                    contextmenusizeoptions.Visible = false;
                    contextmenudeleteselected.Visible = false;
                    contextmenubaskstyle.Visible = false;
                    contextmenulinestyle.Visible = false;
                }
            }
        }

        private void panelxy_MouseMove(object sender, MouseEventArgs e)
        {
            enddraw = LockGrid(ScalePoint(e.Location));
            if (shapedraw == 0)
            {
                if (e.Button == MouseButtons.Left)
                    if (isResizing)
                    {
                        enddraw = ScalePoint(e.Location);
                        resizepoint2.X = enddraw.X;
                        resizepoint2.Y = enddraw.Y;
                        ReDraw();
                    }
                    else
                        if (isDragging)
                        {
                            {
                                if (selectshapeindex != -1)
                                {
                                    MyShapes sh = (MyShapes)shapes[selectshapeindex];
                                    if (sh.isselected)
                                    {
                                        if (sh is Polygon)
                                        {
                                            if (pointselectednumber != -1)
                                            {
                                                (sh as Polygon).points[pointselectednumber].X = enddraw.X;
                                                (sh as Polygon).points[pointselectednumber].Y = enddraw.Y;
                                            }
                                        }
                                        else
                                            if (sh is Cylinder)
                                            {
                                                (sh as Cylinder).center.X = DragP.X + enddraw.X;
                                                (sh as Cylinder).center.Y = DragP.Y + enddraw.Y;
                                                //    break;
                                            }
                                            else
                                                if (sh is Sphere)
                                                {
                                                    (sh as Sphere).center.X = DragP.X + enddraw.X;
                                                    (sh as Sphere).center.Y = DragP.Y + enddraw.Y;
                                                    //          break;
                                                }
                                    }
                                }
                            }
                            ReDraw();
                        }

            }
            else
                if (shapedraw == 1)
                {
                    enddraw = LockGrid(ScalePoint(e.Location));
                    PanelsDraw(3);
                }
                else
                    if (e.Button == MouseButtons.Left)
                    {
                        enddraw = LockGrid(ScalePoint(e.Location));
                        PanelsDraw(3);
                    }
        }

        private void panelxy_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                xz.Dispose();
                yz.Dispose();
                xy.Dispose();
                xz = new Bitmap(bufxz);
                yz = new Bitmap(bufyz);
                xy = new Bitmap(bufxy);
                switch (shapedraw)
                {
                    case 0:
                        {
                            if (isResizing)
                            {
                                if (shapes[selectshapeindex] is Cylinder)
                                {
                                    MyShapes s = (MyShapes)shapes[selectshapeindex];
                                    Point point1 = new Point(resizepoint1.X, resizepoint1.Y);
                                    Point point2 = new Point(resizepoint2.X, resizepoint2.Y);
                                    shapes[selectshapeindex] = new Cylinder(point1, point2, Math.Abs((point2.X - point1.X) / 2), Math.Abs(point2.Y - point1.Y), 3);
                                    (shapes[selectshapeindex] as Cylinder).p1 = s.p1;
                                    (shapes[selectshapeindex] as Cylinder).b1 = s.b1;
                                    ((MyShapes)shapes[selectshapeindex]).isselected = true;
                                }
                                else
                                    if (shapes[selectshapeindex] is Sphere)
                                    {
                                        MyShapes s = (MyShapes)shapes[selectshapeindex];
                                        Point point1 = new Point(resizepoint1.X, resizepoint1.Y);
                                        Point point2 = new Point(resizepoint2.X, resizepoint2.Y);
                                        shapes[selectshapeindex] = new Sphere(point1, point2, Math.Abs((point2.Y - point1.Y) / 2), 3);
                                        (shapes[selectshapeindex] as Sphere).p1 = s.p1;
                                        (shapes[selectshapeindex] as Sphere).b1 = s.b1;
                                        ((MyShapes)shapes[selectshapeindex]).isselected = true;
                                    }
                                    else if (shapes[selectshapeindex] is Polygon)
                                    {
                                       
                                        if (((resizepoint2.X - resizepoint1.X) > 0) && ((rezpol.X - resizepoint1.X) > 0) && ((resizepoint2.Y - resizepoint1.Y) > 0) && ((rezpol.Y - resizepoint1.Y) > 0))
                                            for (int i = 0; i < (shapes[selectshapeindex] as Polygon).points.Count; i++)
                                            {
                                                Point3D p3d = (shapes[selectshapeindex] as Polygon).points[i];
                                                {

                                                    if ((p3d.Y == resizepoint1.Y) && (p3d.X == resizepoint1.X))
                                                    {
                                                    }
                                                    else
                                                        if (p3d.Y == resizepoint1.Y)
                                                            p3d.X = Convert.ToInt32(Convert.ToDouble(p3d.X) * Convert.ToDouble(Math.Abs(resizepoint2.X - resizepoint1.X)) / Convert.ToDouble(Math.Abs(rezpol.X - resizepoint1.X)));
                                                        else
                                                            if (p3d.X == resizepoint1.X)
                                                                p3d.Y = Convert.ToInt32(Convert.ToDouble(p3d.Y) * Convert.ToDouble(Math.Abs(resizepoint2.Y - resizepoint1.Y)) / Convert.ToDouble(Math.Abs(rezpol.Y - resizepoint1.Y)));
                                                            else
                                                            {
                                                                p3d.X = Convert.ToInt32(Convert.ToDouble(p3d.X) * Convert.ToDouble(Math.Abs(resizepoint2.X - resizepoint1.X)) / Convert.ToDouble(Math.Abs(rezpol.X - resizepoint1.X)));
                                                                p3d.Y = Convert.ToInt32(Convert.ToDouble(p3d.Y) * Convert.ToDouble(Math.Abs(resizepoint2.Y - resizepoint1.Y)) / Convert.ToDouble(Math.Abs(rezpol.Y - resizepoint1.Y)));
                                                            }
                                                }
                                                (shapes[selectshapeindex] as Polygon).points[i] = p3d;
                                            }
                                    }
                                //  selectshapeindex = -1;
                                isResizing = false;
                                documentischanged = true;
                                this.Cursor = this.DefaultCursor;
                                ReDraw();
                            }
                            else
                                if (isDragging)
                                {
                                    pointselectednumber = -1;
                                    //   selectshapeindex = -1;
                                    isDragging = false;
                                    documentischanged = true;
                                    this.Cursor = this.DefaultCursor;
                                }
                        } break;
                    case 2:
                        {
                            Cylinder.idcylinder++;
                            Cylinder p12 = new Cylinder(startdraw, enddraw, Math.Abs((enddraw.X - startdraw.X) / 2), Math.Abs(enddraw.Y - startdraw.Y), 3);
                            p12.p1 = new MyPen(linepen);
                            p12.b1 = new MyBrush(fillbrush);
                            shapes.Add(p12);
                            documentischanged = true;
                        } break;
                    case 3:
                        {
                            Sphere.idsphere++;
                            Sphere p123 = new Sphere(startdraw, enddraw, Math.Abs((enddraw.Y - startdraw.Y) / 2), 3);
                            p123.p1 = new MyPen(linepen);
                            p123.b1 = new MyBrush(fillbrush);
                            shapes.Add(p123);
                            documentischanged = true;
                        } break;
                }
            }
        }

        private void panelxy_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                if (shapedraw == 1)
                {

                    {
                        Point g1 = LockGrid(ScalePoint(e.Location));
                        linepoints.Add(new Point3D(g1.X, g1.Y, g1.X));
                        linestartdraw = true;
                    }
                }
        }

        private void panelxy_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                if (shapedraw == 1)
                {
                    if (linepoints.Count > 0)
                    {
                        Polygon.idline++;
                        Polygon pol = new Polygon(linepen, fillbrush, linepoints);
                        shapes.Add(pol);
                        documentischanged = true;
                    }
                    linestartdraw = false;
                    linepoints.Clear();
                }
        }

        private void panelxy_MouseLeave(object sender, EventArgs e)
        {
            isDragging = false;
            xzpanel.DrawImage((Image)xz, 0, 0);
            yzpanel.DrawImage((Image)yz, 0, 0);
            xypanel.DrawImage((Image)xy, 0, 0);
        }

        private void panelxy_Paint(object sender, PaintEventArgs e)
        {
            xypanel.DrawImage(xy, 0, 0);
        }

        #endregion

        #region PanelsDraw

        private void PanelsDraw(int onpaneldraw)
        {
            bufxz.Dispose();
            bufyz.Dispose();
            bufxy.Dispose();

            bufxz =  new Bitmap(xz);
            bufyz =  new Bitmap(yz);
            bufxy =  new Bitmap(xy);

            try
            {
                Program.xzbuff.Dispose();
                Program.yzbuff.Dispose();
                Program.xybuff.Dispose();

                Program.xzbuff = Graphics.FromImage((Image)bufxz);
                Program.yzbuff = Graphics.FromImage((Image)bufyz);
                Program.xybuff = Graphics.FromImage((Image)bufxy);

                Program.xzbuff.ScaleTransform(Program.Zoom, Program.Zoom);
                Program.yzbuff.ScaleTransform(Program.Zoom, Program.Zoom);
                Program.xybuff.ScaleTransform(Program.Zoom, Program.Zoom);

                Program.xzbuff.SmoothingMode = SmoothingMode.HighQuality;
                Program.yzbuff.SmoothingMode = SmoothingMode.HighQuality;
                Program.xybuff.SmoothingMode = SmoothingMode.HighQuality;
                switch (shapedraw)
                {
                    
                    case 1:
                        {                      
                            if (linestartdraw)
                            {
                                Polygon pol = new Polygon(linepen, fillbrush, linepoints);
                                pol.Draw();
                                if (onpaneldraw == 1)
                                {
                                    Program.xzbuff.DrawLine(linepen, new Point((linepoints[linepoints.Count - 1]).X, (linepoints[linepoints.Count - 1]).Z), enddraw);
                                    Program.yzbuff.DrawLine(linepen, new Point((linepoints[linepoints.Count - 1]).Y, (linepoints[linepoints.Count - 1]).Z), enddraw);
                                    Program.xybuff.DrawLine(linepen, (linepoints[linepoints.Count - 1]).X, (linepoints[linepoints.Count - 1]).Y, enddraw.X, enddraw.X);
                                }
                                else if (onpaneldraw == 2)
                                {
                                    Program.xzbuff.DrawLine(linepen, new Point((linepoints[linepoints.Count - 1]).X, (linepoints[linepoints.Count - 1]).Z), enddraw);
                                    Program.yzbuff.DrawLine(linepen, new Point((linepoints[linepoints.Count - 1]).Y, (linepoints[linepoints.Count - 1]).Z), enddraw);
                                    Program.xybuff.DrawLine(linepen, (linepoints[linepoints.Count - 1]).X, (linepoints[linepoints.Count - 1]).Y, enddraw.X, enddraw.X);
                                }
                                else
                                {
                                    Program.xzbuff.DrawLine(linepen, (linepoints[linepoints.Count - 1]).X, (linepoints[linepoints.Count - 1]).Z, enddraw.X, enddraw.X);
                                    Program.yzbuff.DrawLine(linepen, (linepoints[linepoints.Count - 1]).Y, (linepoints[linepoints.Count - 1]).Z, enddraw.Y, enddraw.X);
                                    Program.xybuff.DrawLine(linepen, (linepoints[linepoints.Count - 1]).X, (linepoints[linepoints.Count - 1]).Y, enddraw.X, enddraw.Y);
                                }

                            }
                            else
                            {
                                if (onpaneldraw == 1)
                                {
                                    Program.xzbuff.DrawEllipse(linepen, (enddraw.X - 2.5f), (enddraw.Y - 2.5f), 5f, 5f);
                                    Program.xzbuff.FillEllipse(fillbrush, (enddraw.X - 2.5f), (enddraw.Y - 2.5f), 5f, 5f);
                                }
                                else if (onpaneldraw == 2)
                                {
                                    Program.yzbuff.DrawEllipse(linepen, (enddraw.X - 2.5f), (enddraw.Y - 2.5f), 5f, 5f);
                                    Program.yzbuff.FillEllipse(fillbrush, (enddraw.X - 2.5f), (enddraw.Y - 2.5f), 5f, 5f);
                                }
                                else if (onpaneldraw == 3)
                                {
                                    Program.xybuff.DrawEllipse(linepen, (enddraw.X - 2.5f), (enddraw.Y - 2.5f), 5f, 5f);
                                    Program.xybuff.FillEllipse(fillbrush, (enddraw.X - 2.5f), (enddraw.Y - 2.5f), 5f, 5f);
                                }
                            }
                        } break;
                    case 2:
                        {
                                Cylinder cyl = new Cylinder(startdraw, enddraw, Math.Abs((enddraw.X - startdraw.X) / 2), Math.Abs(enddraw.Y - startdraw.Y), onpaneldraw);
                                cyl.p1 = new MyPen(linepen);
                                cyl.b1 = new MyBrush(fillbrush);
                                cyl.Draw();
                            
                        } break;
                    case 3:
                        {
                            Sphere sp = new Sphere(startdraw, enddraw, Math.Abs((enddraw.Y - startdraw.Y) / 2), onpaneldraw);
                            sp.p1 = new MyPen(linepen);
                            sp.b1 = new MyBrush(fillbrush);
                            sp.Draw();
                        } break;
                }

                
         
                xzpanel.DrawImage((Image)bufxz, 0, 0);
                yzpanel.DrawImage((Image)bufyz, 0, 0);
                xypanel.DrawImage((Image)bufxy, 0, 0);
            }
           catch (Exception ex)
            {
                MessageBox.Show("Error in PanelsDraw " + ex.Message);
            }
        }

        #endregion

        private void createToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel4.Text = "Wait commands";
        }

        private void helpToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel4.Text = "I don't help you)";
        }

        private void linecolocrbutton_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel4.Text = "Choose Shape line color";
        }

        private void panelxz_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel4.Text = "Drawing!";
        }

        private void fillcolorbutton_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel4.Text = "Choose Shape fill color";
        }

     }

    #endregion

    #region Мой классы фигур

    #region Help

    [Serializable]
    public class Point3D
    {
        public int X;
        public int Y;
        public int Z;
        public Point3D() { X = 0; Y = 0; Z = 0; }
        public Point3D(int x, int y, int z) { X = x; Y = y; Z = z; }
        ~Point3D() { }
        
    };

    [Serializable]
    public class MyPen
    {
        private float pen_width;
        public Color pen_color;
        private DashStyle pen_dash;
        public MyPen(Pen pen1) { pen_width = pen1.Width; pen_color = pen1.Color; pen_dash = pen1.DashStyle; }
        public Pen getPen() { Pen pen1 = new Pen(pen_color, pen_width); pen1.DashStyle = pen_dash; return pen1; }
        ~MyPen() { }
    }

    [Serializable]
    public class MyBrush
    {
        byte index;
        public Color color1;
        Color color2;
        HatchStyle hatchstyle;
        public MyBrush(Brush brush)
        {
            if (brush is SolidBrush) { index = 1; color1 = ((brush as SolidBrush).Color); }
            if (brush is LinearGradientBrush) { index = 2; color1 = ((brush as LinearGradientBrush).LinearColors[0]); color2 = ((brush as LinearGradientBrush).LinearColors[1]); }
            if (brush is HatchBrush)
            {
                index = 3; hatchstyle = ((brush as HatchBrush).HatchStyle);
                color1 = (brush as HatchBrush).ForegroundColor; color2 = ((brush as HatchBrush).BackgroundColor);
            }
        }

        public Brush getbrush()
        {
            if (index == 1)
            {
                return new SolidBrush(color1);
            }
            else
                if (index == 2)
                {
                    return new LinearGradientBrush(new Point(0, 0), new Point(300,300), color1, color2);
                }
                else
                    if (index == 3)
                    {
                        return new HatchBrush(hatchstyle, color1, color2);
                    }
            return null;
        }

        ~MyBrush() { }
    }

    #endregion

    #region MyShapes

    [Serializable]
    public abstract class MyShapes
    {
        public bool isselected;
        public String name;
        public MyPen p1;
        public MyBrush b1;
        public abstract void Draw();// { }
        public abstract bool isxz(Point k);
        public abstract bool isyz(Point k);
        public abstract bool isxy(Point k);
        ~MyShapes() { }
    };
    #endregion

    #region Polyline

    [Serializable]
    public class Polygon : MyShapes
    {
        int selectedpoint;
        public static int idline;
        public List<Point3D> points;
        public Polygon(Pen p, Brush b)
        {
            p1 = new MyPen(p);
            b1 = new MyBrush(b);
            selectedpoint = -1;
            points = new List<Point3D>();
            idline++;
            name = "Polyline №" + idline.ToString();
        }


        public Polygon(Pen p, Brush b, List<Point3D> poly)
        {
            selectedpoint = -1;
            points = new List<Point3D>(poly);
            p1 = new MyPen(p);
            b1 = new MyBrush(b);
            name = "Polyline №" + idline.ToString();
        }

        ~Polygon() { }

        public override void Draw()
        {
            Program.xzbuff.PageScale = Program.Zoom;
            Program.yzbuff.PageScale = Program.Zoom;
            Program.xybuff.PageScale = Program.Zoom;
            Pen p = p1.getPen();
            GraphicsPath p12 = new GraphicsPath();
            if (isselected) p = new Pen(p1.getPen().Color, p1.getPen().Width + 2);
            Brush b;
            b = b1.getbrush();
            if (points.Count>1)
            for (int i = 0; i < points.Count - 1; i++)
            {
                b = b1.getbrush();
                if (selectedpoint == i) b = new SolidBrush(Color.Green);
                Program.xzbuff.DrawLine(p,points[i].X,points[i].Z,points[i+1].X,points[i+1].Z);
                Program.xzbuff.DrawEllipse(p, points[i].X - 2.5f, points[i].Z - 2.5f, 5.0f, 5.0f);
                Program.xzbuff.FillEllipse(b, points[i].X - 2.5f, points[i].Z - 2.5f, 5.0f, 5.0f);
                Program.yzbuff.DrawLine(p, points[i].Y, points[i].Z, points[i + 1].Y, points[i + 1].Z);
                Program.yzbuff.DrawEllipse(p, points[i].Y - 2.5f, points[i].Z - 2.5f, 5.0f, 5.0f);
                Program.yzbuff.FillEllipse(b, points[i].Y - 2.5f, points[i].Z - 2.5f, 5.0f, 5.0f);
                Program.xybuff.DrawLine(p, points[i].X, points[i].Y, points[i + 1].X, points[i + 1].Y);
                Program.xybuff.DrawEllipse(p, points[i].X - 2.5f, points[i].Y - 2.5f, 5.0f, 5.0f);
                Program.xybuff.FillEllipse(b, points[i].X - 2.5f, points[i].Y - 2.5f, 5.0f, 5.0f);
            }
            if (points.Count != 0)
            {
                if (selectedpoint == (points.Count - 1)) b = new SolidBrush(Color.Green); else b = b1.getbrush();
                Program.xzbuff.DrawEllipse(p, (points[points.Count - 1].X - 2.5f), (points[points.Count - 1].Z - 2.5f), 5, 5);
                Program.xzbuff.FillEllipse(b, (points[points.Count - 1].X - 2.5f), (points[points.Count - 1].Z - 2.5f), 5, 5);
                Program.yzbuff.DrawEllipse(p, (points[points.Count - 1].Y - 2.5f), (points[points.Count - 1].Z - 2.5f), 5, 5);
                Program.yzbuff.FillEllipse(b, (points[points.Count - 1].Y - 2.5f), (points[points.Count - 1].Z - 2.5f), 5, 5);
                Program.xybuff.DrawEllipse(p, (points[points.Count - 1].X - 2.5f), (points[points.Count - 1].Y - 2.5f), 5, 5);
                Program.xybuff.FillEllipse(b, (points[points.Count - 1].X - 2.5f), (points[points.Count - 1].Y - 2.5f), 5, 5);
               
            };
        }

       

        #region Lineselecting
        public override bool isxz(Point P)
        {
            GraphicsPath path = new GraphicsPath();
            if (points.Count >= 2)
            for (int i = 0; i < points.Count - 1; i++)
            {
                path.AddEllipse(points[i].X - 3, points[i].Z - 3, 6, 6);
                path.AddLine(points[i].X, points[i].Z, points[i+1].X, points[i+1].Z);
            } 
            path.AddEllipse(points[points.Count-1].X -3, points[points.Count-1].Z - 3, 6, 6);
            return (path.IsOutlineVisible(P,new Pen(Color.White,5)));
        }

        public override bool isxy(Point P)
        {
            GraphicsPath path = new GraphicsPath();
            if (points.Count >= 2)
                for (int i = 0; i < points.Count - 1; i++)
                {
                    path.AddEllipse(points[i].X - 3, points[i].Y - 3, 6, 6);
                    path.AddLine(points[i].X, points[i].Y, points[i + 1].Y, points[i + 1].Z);
                }
            else
                path.AddEllipse(points[points.Count - 1].X - 3, points[points.Count - 1].Y - 3, 6, 6);
            return (path.IsOutlineVisible(P, new Pen(Color.White, 5)));
        }

        public override bool isyz(Point P)
        {
            GraphicsPath path = new GraphicsPath();
            if (points.Count >= 2)
                for (int i = 0; i < points.Count - 1; i++)
                {
                    path.AddEllipse(points[i].Y - 3, points[i].Z - 3, 6, 6);
                    path.AddLine(points[i].Y, points[i].Z, points[i + 1].X, points[i + 1].Z);
                }
            path.AddEllipse(points[points.Count - 1].Y - 3, points[points.Count - 1].Z - 3, 6, 6);
            return (path.IsOutlineVisible(P, new Pen(Color.White, 5)));
        }

        public int inxzpoint(Point P)
        {
            for (int i = 0; i < points.Count; i++)
            {
                if ((Math.Abs((points[i].X - P.X)) < 5) && (Math.Abs((points[i].Z - P.Y)) < 5))
                    return i;
            } return -1;
        }

        public int inyzpoint(Point P)
        {
            for (int i = 0; i < points.Count; i++)
            {
                if ((Math.Abs((points[i].Y - P.X)) < 5) && (Math.Abs((points[i].Z - P.Y)) < 5))
                    return i;
            } return -1;
        }

        public int inxypoint(Point P)
        {
            for (int i = 0; i < points.Count; i++)
            {
                if ((Math.Abs((points[i].X - P.X)) < 5) && (Math.Abs((points[i].Y - P.Y)) < 5))
                    return i;
            } return -1;
        }
        #endregion
    };

    #endregion

    #region Cylinder

    [Serializable]
    public class Cylinder : MyShapes
    {
        public static int idcylinder;
        public Point3D center;
        public int radius;
        public int height;
        public Cylinder(Point start,Point end, int rad, int he, int p)
        {
            center = new Point3D();
            radius = rad;
            height = he;
            switch (p)
            {
                case 1:
                    {
                        center.X = (start.X + end.X) / 2;
                        center.Y = (start.X + end.X) / 2;
                        if (start.Y > end.Y)
                            center.Z = start.Y;
                        else center.Z = end.Y;
                    } break;
                case 2:
                    {
                        center.X = (start.X + end.X) / 2;
                        center.Y = (start.X + end.X) / 2;
                        if (start.Y > end.Y)
                            center.Z = start.Y;
                        else center.Z = end.Y;
                    } break;
                    
                case 3:
                    {
                        if (start.X < end.X)
                            center.X  = start.X + radius;
                        else
                            center.X = start.X - radius;
                        if (start.Y < end.Y)
                            center.Y = start.Y + radius;
                        else
                            center.Y = start.Y - radius;
                        center.Z = start.X;
                        height = 2 * rad;
                    } break;
            }
            
            name = "Cylinder №" + idcylinder.ToString();
        }

        ~Cylinder() { }
        
        public override void Draw()
        {
            Pen p2 = p1.getPen();
            Brush b2 = b1.getbrush();
            Program.xzbuff.FillRectangle(b2, center.X - radius, center.Z - height, 2 * radius, height);
            Program.yzbuff.FillRectangle(b2, center.Y - radius, center.Z - height, 2 * radius, height);
            Program.xybuff.FillEllipse(b2, center.X - radius, center.Y - radius, 2 * radius, 2 * radius);
            if (isselected)
            {
                Pen p = new Pen(Color.Blue, p1.getPen().Width);
                Program.xzbuff.DrawRectangle(p, center.X - radius, center.Z - height, 2 * radius, height);
                Program.yzbuff.DrawRectangle(p, center.Y - radius, center.Z - height, 2 * radius, height);
                Program.xybuff.DrawEllipse(p, center.X - radius, center.Y - radius, 2 * radius, 2 * radius);
                p.Dispose();
                
            }
            else
            {
                Program.xzbuff.DrawRectangle(p1.getPen(), center.X - radius, center.Z - height, 2 * radius, height);
                Program.yzbuff.DrawRectangle(p1.getPen(), center.Y - radius, center.Z - height, 2 * radius, height);
                Program.xybuff.DrawEllipse(p1.getPen(), center.X - radius, center.Y - radius, 2 * radius, 2 * radius);
            }
            p2.Dispose();
            b2.Dispose();
        }

        public override bool isxz(Point P)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddRectangle(new Rectangle(center.X-radius,center.Z-height,2*radius,height));
            return path.IsVisible(P);
        }
        
        public override bool isyz(Point P)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddRectangle(new Rectangle(center.Y-radius,center.Z-height,2*radius,height));
            return path.IsVisible(P);
        }

        public override bool isxy(Point P)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(new Rectangle(center.X - radius, center.Y - radius, 2 * radius, 2 * radius));
            return path.IsVisible(P);
        }

    };

    #endregion

    #region Sphere

    [Serializable]
    public class Sphere : MyShapes
    {
        public Point3D center;
        public int radius;
        public static int idsphere;

        public Sphere(Point start,Point end, int rad, int p)
        {
            center = new Point3D();
            radius = rad;
            switch (p)
            {
                case 1:
                    {
                        if (start.X < end.X)
                        center.X = center.Y = start.X + radius;
                        else
                            center.X = center.Y = start.X -radius;
                        center.Z = (start.Y + end.Y) / 2;
                    } break;
                case 2:
                    {
                        if (start.X < end.X)
                            center.X = center.Y = start.X + radius;
                        else
                            center.X = center.Y = start.X - radius;
                        center.Z = (start.Y + end.Y) / 2;
                    } break;
                    
                case 3:
                    {
                        if (start.X < end.X)
                            center.X = center.Z = start.X + radius;
                        else
                            center.X = center.Z = start.X - radius;
                        center.Y = (start.Y + end.Y) / 2;
                    } break;
            }
            name = "Sphere №" + idsphere.ToString();
        }

        ~Sphere() { }
        
        public override void Draw()
        {
            Program.xzbuff.FillEllipse(b1.getbrush(), center.X - radius, center.Z - radius, 2 * radius, 2 * radius);
            Program.yzbuff.FillEllipse(b1.getbrush(), center.Y - radius, center.Z - radius, 2 * radius, 2 * radius);
            Program.xybuff.FillEllipse(b1.getbrush(), center.X - radius, center.Y - radius, 2 * radius, 2 * radius);          
            if (isselected)
            {
                using ( Pen p = new Pen(Color.Blue, p1.getPen().Width)) 
                {
                    Program.xzbuff.DrawEllipse(p, center.X - radius, center.Z - radius, 2 * radius, 2 * radius);
                    Program.yzbuff.DrawEllipse(p, center.Y - radius, center.Z - radius, 2 * radius, 2 * radius);
                    Program.xybuff.DrawEllipse(p, center.X - radius, center.Y - radius, 2 * radius, 2 * radius);
                }
            }
            else
            {
                Program.xzbuff.DrawEllipse(p1.getPen(), center.X - radius, center.Z - radius, 2 * radius, 2 * radius);
                Program.yzbuff.DrawEllipse(p1.getPen(), center.Y - radius, center.Z - radius, 2 * radius, 2 * radius);
                Program.xybuff.DrawEllipse(p1.getPen(), center.X - radius, center.Y - radius, 2 * radius, 2 * radius);
            }
        }

        public override bool isxz(Point P)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(new Rectangle(center.X - radius, center.Z - radius, 2 * radius, 2 * radius));
            return path.IsVisible(P);
        }

        public override bool isyz(Point P)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(new Rectangle(center.Y - radius, center.Z - radius, 2 * radius, 2 * radius));
            return path.IsVisible(P);
        }

        public override bool isxy(Point P)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(new Rectangle(center.X - radius, center.Y - radius, 2 * radius, 2 * radius));
            return path.IsVisible(P);
        }

    };

    #endregion

    #endregion

}
