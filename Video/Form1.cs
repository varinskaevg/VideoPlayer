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
            // Додаємо обробники подій для ToolStripButtons
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
            // Встановлюємо обробник події PlayStateChange для оновлення тривалості відео
            axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(axWindowsMediaPlayer1_PlayStateChange_1);

            // Ініціалізація та запуск таймера для оновлення положення трекбара під час відтворення відео
            timer1.Interval = 1000; // Оновлення кожну секунду
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();

            // Підключення обробника події Scroll для trackBar1
            trackBar1.Scroll += new EventHandler(trackBar1_Scroll_1);

            // Ініціалізація налаштувань для trackBar2 (гучність)
            trackBar2.Scroll += new EventHandler(trackBar2_Scroll);
            trackBar2.Minimum = 0;
            trackBar2.Maximum = 100;
            trackBar2.Value = 50; // Початкове значення гучності
            trackBar2.Visible = false; // Робимо невидимим при завантаженні форми

            // Підключення обробника події для кнопки гучності
            btnVolume.Click += new EventHandler(btnVolume_Click);
        }

        private void axWindowsMediaPlayer1_PlayStateChange_1(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (axWindowsMediaPlayer1.currentMedia != null)
            {
                trackBar1.Maximum = (int)axWindowsMediaPlayer1.currentMedia.duration;

                // Оновлюємо label1 відповідно до тривалості відео


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

            // Встановлення фільтрів для файлів відео
            openFileDialog.Filter = "Video Files|*.mp4;*.avi;*.wmv;*.mov;*.mkv|All Files|*.*";
            openFileDialog.Title = "Select a Video File";

            // Відкриття діалогового вікна для вибору файлу
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Отримання шляху до вибраного файлу
                string selectedFilePath = openFileDialog.FileName;

                // Встановлення шляху до файлу як джерела для axWindowsMediaPlayer1
                axWindowsMediaPlayer1.URL = selectedFilePath;

                // Відтворення відео
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            // Перевірка стану плеєра
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                // Якщо відео відтворюється, зупиняємо його
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                btnPlay.Text = ""; // Змінюємо текст кнопки на "Play"
            }
            else if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused ||
                     axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                // Якщо відео зупинено або на паузі, відтворюємо його
                axWindowsMediaPlayer1.Ctlcontrols.play();
                btnPlay.Text = ""; // Змінюємо текст кнопки на "Pause"
            }
        }

        private void left_Click(object sender, EventArgs e)
        {
            // Перемотування відео назад на 10 секунд
            if (axWindowsMediaPlayer1.currentMedia != null)
            {
                double currentPosition = axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
                double newPosition = currentPosition - 10.0;
                if (newPosition < 0) newPosition = 0; // Уникнення негативного значення
                axWindowsMediaPlayer1.Ctlcontrols.currentPosition = newPosition;
                trackBar1.Value = (int)newPosition;
            }

        }

        private void rigt_Click(object sender, EventArgs e)
        {
            // Перемотування відео вперед на 10 секунд
            if (axWindowsMediaPlayer1.currentMedia != null)
            {
                double currentPosition = axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
                double duration = axWindowsMediaPlayer1.currentMedia.duration;
                double newPosition = currentPosition + 10.0;
                if (newPosition > duration) newPosition = duration; // Уникнення перевищення тривалості відео
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
                // Оновлюємо положення трекбара відповідно до поточної позиції відтворення
                if (axWindowsMediaPlayer1.currentMedia != null)
                {
                    trackBar1.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;

                    // Отримуємо поточний час відтворення
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
            // Зміна швидкості відтворення на 0.25
            axWindowsMediaPlayer1.settings.rate = 0.25;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            // Зміна швидкості відтворення на 0.5
            axWindowsMediaPlayer1.settings.rate = 0.5;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            // Зміна швидкості відтворення на 0.75
            axWindowsMediaPlayer1.settings.rate = 0.75;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            // Зміна швидкості відтворення на 1
            axWindowsMediaPlayer1.settings.rate = 1;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            // Зміна швидкості відтворення на 1.25
            axWindowsMediaPlayer1.settings.rate = 1.25;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            // Зміна швидкості відтворення на 1.5
            axWindowsMediaPlayer1.settings.rate = 1.5;
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            // Зміна швидкості відтворення на 1.75
            axWindowsMediaPlayer1.settings.rate = 1.75;
        }

        private void btnFull_Click(object sender, EventArgs e)
        {
            if (isFullScreen)
            {
                // Відновлюємо попередній стан вікна
                this.FormBorderStyle = previousFormBorderStyle;
                this.WindowState = previousWindowState;
                this.Bounds = previousBounds;
                isFullScreen = false;
            }
            else
            {
                // Зберігаємо поточний стан вікна
                previousWindowState = this.WindowState;
                previousFormBorderStyle = this.FormBorderStyle;
                previousBounds = this.Bounds;

                // Перемикаємося в повноекранний режим
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                isFullScreen = true;
            }
        }
    }
}
