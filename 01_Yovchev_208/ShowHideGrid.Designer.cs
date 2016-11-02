namespace _01_Yovchev_208
{
    partial class ShowHideGrid
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sizecheck = new System.Windows.Forms.NumericUpDown();
            this.lock_gridcheck = new System.Windows.Forms.CheckBox();
            this.showhidecheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.sizecheck)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(99, 54);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(72, 23);
            this.buttonOK.TabIndex = 11;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(99, 83);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(72, 23);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "GridSize";
            // 
            // sizecheck
            // 
            this.sizecheck.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.sizecheck.Location = new System.Drawing.Point(16, 86);
            this.sizecheck.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.sizecheck.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.sizecheck.Name = "sizecheck";
            this.sizecheck.Size = new System.Drawing.Size(48, 20);
            this.sizecheck.TabIndex = 8;
            this.sizecheck.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sizecheck.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.sizecheck.ValueChanged += new System.EventHandler(this.sizecheck_ValueChanged);
            // 
            // lock_gridcheck
            // 
            this.lock_gridcheck.AutoSize = true;
            this.lock_gridcheck.Location = new System.Drawing.Point(16, 35);
            this.lock_gridcheck.Name = "lock_gridcheck";
            this.lock_gridcheck.Size = new System.Drawing.Size(72, 17);
            this.lock_gridcheck.TabIndex = 7;
            this.lock_gridcheck.Text = "Lock Grid";
            this.lock_gridcheck.UseVisualStyleBackColor = true;
            this.lock_gridcheck.CheckedChanged += new System.EventHandler(this.lock_grid_CheckedChanged);
            // 
            // showhidecheck
            // 
            this.showhidecheck.AutoSize = true;
            this.showhidecheck.Location = new System.Drawing.Point(16, 12);
            this.showhidecheck.Name = "showhidecheck";
            this.showhidecheck.Size = new System.Drawing.Size(102, 17);
            this.showhidecheck.TabIndex = 6;
            this.showhidecheck.Text = "Show\\Hide Grid";
            this.showhidecheck.UseVisualStyleBackColor = true;
            this.showhidecheck.CheckedChanged += new System.EventHandler(this.showhidecheck_CheckedChanged);
            // 
            // ShowHideGrid
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(175, 117);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sizecheck);
            this.Controls.Add(this.lock_gridcheck);
            this.Controls.Add(this.showhidecheck);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowHideGrid";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ShowHideGrid";
            ((System.ComponentModel.ISupportInitialize)(this.sizecheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown sizecheck;
        private System.Windows.Forms.CheckBox lock_gridcheck;
        private System.Windows.Forms.CheckBox showhidecheck;
    }
}