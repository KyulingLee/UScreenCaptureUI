namespace UScreenCaptureUI
{
    partial class FormMain
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
            this.numericUpDownTop = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLeft = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBottom = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownFps = new System.Windows.Forms.NumericUpDown();
            this.buttonSaveToRegistry = new System.Windows.Forms.Button();
            this.buttonCopyURLToClipboard = new System.Windows.Forms.Button();
            this.groupBoxScreen = new System.Windows.Forms.GroupBox();
            this.buttonShow = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxCaptureLayered = new System.Windows.Forms.CheckBox();
            this.checkBoxShowCursor = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownMonitor = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFps)).BeginInit();
            this.groupBoxScreen.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonitor)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownTop
            // 
            this.numericUpDownTop.Location = new System.Drawing.Point(57, 19);
            this.numericUpDownTop.Maximum = new decimal(new int[] {
            32768,
            0,
            0,
            0});
            this.numericUpDownTop.Name = "numericUpDownTop";
            this.numericUpDownTop.Size = new System.Drawing.Size(45, 20);
            this.numericUpDownTop.TabIndex = 0;
            this.numericUpDownTop.ValueChanged += new System.EventHandler(this.numericUpDownTop_ValueChanged);
            // 
            // numericUpDownLeft
            // 
            this.numericUpDownLeft.Location = new System.Drawing.Point(6, 45);
            this.numericUpDownLeft.Maximum = new decimal(new int[] {
            32768,
            0,
            0,
            0});
            this.numericUpDownLeft.Name = "numericUpDownLeft";
            this.numericUpDownLeft.Size = new System.Drawing.Size(45, 20);
            this.numericUpDownLeft.TabIndex = 1;
            this.numericUpDownLeft.ValueChanged += new System.EventHandler(this.numericUpDownLeft_ValueChanged);
            // 
            // numericUpDownBottom
            // 
            this.numericUpDownBottom.Location = new System.Drawing.Point(57, 71);
            this.numericUpDownBottom.Maximum = new decimal(new int[] {
            32768,
            0,
            0,
            0});
            this.numericUpDownBottom.Name = "numericUpDownBottom";
            this.numericUpDownBottom.Size = new System.Drawing.Size(45, 20);
            this.numericUpDownBottom.TabIndex = 2;
            this.numericUpDownBottom.ValueChanged += new System.EventHandler(this.numericUpDownBottom_ValueChanged);
            // 
            // numericUpDownRight
            // 
            this.numericUpDownRight.Location = new System.Drawing.Point(108, 45);
            this.numericUpDownRight.Maximum = new decimal(new int[] {
            32768,
            0,
            0,
            0});
            this.numericUpDownRight.Name = "numericUpDownRight";
            this.numericUpDownRight.Size = new System.Drawing.Size(45, 20);
            this.numericUpDownRight.TabIndex = 3;
            this.numericUpDownRight.ValueChanged += new System.EventHandler(this.numericUpDownRight_ValueChanged);
            // 
            // numericUpDownFps
            // 
            this.numericUpDownFps.Location = new System.Drawing.Point(106, 14);
            this.numericUpDownFps.Maximum = new decimal(new int[] {
            32768,
            0,
            0,
            0});
            this.numericUpDownFps.Name = "numericUpDownFps";
            this.numericUpDownFps.Size = new System.Drawing.Size(47, 20);
            this.numericUpDownFps.TabIndex = 4;
            this.numericUpDownFps.ValueChanged += new System.EventHandler(this.numericUpDownFps_ValueChanged);
            // 
            // buttonSaveToRegistry
            // 
            this.buttonSaveToRegistry.Location = new System.Drawing.Point(12, 234);
            this.buttonSaveToRegistry.Name = "buttonSaveToRegistry";
            this.buttonSaveToRegistry.Size = new System.Drawing.Size(159, 23);
            this.buttonSaveToRegistry.TabIndex = 5;
            this.buttonSaveToRegistry.Text = "Save to Registry";
            this.buttonSaveToRegistry.UseVisualStyleBackColor = true;
            this.buttonSaveToRegistry.Click += new System.EventHandler(this.buttonSaveToRegistry_Click);
            // 
            // buttonCopyURLToClipboard
            // 
            this.buttonCopyURLToClipboard.Location = new System.Drawing.Point(12, 263);
            this.buttonCopyURLToClipboard.Name = "buttonCopyURLToClipboard";
            this.buttonCopyURLToClipboard.Size = new System.Drawing.Size(159, 23);
            this.buttonCopyURLToClipboard.TabIndex = 6;
            this.buttonCopyURLToClipboard.Text = "Copy URL to Clipboard";
            this.buttonCopyURLToClipboard.UseVisualStyleBackColor = true;
            this.buttonCopyURLToClipboard.Click += new System.EventHandler(this.buttonCopyURLToClipboard_Click);
            // 
            // groupBoxScreen
            // 
            this.groupBoxScreen.Controls.Add(this.buttonShow);
            this.groupBoxScreen.Controls.Add(this.numericUpDownLeft);
            this.groupBoxScreen.Controls.Add(this.numericUpDownTop);
            this.groupBoxScreen.Controls.Add(this.numericUpDownBottom);
            this.groupBoxScreen.Controls.Add(this.numericUpDownRight);
            this.groupBoxScreen.Location = new System.Drawing.Point(12, 12);
            this.groupBoxScreen.Name = "groupBoxScreen";
            this.groupBoxScreen.Size = new System.Drawing.Size(159, 98);
            this.groupBoxScreen.TabIndex = 7;
            this.groupBoxScreen.TabStop = false;
            this.groupBoxScreen.Text = "Screen Size";
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(57, 45);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(43, 20);
            this.buttonShow.TabIndex = 4;
            this.buttonShow.Text = "Flash";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxCaptureLayered);
            this.groupBox1.Controls.Add(this.checkBoxShowCursor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDownMonitor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDownFps);
            this.groupBox1.Location = new System.Drawing.Point(12, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 111);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Other settings";
            // 
            // checkBoxCaptureLayered
            // 
            this.checkBoxCaptureLayered.AutoSize = true;
            this.checkBoxCaptureLayered.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxCaptureLayered.Location = new System.Drawing.Point(6, 89);
            this.checkBoxCaptureLayered.Name = "checkBoxCaptureLayered";
            this.checkBoxCaptureLayered.Size = new System.Drawing.Size(147, 17);
            this.checkBoxCaptureLayered.TabIndex = 13;
            this.checkBoxCaptureLayered.Text = "Capture layered windows:";
            this.checkBoxCaptureLayered.UseVisualStyleBackColor = true;
            this.checkBoxCaptureLayered.CheckedChanged += new System.EventHandler(this.checkBoxCaptureLayered_CheckedChanged);
            // 
            // checkBoxShowCursor
            // 
            this.checkBoxShowCursor.AutoSize = true;
            this.checkBoxShowCursor.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxShowCursor.Location = new System.Drawing.Point(64, 66);
            this.checkBoxShowCursor.Name = "checkBoxShowCursor";
            this.checkBoxShowCursor.Size = new System.Drawing.Size(89, 17);
            this.checkBoxShowCursor.TabIndex = 12;
            this.checkBoxShowCursor.Text = "Show Cursor:";
            this.checkBoxShowCursor.UseVisualStyleBackColor = true;
            this.checkBoxShowCursor.CheckedChanged += new System.EventHandler(this.checkBoxShowCursor_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Monitor:";
            // 
            // numericUpDownMonitor
            // 
            this.numericUpDownMonitor.Location = new System.Drawing.Point(106, 40);
            this.numericUpDownMonitor.Maximum = new decimal(new int[] {
            32768,
            0,
            0,
            0});
            this.numericUpDownMonitor.Name = "numericUpDownMonitor";
            this.numericUpDownMonitor.Size = new System.Drawing.Size(47, 20);
            this.numericUpDownMonitor.TabIndex = 10;
            this.numericUpDownMonitor.ValueChanged += new System.EventHandler(this.numericUpDownMonitor_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Frame Rate (FPS):";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 298);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxScreen);
            this.Controls.Add(this.buttonCopyURLToClipboard);
            this.Controls.Add(this.buttonSaveToRegistry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UScreenCapture UI";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFps)).EndInit();
            this.groupBoxScreen.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonitor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownTop;
        private System.Windows.Forms.NumericUpDown numericUpDownLeft;
        private System.Windows.Forms.NumericUpDown numericUpDownBottom;
        private System.Windows.Forms.NumericUpDown numericUpDownRight;
        private System.Windows.Forms.NumericUpDown numericUpDownFps;
        private System.Windows.Forms.Button buttonSaveToRegistry;
        private System.Windows.Forms.Button buttonCopyURLToClipboard;
        private System.Windows.Forms.GroupBox groupBoxScreen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownMonitor;
        private System.Windows.Forms.CheckBox checkBoxCaptureLayered;
        private System.Windows.Forms.CheckBox checkBoxShowCursor;

    }
}

