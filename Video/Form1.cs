namespace Video
{
    public partial class Form1 : Form
    {
        private bool isTrackBarUpdating = false;
        private bool isPlaying = false;
        private bool isFullScreen = false;
        private FormWindowState previousWindowState;
        private FormBorderStyle previousFormBorderStyle;
        private Rectangle previousBounds;

        public Form1()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            // ������ ��������� ���� ��� ToolStripButtons
            toolStripButton1.Click += new EventHandler(toolStripButton1_Click);
            toolStripButton2.Click += new EventHandler(toolStripButton2_Click);
            toolStripButton3.Click += new EventHandler(toolStripButton3_Click);
            toolStripButton4.Click += new EventHandler(toolStripButton4_Click);
            toolStripButton5.Click += new EventHandler(toolStripButton5_Click);
            toolStripButton6.Click += new EventHandler(toolStripButton6_Click);
            toolStripButton7.Click += new EventHandler(toolStripButton7_Click);
            trackBar2.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ������������ �������� ��䳿 PlayStateChange ��� ��������� ��������� ����
            axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(axWindowsMediaPlayer1_PlayStateChange_1);

            // ����������� �� ������ ������� ��� ��������� ��������� �������� �� ��� ���������� ����
            timer1.Interval = 1000; // ��������� ����� �������
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();

            // ϳ��������� ��������� ��䳿 Scroll ��� trackBar1
            trackBar1.Scroll += new EventHandler(trackBar1_Scroll_1);

            // ����������� ����������� ��� trackBar2 (�������)
            trackBar2.Scroll += new EventHandler(trackBar2_Scroll);
            trackBar2.Minimum = 0;
            trackBar2.Maximum = 100;
            trackBar2.Value = 50; // ��������� �������� �������
            trackBar2.Visible = false; // ������ ��������� ��� ����������� �����

            // ϳ��������� ��������� ��䳿 ��� ������ �������
            btnVolume.Click += new EventHandler(btnVolume_Click);
        }

        private void axWindowsMediaPlayer1_PlayStateChange_1(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (axWindowsMediaPlayer1.currentMedia != null)
            {
                trackBar1.Maximum = (int)axWindowsMediaPlayer1.currentMedia.duration;

                // ��������� label1 �������� �� ��������� ����


                if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    isPlaying = true;
                    TimeSpan duration = TimeSpan.FromSeconds(axWindowsMediaPlayer1.currentMedia.duration);
                    label1.Text = "00:00:00 / " + duration.ToString(@"hh\:mm\:ss");
                    timer1.Start();
                }
                else
                {
                    isPlaying = false;
                }
            }
        }

        private void openfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // ������������ ������� ��� ����� ����
            openFileDialog.Filter = "Video Files|*.mp4;*.avi;*.wmv;*.mov;*.mkv|All Files|*.*";
            openFileDialog.Title = "Select a Video File";

            // ³������� ���������� ���� ��� ������ �����
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // ��������� ����� �� ��������� �����
                string selectedFilePath = openFileDialog.FileName;

                // ������������ ����� �� ����� �� ������� ��� axWindowsMediaPlayer1
                axWindowsMediaPlayer1.URL = selectedFilePath;

                // ³��������� ����
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            // �������� ����� �����
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                // ���� ���� ������������, ��������� ����
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                btnPlay.Text = ""; // ������� ����� ������ �� "Play"
            }
            else if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused ||
                     axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                // ���� ���� �������� ��� �� ����, ���������� ����
                axWindowsMediaPlayer1.Ctlcontrols.play();
                btnPlay.Text = ""; // ������� ����� ������ �� "Pause"
            }
        }

        private void left_Click(object sender, EventArgs e)
        {
            // ������������� ���� ����� �� 10 ������
            if (axWindowsMediaPlayer1.currentMedia != null)
            {
                double currentPosition = axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
                double newPosition = currentPosition - 10.0;
                if (newPosition < 0) newPosition = 0; // ��������� ����������� ��������
                axWindowsMediaPlayer1.Ctlcontrols.currentPosition = newPosition;
                trackBar1.Value = (int)newPosition;
            }

        }

        private void rigt_Click(object sender, EventArgs e)
        {
            // ������������� ���� ������ �� 10 ������
            if (axWindowsMediaPlayer1.currentMedia != null)
            {
                double currentPosition = axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
                double duration = axWindowsMediaPlayer1.currentMedia.duration;
                double newPosition = currentPosition + 10.0;
                if (newPosition > duration) newPosition = duration; // ��������� ����������� ��������� ����
                axWindowsMediaPlayer1.Ctlcontrols.currentPosition = newPosition;
                trackBar1.Value = (int)newPosition;
            }
        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                isTrackBarUpdating = true;
                axWindowsMediaPlayer1.Ctlcontrols.currentPosition = trackBar1.Value;
                isTrackBarUpdating = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying && !isTrackBarUpdating)
            {
                // ��������� ��������� �������� �������� �� ������� ������� ����������
                if (axWindowsMediaPlayer1.currentMedia != null)
                {
                    trackBar1.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;

                    // �������� �������� ��� ����������
                    TimeSpan currentPosition = TimeSpan.FromSeconds(axWindowsMediaPlayer1.Ctlcontrols.currentPosition);
                    TimeSpan duration = TimeSpan.FromSeconds(axWindowsMediaPlayer1.currentMedia.duration);
                    label1.Text = $"{currentPosition.Hours:00}:{currentPosition.Minutes:00}:{currentPosition.Seconds:00} / {duration.ToString(@"hh\:mm\:ss")}";
                }
            }
        }

        private void btnVolume_Click(object sender, EventArgs e)
        {
            trackBar2.Visible = !trackBar2.Visible;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = trackBar2.Value;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // ���� �������� ���������� �� 0.25
            axWindowsMediaPlayer1.settings.rate = 0.25;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            // ���� �������� ���������� �� 0.5
            axWindowsMediaPlayer1.settings.rate = 0.5;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            // ���� �������� ���������� �� 0.75
            axWindowsMediaPlayer1.settings.rate = 0.75;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            // ���� �������� ���������� �� 1
            axWindowsMediaPlayer1.settings.rate = 1;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            // ���� �������� ���������� �� 1.25
            axWindowsMediaPlayer1.settings.rate = 1.25;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            // ���� �������� ���������� �� 1.5
            axWindowsMediaPlayer1.settings.rate = 1.5;
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            // ���� �������� ���������� �� 1.75
            axWindowsMediaPlayer1.settings.rate = 1.75;
        }

        private void btnFull_Click(object sender, EventArgs e)
        {
            if (isFullScreen)
            {
                // ³��������� ��������� ���� ����
                this.FormBorderStyle = previousFormBorderStyle;
                this.WindowState = previousWindowState;
                this.Bounds = previousBounds;
                isFullScreen = false;
            }
            else
            {
                // �������� �������� ���� ����
                previousWindowState = this.WindowState;
                previousFormBorderStyle = this.FormBorderStyle;
                previousBounds = this.Bounds;

                // ������������ � ������������� �����
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                isFullScreen = true;
            }
        }
    }
}
