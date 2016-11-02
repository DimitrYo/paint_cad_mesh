using System.Drawing;
namespace _01_Yovchev_208
{
    partial class LineStyle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.solidradio = new System.Windows.Forms.RadioButton();
            this.dotradio = new System.Windows.Forms.RadioButton();
            this.dashradio = new System.Windows.Forms.RadioButton();
            this.dashdotradio = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.line_width = new System.Windows.Forms.NumericUpDown();
            this.button3 = new _01_Yovchev_208.ColorButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.line_width)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.solidradio);
            this.groupBox1.Controls.Add(this.dotradio);
            this.groupBox1.Controls.Add(this.dashradio);
            this.groupBox1.Controls.Add(this.dashdotradio);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(95, 112);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Style";
            // 
            // solidradio
            // 
            this.solidradio.AutoSize = true;
            this.solidradio.Location = new System.Drawing.Point(16, 18);
            this.solidradio.Name = "solidradio";
            this.solidradio.Size = new System.Drawing.Size(48, 17);
            this.solidradio.TabIndex = 7;
            this.solidradio.TabStop = true;
            this.solidradio.Text = "Solid";
            this.solidradio.UseVisualStyleBackColor = true;
            this.solidradio.CheckedChanged += new System.EventHandler(this.solidradio_CheckedChanged);
            // 
            // dotradio
            // 
            this.dotradio.AutoSize = true;
            this.dotradio.Location = new System.Drawing.Point(16, 90);
            this.dotradio.Name = "dotradio";
            this.dotradio.Size = new System.Drawing.Size(42, 17);
            this.dotradio.TabIndex = 6;
            this.dotradio.TabStop = true;
            this.dotradio.Text = "Dot";
            this.dotradio.UseVisualStyleBackColor = true;
            this.dotradio.CheckedChanged += new System.EventHandler(this.dotradio_CheckedChanged);
            // 
            // dashradio
            // 
            this.dashradio.AutoSize = true;
            this.dashradio.Location = new System.Drawing.Point(16, 41);
            this.dashradio.Name = "dashradio";
            this.dashradio.Size = new System.Drawing.Size(50, 17);
            this.dashradio.TabIndex = 4;
            this.dashradio.TabStop = true;
            this.dashradio.Text = "Dash";
            this.dashradio.UseVisualStyleBackColor = true;
            this.dashradio.CheckedChanged += new System.EventHandler(this.dashradio_CheckedChanged);
            // 
            // dashdotradio
            // 
            this.dashdotradio.AutoSize = true;
            this.dashdotradio.Location = new System.Drawing.Point(16, 64);
            this.dashdotradio.Name = "dashdotradio";
            this.dashdotradio.Size = new System.Drawing.Size(67, 17);
            this.dashdotradio.TabIndex = 5;
            this.dashdotradio.TabStop = true;
            this.dashdotradio.Text = "DashDot";
            this.dashdotradio.UseVisualStyleBackColor = true;
            this.dashdotradio.CheckedChanged += new System.EventHandler(this.dashdotradio_CheckedChanged);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(144, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 30);
            this.button2.TabIndex = 19;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(144, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 84);
            this.panel1.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(143, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 30);
            this.button1.TabIndex = 18;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Color";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(9, 132);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(57, 13);
            this.label.TabIndex = 24;
            this.label.Text = "Pen Width";
            // 
            // line_width
            // 
            this.line_width.Location = new System.Drawing.Point(87, 130);
            this.line_width.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.line_width.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.line_width.Name = "line_width";
            this.line_width.Size = new System.Drawing.Size(51, 20);
            this.line_width.TabIndex = 23;
            this.line_width.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.line_width.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.line_width.ValueChanged += new System.EventHandler(this.line_width_ValueChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.CenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(233)))), ((int)(((byte)(57)))));
            this.button3.Location = new System.Drawing.Point(72, 156);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 21);
            this.button3.TabIndex = 20;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // LineStyle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 192);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.line_width);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LineStyle";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LineStyle";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.LineStyle_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.line_width)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton dotradio;
        private System.Windows.Forms.RadioButton dashradio;
        private System.Windows.Forms.RadioButton dashdotradio;
        private ColorButton button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton solidradio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.NumericUpDown line_width;
        public Pen pen;
    }
}