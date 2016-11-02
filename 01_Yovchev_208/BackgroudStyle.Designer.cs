using System.Drawing;
namespace _01_Yovchev_208
{
    partial class BackgroudStyle
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.solidbrushradio = new System.Windows.Forms.RadioButton();
            this.linearGradient = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new _01_Yovchev_208.ColorButton();
            this.button3 = new _01_Yovchev_208.ColorButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(145, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(145, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 74);
            this.panel1.TabIndex = 3;
            // 
            // solidbrushradio
            // 
            this.solidbrushradio.AutoSize = true;
            this.solidbrushradio.Location = new System.Drawing.Point(6, 19);
            this.solidbrushradio.Name = "solidbrushradio";
            this.solidbrushradio.Size = new System.Drawing.Size(75, 17);
            this.solidbrushradio.TabIndex = 4;
            this.solidbrushradio.TabStop = true;
            this.solidbrushradio.Text = "SolidBrush";
            this.solidbrushradio.UseVisualStyleBackColor = true;
            this.solidbrushradio.CheckedChanged += new System.EventHandler(this.solidbrushradio_CheckedChanged);
            // 
            // linearGradient
            // 
            this.linearGradient.AutoSize = true;
            this.linearGradient.Location = new System.Drawing.Point(6, 42);
            this.linearGradient.Name = "linearGradient";
            this.linearGradient.Size = new System.Drawing.Size(94, 17);
            this.linearGradient.TabIndex = 5;
            this.linearGradient.TabStop = true;
            this.linearGradient.Text = "LinearGradient";
            this.linearGradient.UseVisualStyleBackColor = true;
            this.linearGradient.CheckedChanged += new System.EventHandler(this.linearGradient_CheckedChanged_1);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(145, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 30);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.solidbrushradio);
            this.groupBox1.Controls.Add(this.linearGradient);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(107, 74);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Style";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.CenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(233)))), ((int)(((byte)(57)))));
            this.button4.Location = new System.Drawing.Point(22, 150);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 21);
            this.button4.TabIndex = 9;
            this.button4.Tag = "secondcolorbutton";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.CenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(233)))), ((int)(((byte)(57)))));
            this.button3.Location = new System.Drawing.Point(22, 113);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 21);
            this.button3.TabIndex = 8;
            this.button3.Tag = "firstcolorbutton";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BackgroudStyle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 199);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BackgroudStyle";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BackgroudStyle";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.BackgroudStyle_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton solidbrushradio;
        private System.Windows.Forms.RadioButton linearGradient;
        private System.Windows.Forms.Button button2;
        private ColorButton button3;
        private ColorButton button4;
        private Color firstcolor = Color.White;
        private Color secondcolor = Color.White;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}