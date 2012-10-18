namespace UScreenCaptureUI
{
    partial class FormFlashRegion
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
            this.components = new System.ComponentModel.Container();
            this.control1 = new System.Windows.Forms.Control();
            this.control2 = new System.Windows.Forms.Control();
            this.control3 = new System.Windows.Forms.Control();
            this.control4 = new System.Windows.Forms.Control();
            this.timerDie = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // control1
            // 
            this.control1.BackColor = System.Drawing.Color.Lime;
            this.control1.Dock = System.Windows.Forms.DockStyle.Left;
            this.control1.Location = new System.Drawing.Point(0, 0);
            this.control1.Name = "control1";
            this.control1.Size = new System.Drawing.Size(10, 266);
            this.control1.TabIndex = 0;
            this.control1.Text = "control1";
            // 
            // control2
            // 
            this.control2.BackColor = System.Drawing.Color.Lime;
            this.control2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.control2.Location = new System.Drawing.Point(10, 256);
            this.control2.Name = "control2";
            this.control2.Size = new System.Drawing.Size(282, 10);
            this.control2.TabIndex = 1;
            this.control2.Text = "control2";
            // 
            // control3
            // 
            this.control3.BackColor = System.Drawing.Color.Lime;
            this.control3.Dock = System.Windows.Forms.DockStyle.Right;
            this.control3.Location = new System.Drawing.Point(282, 0);
            this.control3.Name = "control3";
            this.control3.Size = new System.Drawing.Size(10, 256);
            this.control3.TabIndex = 2;
            this.control3.Text = "control3";
            // 
            // control4
            // 
            this.control4.BackColor = System.Drawing.Color.Lime;
            this.control4.Dock = System.Windows.Forms.DockStyle.Top;
            this.control4.Location = new System.Drawing.Point(10, 0);
            this.control4.Name = "control4";
            this.control4.Size = new System.Drawing.Size(272, 10);
            this.control4.TabIndex = 3;
            this.control4.Text = "control4";
            // 
            // timerDie
            // 
            this.timerDie.Enabled = true;
            this.timerDie.Interval = 20;
            this.timerDie.Tick += new System.EventHandler(this.timerDie_Tick);
            // 
            // FormFlashRegion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.control4);
            this.Controls.Add(this.control3);
            this.Controls.Add(this.control2);
            this.Controls.Add(this.control1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFlashRegion";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormFlashRegion";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.Window;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Control control1;
        private System.Windows.Forms.Control control2;
        private System.Windows.Forms.Control control3;
        private System.Windows.Forms.Control control4;
        private System.Windows.Forms.Timer timerDie;

    }
}