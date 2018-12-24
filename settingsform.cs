using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace screen_sniper_version_1
{
    public partial class settingsform : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        bool drag;
        int mousex;
        int mousey;

        public settingsform()
        {
            InitializeComponent();
        }

        //closes settings form
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //makes custom toolbar moveable
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        //makes custom toolbar moveable
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        //makes custom toolbar moveable
        private void icon_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        //resets settings to defualt
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetSettings();
        }

        //saves settings
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveSettings();
            this.Close();
        }

        //save settings function
        void SaveSettings()
        {
            if (int.Parse(txtQuality.Text) > 100)
            {
                MessageBox.Show(" Quality must be an integer between 1 and 100 ", "HD-Screen Recorder", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtQuality.Focus();
                txtQuality.SelectAll();
                return;
            }
            Properties.Settings.Default.FrameRate = int.Parse(cboFrameRate.Text);
            Properties.Settings.Default.Quality = int.Parse(txtQuality.Text);
            if (cboCaptureMC.Text == "Yes")
                Properties.Settings.Default.CaptureMC = true;
            else
                Properties.Settings.Default.CaptureMC = false;
            Properties.Settings.Default.FollowMC = Convert.ToBoolean(chkFollowMC.CheckState);
            Properties.Settings.Default.CaptureRect = cboCaptureRect.Text;
            Properties.Settings.Default.ShowCountdown = Convert.ToBoolean(chkShowCountdown.CheckState);
            Properties.Settings.Default.ShowFlashing = Convert.ToBoolean(chkShowFashing.CheckState);
            Properties.Settings.Default.Save();
        }

        //reset settings function
        void ResetSettings()
        {
            cboFrameRate.Text = "15";
            txtQuality.Text = "95";
            cboCaptureMC.Text = "Yes";
            chkFollowMC.Checked = false;
            cboCaptureRect.Text = "Working Area";
            chkShowCountdown.Checked = true;
            chkShowFashing.Checked = true;
            SaveSettings();
        }

        //settings function
        void LoadSettings()
        {
            cboFrameRate.Text = Properties.Settings.Default.FrameRate.ToString();
            txtQuality.Text = Properties.Settings.Default.Quality.ToString();
            if (Properties.Settings.Default.CaptureMC == true)
                cboCaptureMC.Text = "Yes";
            else
                cboCaptureMC.Text = "NO";
            chkFollowMC.Checked = Properties.Settings.Default.FollowMC;
            cboCaptureRect.Text = Properties.Settings.Default.CaptureRect;
            chkShowCountdown.Checked = Properties.Settings.Default.ShowCountdown;
            chkShowFashing.Checked = Properties.Settings.Default.ShowFlashing;
        }
    }
}
