using System.Drawing;
namespace _01_Yovchev_208
{
    partial class MainWindow
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoonInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fillStyleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundStyleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.showhideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.figuresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cylinderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sphereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.createToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.selectStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.polygonStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.cylindertoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.spheretoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.zoominStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.zoomoutStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.showhidegridStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.deleteselected = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelxy = new System.Windows.Forms.Panel();
            this.contextmenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextmenudeleteselected = new System.Windows.Forms.ToolStripMenuItem();
            this.contextmenulinestyle = new System.Windows.Forms.ToolStripMenuItem();
            this.contextmenufillstyle = new System.Windows.Forms.ToolStripMenuItem();
            this.contextmenusizeoptions = new System.Windows.Forms.ToolStripMenuItem();
            this.contextmenubaskstyle = new System.Windows.Forms.ToolStripMenuItem();
            this.panelyz = new System.Windows.Forms.Panel();
            this.panelxz = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.linecolocrbutton = new System.Windows.Forms.Button();
            this.fillcolorbutton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.contextmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.figuresToolStripMenuItem,
            this.helpToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveasToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // createToolStripMenuItem
            // 
            resources.ApplyResources(this.createToolStripMenuItem, "createToolStripMenuItem");
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            this.createToolStripMenuItem.MouseHover += new System.EventHandler(this.createToolStripMenuItem_MouseHover);
            // 
            // openToolStripMenuItem
            // 
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            this.openToolStripMenuItem.MouseHover += new System.EventHandler(this.createToolStripMenuItem_MouseHover);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            resources.ApplyResources(this.toolStripSeparator, "toolStripSeparator");
            // 
            // saveToolStripMenuItem
            // 
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            this.saveToolStripMenuItem.MouseHover += new System.EventHandler(this.createToolStripMenuItem_MouseHover);
            // 
            // saveasToolStripMenuItem
            // 
            resources.ApplyResources(this.saveasToolStripMenuItem, "saveasToolStripMenuItem");
            this.saveasToolStripMenuItem.Name = "saveasToolStripMenuItem";
            this.saveasToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            this.saveasToolStripMenuItem.MouseHover += new System.EventHandler(this.createToolStripMenuItem_MouseHover);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            this.exitToolStripMenuItem.MouseHover += new System.EventHandler(this.createToolStripMenuItem_MouseHover);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoonInToolStripMenuItem,
            this.zoomOutToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectallToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
            this.editToolStripMenuItem.MouseHover += new System.EventHandler(this.createToolStripMenuItem_MouseHover);
            // 
            // zoonInToolStripMenuItem
            // 
            resources.ApplyResources(this.zoonInToolStripMenuItem, "zoonInToolStripMenuItem");
            this.zoonInToolStripMenuItem.Name = "zoonInToolStripMenuItem";
            this.zoonInToolStripMenuItem.Click += new System.EventHandler(this.zoonInToolStripMenuItem_Click);
            this.zoonInToolStripMenuItem.MouseHover += new System.EventHandler(this.createToolStripMenuItem_MouseHover);
            // 
            // zoomOutToolStripMenuItem
            // 
            resources.ApplyResources(this.zoomOutToolStripMenuItem, "zoomOutToolStripMenuItem");
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.Click += new System.EventHandler(this.zoomOutToolStripMenuItem_Click);
            this.zoomOutToolStripMenuItem.MouseHover += new System.EventHandler(this.createToolStripMenuItem_MouseHover);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // selectallToolStripMenuItem
            // 
            resources.ApplyResources(this.selectallToolStripMenuItem, "selectallToolStripMenuItem");
            this.selectallToolStripMenuItem.Name = "selectallToolStripMenuItem";
            this.selectallToolStripMenuItem.Click += new System.EventHandler(this.selectallToolStripMenuItem_Click);
            this.selectallToolStripMenuItem.MouseHover += new System.EventHandler(this.createToolStripMenuItem_MouseHover);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineToolStripMenuItem,
            this.fillStyleToolStripMenuItem,
            this.backgroundStyleToolStripMenuItem,
            this.sizeOptions,
            this.showhideToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            resources.ApplyResources(this.toolsToolStripMenuItem, "toolsToolStripMenuItem");
            this.toolsToolStripMenuItem.MouseHover += new System.EventHandler(this.createToolStripMenuItem_MouseHover);
            // 
            // lineToolStripMenuItem
            // 
            this.lineToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lineToolStripMenuItem.Name = "lineToolStripMenuItem";
            resources.ApplyResources(this.lineToolStripMenuItem, "lineToolStripMenuItem");
            this.lineToolStripMenuItem.Click += new System.EventHandler(this.lineToolStripMenuItem_Click);
            this.lineToolStripMenuItem.MouseHover += new System.EventHandler(this.createToolStripMenuItem_MouseHover);
            // 
            // fillStyleToolStripMenuItem
            // 
            this.fillStyleToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillStyleToolStripMenuItem.Name = "fillStyleToolStripMenuItem";
            resources.ApplyResources(this.fillStyleToolStripMenuItem, "fillStyleToolStripMenuItem");
            this.fillStyleToolStripMenuItem.Click += new System.EventHandler(this.fillStyleToolStripMenuItem_Click);
            this.fillStyleToolStripMenuItem.MouseHover += new System.EventHandler(this.createToolStripMenuItem_MouseHover);
            // 
            // backgroundStyleToolStripMenuItem
            // 
            this.backgroundStyleToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.backgroundStyleToolStripMenuItem.Name = "backgroundStyleToolStripMenuItem";
            resources.ApplyResources(this.backgroundStyleToolStripMenuItem, "backgroundStyleToolStripMenuItem");
            this.backgroundStyleToolStripMenuItem.Click += new System.EventHandler(this.backgroundStyleToolStripMenuItem_Click);
            this.backgroundStyleToolStripMenuItem.MouseHover += new System.EventHandler(this.createToolStripMenuItem_MouseHover);
            // 
            // sizeOptions
            // 
            this.sizeOptions.Name = "sizeOptions";
            resources.ApplyResources(this.sizeOptions, "sizeOptions");
            this.sizeOptions.Click += new System.EventHandler(this.sizeOptions_Click);
            this.sizeOptions.MouseHover += new System.EventHandler(this.createToolStripMenuItem_MouseHover);
            // 
            // showhideToolStripMenuItem
            // 
            resources.ApplyResources(this.showhideToolStripMenuItem, "showhideToolStripMenuItem");
            this.showhideToolStripMenuItem.Name = "showhideToolStripMenuItem";
            this.showhideToolStripMenuItem.Click += new System.EventHandler(this.showhideToolStripMenuItem_Click);
            this.showhideToolStripMenuItem.MouseHover += new System.EventHandler(this.createToolStripMenuItem_MouseHover);
            // 
            // figuresToolStripMenuItem
            // 
            this.figuresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.polygonToolStripMenuItem,
            this.cylinderToolStripMenuItem,
            this.sphereToolStripMenuItem});
            this.figuresToolStripMenuItem.Name = "figuresToolStripMenuItem";
            resources.ApplyResources(this.figuresToolStripMenuItem, "figuresToolStripMenuItem");
            this.figuresToolStripMenuItem.MouseHover += new System.EventHandler(this.createToolStripMenuItem_MouseHover);
            // 
            // polygonToolStripMenuItem
            // 
            resources.ApplyResources(this.polygonToolStripMenuItem, "polygonToolStripMenuItem");
            this.polygonToolStripMenuItem.Name = "polygonToolStripMenuItem";
            this.polygonToolStripMenuItem.Click += new System.EventHandler(this.polygonStripButton1_Click);
            this.polygonToolStripMenuItem.MouseHover += new System.EventHandler(this.createToolStripMenuItem_MouseHover);
            // 
            // cylinderToolStripMenuItem
            // 
            resources.ApplyResources(this.cylinderToolStripMenuItem, "cylinderToolStripMenuItem");
            this.cylinderToolStripMenuItem.Name = "cylinderToolStripMenuItem";
            this.cylinderToolStripMenuItem.Click += new System.EventHandler(this.cylindertoolStripButton_Click);
            this.cylinderToolStripMenuItem.MouseHover += new System.EventHandler(this.createToolStripMenuItem_MouseHover);
            // 
            // sphereToolStripMenuItem
            // 
            resources.ApplyResources(this.sphereToolStripMenuItem, "sphereToolStripMenuItem");
            this.sphereToolStripMenuItem.Name = "sphereToolStripMenuItem";
            this.sphereToolStripMenuItem.Click += new System.EventHandler(this.spheretoolStripButton_Click);
            this.sphereToolStripMenuItem.MouseHover += new System.EventHandler(this.createToolStripMenuItem_MouseHover);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            this.helpToolStripMenuItem.MouseHover += new System.EventHandler(this.helpToolStripMenuItem_MouseHover);
            // 
            // BottomToolStripPanel
            // 
            resources.ApplyResources(this.BottomToolStripPanel, "BottomToolStripPanel");
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            // 
            // TopToolStripPanel
            // 
            resources.ApplyResources(this.TopToolStripPanel, "TopToolStripPanel");
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator6,
            this.selectStripButton2,
            this.polygonStripButton1,
            this.cylindertoolStripButton,
            this.spheretoolStripButton,
            this.toolStripSeparator1,
            this.zoominStripButton1,
            this.zoomoutStripButton2,
            this.showhidegridStripButton1,
            this.deleteselected,
            this.toolStripSeparator3});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
            // 
            // createToolStripButton
            // 
            this.createToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.createToolStripButton, "createToolStripButton");
            this.createToolStripButton.Name = "createToolStripButton";
            this.createToolStripButton.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            this.createToolStripButton.MouseHover += new System.EventHandler(this.createToolStripMenuItem_MouseHover);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.openToolStripButton, "openToolStripButton");
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            this.openToolStripButton.MouseHover += new System.EventHandler(this.createToolStripMenuItem_MouseHover);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.saveToolStripButton, "saveToolStripButton");
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            this.saveToolStripButton.MouseHover += new System.EventHandler(this.createToolStripMenuItem_MouseHover);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
            // 
            // selectStripButton2
            // 
            this.selectStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.selectStripButton2, "selectStripButton2");
            this.selectStripButton2.Name = "selectStripButton2";
            this.selectStripButton2.Click += new System.EventHandler(this.selectStripButton2_Click);
            this.selectStripButton2.MouseHover += new System.EventHandler(this.createToolStripMenuItem_MouseHover);
            // 
            // polygonStripButton1
            // 
            this.polygonStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.polygonStripButton1, "polygonStripButton1");
            this.polygonStripButton1.Name = "polygonStripButton1";
            this.polygonStripButton1.Click += new System.EventHandler(this.polygonStripButton1_Click);
            this.polygonStripButton1.MouseHover += new System.EventHandler(this.createToolStripMenuItem_MouseHover);
            // 
            // cylindertoolStripButton
            // 
            this.cylindertoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.cylindertoolStripButton, "cylindertoolStripButton");
            this.cylindertoolStripButton.Name = "cylindertoolStripButton";
            this.cylindertoolStripButton.Click += new System.EventHandler(this.cylindertoolStripButton_Click);
            this.cylindertoolStripButton.MouseHover += new System.EventHandler(this.createToolStripMenuItem_MouseHover);
            // 
            // spheretoolStripButton
            // 
            this.spheretoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.spheretoolStripButton, "spheretoolStripButton");
            this.spheretoolStripButton.Name = "spheretoolStripButton";
            this.spheretoolStripButton.Click += new System.EventHandler(this.spheretoolStripButton_Click);
            this.spheretoolStripButton.MouseHover += new System.EventHandler(this.createToolStripMenuItem_MouseHover);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // zoominStripButton1
            // 
            this.zoominStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.zoominStripButton1, "zoominStripButton1");
            this.zoominStripButton1.Name = "zoominStripButton1";
            this.zoominStripButton1.Click += new System.EventHandler(this.zoonInToolStripMenuItem_Click);
            this.zoominStripButton1.MouseHover += new System.EventHandler(this.createToolStripMenuItem_MouseHover);
            // 
            // zoomoutStripButton2
            // 
            this.zoomoutStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.zoomoutStripButton2, "zoomoutStripButton2");
            this.zoomoutStripButton2.Name = "zoomoutStripButton2";
            this.zoomoutStripButton2.Click += new System.EventHandler(this.zoomOutToolStripMenuItem_Click);
            this.zoomoutStripButton2.MouseHover += new System.EventHandler(this.createToolStripMenuItem_MouseHover);
            // 
            // showhidegridStripButton1
            // 
            this.showhidegridStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.showhidegridStripButton1, "showhidegridStripButton1");
            this.showhidegridStripButton1.Name = "showhidegridStripButton1";
            this.showhidegridStripButton1.Click += new System.EventHandler(this.showhideToolStripMenuItem_Click);
            this.showhidegridStripButton1.MouseHover += new System.EventHandler(this.createToolStripMenuItem_MouseHover);
            // 
            // deleteselected
            // 
            this.deleteselected.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.deleteselected, "deleteselected");
            this.deleteselected.Name = "deleteselected";
            this.deleteselected.Click += new System.EventHandler(this.deleteselected_Click);
            this.deleteselected.MouseHover += new System.EventHandler(this.createToolStripMenuItem_MouseHover);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // RightToolStripPanel
            // 
            resources.ApplyResources(this.RightToolStripPanel, "RightToolStripPanel");
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            // 
            // LeftToolStripPanel
            // 
            resources.ApplyResources(this.LeftToolStripPanel, "LeftToolStripPanel");
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            // 
            // ContentPanel
            // 
            resources.ApplyResources(this.ContentPanel, "ContentPanel");
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel4});
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.SizingGrip = false;
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            resources.ApplyResources(this.toolStripStatusLabel4, "toolStripStatusLabel4");
            this.toolStripStatusLabel4.Spring = true;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.panelxy, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelyz, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelxz, 0, 0);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // panelxy
            // 
            this.panelxy.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelxy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelxy.ContextMenuStrip = this.contextmenu;
            this.panelxy.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.panelxy, "panelxy");
            this.panelxy.Name = "panelxy";
            this.panelxy.Paint += new System.Windows.Forms.PaintEventHandler(this.panelxy_Paint);
            this.panelxy.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelxy_MouseClick);
            this.panelxy.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panelxy_MouseDoubleClick);
            this.panelxy.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelxy_MouseDown);
            this.panelxy.MouseLeave += new System.EventHandler(this.panelxy_MouseLeave);
            this.panelxy.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelxy_MouseMove);
            this.panelxy.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelxy_MouseUp);
            // 
            // contextmenu
            // 
            this.contextmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextmenudeleteselected,
            this.contextmenulinestyle,
            this.contextmenufillstyle,
            this.contextmenusizeoptions,
            this.contextmenubaskstyle});
            this.contextmenu.Name = "contextMenuStrip2";
            resources.ApplyResources(this.contextmenu, "contextmenu");
            this.contextmenu.Click += new System.EventHandler(this.contextmenu_Click);
            // 
            // contextmenudeleteselected
            // 
            this.contextmenudeleteselected.Image = global::_01_Yovchev_208.Properties.Resources.Delete;
            this.contextmenudeleteselected.Name = "contextmenudeleteselected";
            resources.ApplyResources(this.contextmenudeleteselected, "contextmenudeleteselected");
            this.contextmenudeleteselected.Click += new System.EventHandler(this.deleteselected_Click);
            // 
            // contextmenulinestyle
            // 
            this.contextmenulinestyle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.contextmenulinestyle.Name = "contextmenulinestyle";
            resources.ApplyResources(this.contextmenulinestyle, "contextmenulinestyle");
            this.contextmenulinestyle.Click += new System.EventHandler(this.lineToolStripMenuItem_Click);
            // 
            // contextmenufillstyle
            // 
            this.contextmenufillstyle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.contextmenufillstyle.Name = "contextmenufillstyle";
            resources.ApplyResources(this.contextmenufillstyle, "contextmenufillstyle");
            this.contextmenufillstyle.Click += new System.EventHandler(this.fillStyleToolStripMenuItem_Click);
            // 
            // contextmenusizeoptions
            // 
            this.contextmenusizeoptions.Name = "contextmenusizeoptions";
            resources.ApplyResources(this.contextmenusizeoptions, "contextmenusizeoptions");
            this.contextmenusizeoptions.Click += new System.EventHandler(this.sizeOptions_Click);
            // 
            // contextmenubaskstyle
            // 
            this.contextmenubaskstyle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.contextmenubaskstyle.Name = "contextmenubaskstyle";
            resources.ApplyResources(this.contextmenubaskstyle, "contextmenubaskstyle");
            this.contextmenubaskstyle.Click += new System.EventHandler(this.backgroundStyleToolStripMenuItem_Click);
            // 
            // panelyz
            // 
            resources.ApplyResources(this.panelyz, "panelyz");
            this.panelyz.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelyz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelyz.ContextMenuStrip = this.contextmenu;
            this.panelyz.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelyz.Name = "panelyz";
            this.panelyz.Paint += new System.Windows.Forms.PaintEventHandler(this.panelyz_Paint);
            this.panelyz.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelyz_MouseClick);
            this.panelyz.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panelyz_MouseDoubleClick);
            this.panelyz.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelyz_MouseDown);
            this.panelyz.MouseLeave += new System.EventHandler(this.panelyz_MouseLeave);
            this.panelyz.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelyz_MouseMove);
            this.panelyz.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelxz_MouseUp);
            // 
            // panelxz
            // 
            this.panelxz.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelxz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelxz.ContextMenuStrip = this.contextmenu;
            this.panelxz.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.panelxz, "panelxz");
            this.panelxz.Name = "panelxz";
            this.panelxz.Paint += new System.Windows.Forms.PaintEventHandler(this.panelxz_Paint);
            this.panelxz.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelxz_MouseClick);
            this.panelxz.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panelxz_MouseDoubleClick);
            this.panelxz.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelxz_MouseDown);
            this.panelxz.MouseLeave += new System.EventHandler(this.panelxz_MouseLeave);
            this.panelxz.MouseHover += new System.EventHandler(this.panelxz_MouseHover);
            this.panelxz.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelxz_MouseMove);
            this.panelxz.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelxz_MouseUp);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "*.my3d";
            this.openFileDialog1.FileName = "openFileDialog1";
            resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
            this.openFileDialog1.FilterIndex = 0;
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "*.my3d";
            this.saveFileDialog1.FileName = "Unitted1.my3d";
            resources.ApplyResources(this.saveFileDialog1, "saveFileDialog1");
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // linecolocrbutton
            // 
            this.linecolocrbutton.BackColor = System.Drawing.Color.Yellow;
            this.linecolocrbutton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.linecolocrbutton.FlatAppearance.BorderSize = 2;
            resources.ApplyResources(this.linecolocrbutton, "linecolocrbutton");
            this.linecolocrbutton.Name = "linecolocrbutton";
            this.linecolocrbutton.UseVisualStyleBackColor = false;
            this.linecolocrbutton.Click += new System.EventHandler(this.linecolocrbutton_Click);
            this.linecolocrbutton.MouseHover += new System.EventHandler(this.linecolocrbutton_MouseHover);
            // 
            // fillcolorbutton
            // 
            this.fillcolorbutton.BackColor = System.Drawing.Color.Yellow;
            this.fillcolorbutton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.fillcolorbutton.FlatAppearance.BorderSize = 2;
            resources.ApplyResources(this.fillcolorbutton, "fillcolorbutton");
            this.fillcolorbutton.Name = "fillcolorbutton";
            this.fillcolorbutton.UseVisualStyleBackColor = false;
            this.fillcolorbutton.Click += new System.EventHandler(this.fillcolorbutton_Click);
            this.fillcolorbutton.MouseHover += new System.EventHandler(this.fillcolorbutton_MouseHover);
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.linecolocrbutton);
            this.Controls.Add(this.fillcolorbutton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.contextmenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton createToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton spheretoolStripButton;
        private System.Windows.Forms.ToolStripMenuItem figuresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polygonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cylinderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sphereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoonInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton polygonStripButton1;
        private System.Windows.Forms.ToolStripButton cylindertoolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelxy;
        private System.Windows.Forms.Panel panelxz;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripMenuItem fillStyleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundStyleToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton deleteselected;
        private System.Windows.Forms.ToolStripMenuItem showhideToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton selectStripButton2;
        private System.Collections.Generic.List<Point3D> linepoints;
        private System.Windows.Forms.ToolStripButton showhidegridStripButton1;
        private System.Windows.Forms.ToolStripButton zoominStripButton1;
        private System.Windows.Forms.ToolStripButton zoomoutStripButton2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private bool showhidegrid;
        private bool isDragging;
        private bool isResizing;
        private bool documentischanged;
        private bool lockgrid;
     //   private bool zoomischanged;
        private int gridsize;
        private bool linestartdraw;
        private System.Drawing.Point startdraw;
        private System.Drawing.Point enddraw;
        private Bitmap xz, yz, xy, bufxz, bufyz, bufxy;
        private Graphics xzpanel,yzpanel,xypanel;
        private byte shapedraw = 1;
        private System.Collections.ArrayList shapes;
        private string filename;
        private Brush fontbrush;
        private Brush fillbrush;
        private Pen linepen;
        private Point3D DragP;
        private int pointselectednumber;
        private bool selectshape;
        private int selectshapeindex;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Button linecolocrbutton;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.Panel panelyz;
        private System.Windows.Forms.Button fillcolorbutton;
        private bool contextmenuclicked;
        public Point3D resizepoint1,resizepoint2;
        private Point3D rezpol;
        private System.Windows.Forms.ContextMenuStrip contextmenu;
        private System.Windows.Forms.ToolStripMenuItem contextmenulinestyle;
        private System.Windows.Forms.ToolStripMenuItem contextmenufillstyle;
        private System.Windows.Forms.ToolStripMenuItem contextmenubaskstyle;
        private System.Windows.Forms.ToolStripMenuItem sizeOptions;
        private System.Windows.Forms.ToolStripMenuItem contextmenusizeoptions;
        private System.Windows.Forms.ToolStripMenuItem contextmenudeleteselected;
    }
}

