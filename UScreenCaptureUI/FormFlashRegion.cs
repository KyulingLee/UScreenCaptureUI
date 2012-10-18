using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UScreenCaptureUI
{
    public partial class FormFlashRegion : Form
    {
        public FormFlashRegion(int top, int right, int bottom, int left)
        {
            InitializeComponent();

            Left = left;
            Top = top;
            Width = right - left;
            Height = bottom - top;
        }

        private void timerDie_Tick(object sender, EventArgs e)
        {
            if (Opacity <= 0)
                Close();
            else
                Opacity -= 0.05d;
        }
    }
}
