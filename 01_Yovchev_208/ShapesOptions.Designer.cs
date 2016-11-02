namespace _01_Yovchev_208
{
    partial class ShapesOptions
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
            this.xcoor = new System.Windows.Forms.NumericUpDown();
            this.ycoor = new System.Windows.Forms.NumericUpDown();
            this.zcoor = new System.Windows.Forms.NumericUpDown();
            this.radius = new System.Windows.Forms.NumericUpDown();
            this.height = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.xcoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ycoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zcoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).BeginInit();
            this.SuspendLayout();
            // 
            // xcoor
            // 
            this.xcoor.Location = new System.Drawing.Point(140, 11);
            this.xcoor.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.xcoor.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.xcoor.Name = "xcoor";
            this.xcoor.Size = new System.Drawing.Size(65, 20);
            this.xcoor.TabIndex = 0;
            this.xcoor.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // ycoor
            // 
            this.ycoor.Location = new System.Drawing.Point(140, 37);
            this.ycoor.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ycoor.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ycoor.Name = "ycoor";
            this.ycoor.Size = new System.Drawing.Size(65, 20);
            this.ycoor.TabIndex = 1;
            this.ycoor.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // zcoor
            // 
            this.zcoor.Location = new System.Drawing.Point(140, 63);
            this.zcoor.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.zcoor.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.zcoor.Name = "zcoor";
            this.zcoor.Size = new System.Drawing.Size(65, 20);
            this.zcoor.TabIndex = 2;
            this.zcoor.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // radius
            // 
            this.radius.Location = new System.Drawing.Point(140, 89);
            this.radius.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.radius.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.radius.Name = "radius";
            this.radius.Size = new System.Drawing.Size(65, 20);
            this.radius.TabIndex = 3;
            this.radius.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(140, 115);
            this.height.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.height.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(65, 20);
            this.height.TabIndex = 4;
            this.height.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(115, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(16, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Center Point";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Radius";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(21, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Height";
            // 
            // ShapesOptions
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(221, 192);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.height);
            this.Controls.Add(this.radius);
            this.Controls.Add(this.zcoor);
            this.Controls.Add(this.ycoor);
            this.Controls.Add(this.xcoor);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShapesOptions";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Size Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShapesOptions_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.xcoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ycoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zcoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown xcoor;
        private System.Windows.Forms.NumericUpDown ycoor;
        private System.Windows.Forms.NumericUpDown zcoor;
        private System.Windows.Forms.NumericUpDown radius;
        private System.Windows.Forms.NumericUpDown height;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public MyShapes shape;
    }
}