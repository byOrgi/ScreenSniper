using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Expression.Encoder;
using Microsoft.Expression.Encoder.Devices;
using Microsoft.Expression.Encoder.ScreenCapture;
using Microsoft.Expression.Encoder.Live;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading;

namespace screen_sniper_version_1
{
    public partial class Form1 : Form
    {
        public bool LabelEdit { get; set; }
        private ScreenCaptureJob gotu;
        string gotuOutput;
        string videosOutput;
        private string OutputPath;
        private bool Pause;
        private string jobPath;
        private bool withAudio;
        bool Rec = false;
        bool mic = true;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public Form1()
        {
            //Loading Screen Threads
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(3000);
            InitializeComponent();
            t.Abort();

            //Sets Main Form to Smaller Form
            this.ClientSize = new System.Drawing.Size(330, 70);

            //Sets up the Save Directory
            if (gotuOutput == "")
            {
                OutputPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\ScreenSnipr";
            }
            else
            {
                OutputPath = gotuOutput;
            }
            gotuOutput = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ScreenSnipr"; // Directory for jobs before encoding .
            videosOutput = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ScreenSnipr";     // Directory for Videos 

            if (!Directory.Exists(gotuOutput))
            {
                Directory.CreateDirectory(gotuOutput);
            }
            if (!Directory.Exists(gotuOutput))
            {
                Directory.CreateDirectory(gotuOutput);
            }
        }

        //Sets Loading Form as Start Form
        private void StartForm()
        {
            Application.Run(new LoadingScreen());
        }

        //Main Form Load Event
        private void Form1_Load(object sender, EventArgs e)
        {
            buttonpause.Enabled = false;
            btnrecord.Enabled = true;           
        }

        //Main Form Closing Event

        //file destinaton save path
        private void btnfilebrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                saveurl.Text = dialog.SelectedPath;
                OutputPath = dialog.SelectedPath;
                LoadJobsList(gotuOutput, listView1);
            }
        }

        //Updates Status Label Text
        private void saveurl_TextChanged(object sender, EventArgs e)
        {
            btnrecord.Enabled = true;
            txtstart.Text = "Press Record";
        }

        //Makes the Custom Toolbar Movable
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        //Makes the Custom Toolbar Movable (When Title/Label is clicked)
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        //Makes the Custom Toolbar Movable (When ICON is clicked)
        private void icon_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        //Closes the program
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        //Loads Saved captures to List
        void LoadJobsList(string Path, ListView list)
        {
            list.Clear();
            if (Directory.Exists(gotuOutput))
            {
                DirectoryInfo dir = new DirectoryInfo(gotuOutput);
                FileInfo[] files = dir.GetFiles().OrderByDescending(p => p.CreationTime).ToArray();
                foreach (FileInfo file in files)
                {
                    ListViewItem item = new ListViewItem(file.Name, 2);
                    item.SubItems.Add(file.FullName);
                    listView1.LabelEdit = true;
                    list.Items.Add(item);
                }
            }
        }

        //Opens and REFRESHES gridview
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            saveurl.Text = gotuOutput;
            if (this.Height == 70)
            {
                this.Height = 510;

                LoadJobsList(gotuOutput, listView1);

                if (this.Bottom > SystemInformation.WorkingArea.Bottom)
                {
                    this.Top = SystemInformation.WorkingArea.Bottom - this.Height;
                }
            }
            else
            {
                this.Height = 70;
            }
        }

        //pause button
        private void buttonpause_Click(object sender, EventArgs e)
        {
            gotu.Pause();
            txtstart.Text = "Video Paused...";
            buttonpause.Visible = false;
            btnresume.Visible = true;
        }

        //resume button
        private void btnresume_Click(object sender, EventArgs e)
        {
            gotu.Resume();
            txtstart.Text = "Recording...";
            btnresume.Visible = false;
            buttonpause.Visible = true;
        }

        //mic off
        private void btnmicoff_Click(object sender, EventArgs e)
        {            
            btnmicon.Visible = true;
            btnmicoff.Visible = false;
        }

        //mic on
        private void btnmicon_Click(object sender, EventArgs e)
        {
            btnmicon.Visible = false;
            btnmicoff.Visible = true;
        }

        //Start Capture
        private void btnrecord_Click_1(object sender, EventArgs e)
        {
            txtstart.Text = "Initializing...";

            if (!Rec)
            {
                StartRecording();
            }
            else
            {
                StopRecording();
            }

            btnrecord.Visible = false;
            btnstop.Visible = true;
            btnstop.Enabled = true;
            txtstart.Text = "Recording...";
            buttonpause.Enabled = true;

        }

        //STOP CAPTURE BUTTON
        private void btnstop_Click_1(object sender, EventArgs e)
        {
            if (gotu.Status == RecordStatus.Running)
            {
                txtstart.Text = "Video Saved!";
                gotu.Stop();
                btnrecord.Enabled = true;
                btnstop.Visible = false;
                btnrecord.Visible = true;
            }
        }

        //Starts Encoding Proccess
        private void buttonencode_Click(object sender, EventArgs e)
        {
            txtstart.Text = "Encoding...";
            bunifuProgressBar1.Value = 0;
            label2.Visible = true;
            label3.Visible = true;
            lblstage.Visible = true;
            lblvalue.Visible = true;
            lblvalue.Text = "0";
            lblstage.Text = "1 of 2";
            label3.Text = "Stage";
            this.Refresh();
            Encode(listView1.FocusedItem.SubItems[1].Text);
        }

        //watch recent captures by double clicking
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                try
                {
                    System.Diagnostics.Process.Start(listView1.SelectedItems[0].SubItems[1].Text.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //Right Click Listview items
        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listView1.FocusedItem.Bounds.Contains(e.Location))
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        //Deletes recent captures
        private void buttondelete_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                try
                {
                    File.Delete(listView1.FocusedItem.SubItems[1].Text.ToString());
                    listView1.FocusedItem.Remove();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //Capture, Audio and encoder settings 
        void StartCapturing(bool withAudio)
        {
            gotu = new ScreenCaptureJob(); // creat new job

            System.Drawing.Size FullScreen = SystemInformation.PrimaryMonitorSize; // for full screen area
            System.Drawing.Size WorkingArea = SystemInformation.WorkingArea.Size;  // for working area = (full screen - Taskbar )
            Rectangle captureRect;
            if (Properties.Settings.Default.CaptureRect == "Full Screen")
            {
                // captureRect = new Rectangle(0, 0, FullScreen.Width , FullScreen.Height); *** this line valid in Microsoft Expression Encoder 4 SP1 and invalid in SP2
                captureRect = new Rectangle(0, 0, FullScreen.Width - (FullScreen.Width % 4), FullScreen.Height - (FullScreen.Height % 4));
            }
            else
            {
                // captureRect = new Rectangle(0, 0, WorkingArea.Width , WorkingArea.Width); *** this line valid in Microsoft Expression Encoder 4 SP1 and invalid in SP2
                captureRect = new Rectangle(0, 0, WorkingArea.Width - (WorkingArea.Width % 4), WorkingArea.Height - (WorkingArea.Height % 4));
            }

            gotu.CaptureRectangle = captureRect;
            gotu.ShowFlashingBoundary = Properties.Settings.Default.ShowFlashing;
            gotu.ScreenCaptureVideoProfile.FrameRate = Properties.Settings.Default.FrameRate;
            gotu.ScreenCaptureVideoProfile.Quality = Properties.Settings.Default.Quality;
            gotu.CaptureMouseCursor = Properties.Settings.Default.CaptureMC;

            if (withAudio)
            {
                gotu.AddAudioDeviceSource(AudioDevices());
            }
            gotu.ShowCountdown = Properties.Settings.Default.ShowCountdown;
            gotu.OutputPath = gotuOutput;
            gotu.Start();
        }

        EncoderDevice AudioDevices()
        {
            EncoderDevice foundDevice = null;
            Collection<EncoderDevice> audioDevices = EncoderDevices.FindDevices(EncoderDeviceType.Audio);
            try
            {
                foundDevice = audioDevices.First();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Audio Device Not Found" + audioDevices[0].Name + ex.Message);
            }
            return foundDevice;
        }

        //start function
        void StartRecording()
        {
            Rec = true;
            btnresume.Enabled = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            StartCapturing(mic);
        }

        //stop function
        private void StopRecording()
        {
            gotu.Stop();
            gotu.Dispose();
            Rec = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
        }

        //Encoding Function 
        void Encode(string jobPath)
        {
            using (Job j = new Job())
            {

                MediaItem mediaItem = new MediaItem(jobPath);
                var size = mediaItem.OriginalVideoSize;
                WindowsMediaOutputFormat WMV_Format = new WindowsMediaOutputFormat();
                WMV_Format.VideoProfile = new Microsoft.Expression.Encoder.Profiles.AdvancedVC1VideoProfile();
                WMV_Format.AudioProfile = new Microsoft.Expression.Encoder.Profiles.WmaAudioProfile();
                WMV_Format.VideoProfile.AspectRatio = new System.Windows.Size(16, 9);
                WMV_Format.VideoProfile.AutoFit = true;

                if (size.Width >= 1920 && size.Height >= 1080)
                {
                    WMV_Format.VideoProfile.Size = new System.Drawing.Size(1920, 1080);
                    WMV_Format.VideoProfile.Bitrate = new Microsoft.Expression.Encoder.Profiles.VariableUnconstrainedBitrate(6000);
                }
                else if (size.Width >= 1280 && size.Height >= 720)
                {
                    WMV_Format.VideoProfile.Size = new System.Drawing.Size(1280, 720);
                    WMV_Format.VideoProfile.Bitrate = new Microsoft.Expression.Encoder.Profiles.VariableUnconstrainedBitrate(4000);
                }
                else
                {
                    WMV_Format.VideoProfile.Size = new System.Drawing.Size(size.Width, size.Height);
                    WMV_Format.VideoProfile.Bitrate = new Microsoft.Expression.Encoder.Profiles.VariableUnconstrainedBitrate(2000);
                }
                mediaItem.VideoResizeMode = VideoResizeMode.Letterbox;
                mediaItem.OutputFormat = WMV_Format;
                j.MediaItems.Add(mediaItem);
                j.CreateSubfolder = false;
                j.OutputDirectory = gotuOutput;
                j.EncodeProgress += new EventHandler<EncodeProgressEventArgs>(j_EncodeProgress);
                j.Encode();
            }
        }

            //Encoding Progress bar function
            private void j_EncodeProgress(object sender, EncodeProgressEventArgs e)
            {
                string Status = String.Format("{0:F1}%", e.Progress);
                int progressValue = Convert.ToInt16(e.Progress);
                bunifuProgressBar1.Value = progressValue;
                lblvalue.Text = Status;
                if (e.CurrentPass == 2)
                {
                    if (progressValue >= 100)
                    {
                        lblvalue.Visible = false;
                        lblstage.Visible = false;
                        label3.Visible = false;
                        label2.Text = "Encoded Successfully";
                    }
                    lblstage.Text = "2 of 2";
                    lblstage.Refresh();
                }

                bunifuProgressBar1.Refresh();
                lblvalue.Refresh();
                txtstart.Text = "Video Encoded";              
            }

        //updates the top status label
        private void btnencode_MouseDown(object sender, MouseEventArgs e)
        {
            txtstart.Text = "Encoding...";
        }

        //Opens up the settings menu
        private void btnsettings_Click(object sender, EventArgs e)
        {
            settingsform settings = new settingsform();
            settings.Show();
            settings.Text = "settingsform";
        }
    }
}

