using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace UScreenCaptureUI
{
    public partial class FormMain : Form
    {
        public UScreenCaptureConfig Config;
        public FormMain()
        {
            InitializeComponent();
            try
            {
                Config = UScreenCaptureConfig.CreateFromRegistry();
            }
            catch
            {
                MessageBox.Show("I couldn't detect UScreenCapture... Are you sure it's installed?");
                Close();
            }

            numericUpDownRight.Value = Convert.ToInt32(Config.Right);
            numericUpDownRight.Minimum = numericUpDownLeft.Value;

            numericUpDownBottom.Value = Convert.ToInt32(Config.Bottom);
            numericUpDownBottom.Minimum = numericUpDownTop.Value;

            numericUpDownLeft.Value = Convert.ToInt32(Config.Left);
            numericUpDownTop.Value = Convert.ToInt32(Config.Top);

            numericUpDownFps.Value = Convert.ToInt32(Config.FrameRate);
            numericUpDownMonitor.Value = Convert.ToInt32(Config.MonitorNum);

            checkBoxShowCursor.Checked = Config.ShowCursor == 1u;
            checkBoxCaptureLayered.Checked = Config.CaptureLayeredWindows == 1u;
        }

        private void UpdateSize()
        {
            groupBoxScreen.Text = string.Format("Screen Size: {0}:{1}", Config.Right - Config.Left, Config.Bottom - Config.Top);
        }

        private void buttonSaveToRegistry_Click(object sender, EventArgs e)
        {
            Config.SaveToRegistry();
            MessageBox.Show("Done!");
        }

        private void numericUpDownTop_ValueChanged(object sender, EventArgs e)
        {
            Config.Top = (uint) numericUpDownTop.Value;
            numericUpDownBottom.Minimum = numericUpDownTop.Value;
        }

        private void numericUpDownRight_ValueChanged(object sender, EventArgs e)
        {
            Config.Right = (uint) numericUpDownRight.Value;
        }

        private void numericUpDownBottom_ValueChanged(object sender, EventArgs e)
        {
            Config.Bottom = (uint) numericUpDownBottom.Value;
        }

        private void numericUpDownLeft_ValueChanged(object sender, EventArgs e)
        {
            Config.Left = (uint) numericUpDownLeft.Value;
            numericUpDownRight.Minimum = numericUpDownLeft.Value;
        }

        private void numericUpDownFps_ValueChanged(object sender, EventArgs e)
        {
            Config.FrameRate = (uint) numericUpDownFps.Value;
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            FormFlashRegion f = new FormFlashRegion((int) Config.Top, (int) Config.Right, (int) Config.Bottom, (int) Config.Left);
            f.Show();
        }

        private void numericUpDownMonitor_ValueChanged(object sender, EventArgs e)
        {
            Config.MonitorNum = (uint) numericUpDownMonitor.Value;
        }

        private void checkBoxShowCursor_CheckedChanged(object sender, EventArgs e)
        {
            Config.ShowCursor = checkBoxShowCursor.Checked ? 1u : 0u;
        }

        private void checkBoxCaptureLayered_CheckedChanged(object sender, EventArgs e)
        {
            Config.CaptureLayeredWindows = checkBoxCaptureLayered.Checked ? 1u : 0u;
        }

        private void buttonCopyURLToClipboard_Click(object sender, EventArgs e)
        {
            string url = Config.CreateStreamingURL();
            Clipboard.SetText(url);
            MessageBox.Show(String.Format("Done:\n{0}", url));
        }
    }

    public class UScreenCaptureConfig
    {
        public RegistryKey RegKey;

        public UInt32 MonitorNum;
        public UInt32 Left;
        public UInt32 Right;
        public UInt32 Top;
        public UInt32 Bottom;
        public UInt32 FrameRate;
        public UInt32 ShowCursor;
        public UInt32 CaptureLayeredWindows;

        public static UScreenCaptureConfig CreateFromRegistry()
        {
            UScreenCaptureConfig ret = new UScreenCaptureConfig();

            ret.RegKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\UNREAL\Live\UScreenCapture", true);

            if (ret.RegKey == null)
                throw new Exception("A chave não existe no registro.");

            ret.MonitorNum = Convert.ToUInt32(ret.RegKey.GetValue("MonitorNum"));
            ret.Left = Convert.ToUInt32(ret.RegKey.GetValue("Left"));
            ret.Right = Convert.ToUInt32(ret.RegKey.GetValue("Right"));
            ret.Top = Convert.ToUInt32(ret.RegKey.GetValue("Top"));
            ret.Bottom = Convert.ToUInt32(ret.RegKey.GetValue("Bottom"));
            ret.FrameRate = Convert.ToUInt32(ret.RegKey.GetValue("FrameRate"));
            ret.ShowCursor = Convert.ToUInt32(ret.RegKey.GetValue("ShowCursor"));
            ret.CaptureLayeredWindows = Convert.ToUInt32(ret.RegKey.GetValue("CaptureLayeredWindows"));

            return ret;
        }

        public void SaveToRegistry()
        {
            RegKey.SetValue("MonitorNum", MonitorNum, RegistryValueKind.DWord);
            RegKey.SetValue("Left", Left, RegistryValueKind.DWord);
            RegKey.SetValue("Right", Right, RegistryValueKind.DWord);
            RegKey.SetValue("Top", Top, RegistryValueKind.DWord);
            RegKey.SetValue("Bottom", Bottom, RegistryValueKind.DWord);
            RegKey.SetValue("FrameRate", FrameRate, RegistryValueKind.DWord);
            RegKey.SetValue("ShowCursor", ShowCursor, RegistryValueKind.DWord);
            RegKey.SetValue("CaptureLayeredWindows", CaptureLayeredWindows, RegistryValueKind.DWord);
        }

        public string CreateStreamingURL()
        {
            string ret = String.Format("USCREEN://monitornum={0}&left={1}&top={2}&right={3}&bottom={4}&fps={5}&showcursor={6}&capturelayeredwindows={7}",
                MonitorNum, Left, Right, Top, Bottom, FrameRate, ShowCursor, CaptureLayeredWindows);

            return ret;
        }
    }
}
