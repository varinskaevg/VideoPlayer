namespace Video
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            openfile = new ToolStripMenuItem();
            авторToolStripMenuItem = new ToolStripMenuItem();
            воликМаксим202ТКToolStripMenuItem = new ToolStripMenuItem();
            btnSetting = new ToolStripMenuItem();
            скоростьToolStripMenuItem = new ToolStripMenuItem();
            toolStripButton1 = new ToolStripMenuItem();
            toolStripButton2 = new ToolStripMenuItem();
            toolStripButton3 = new ToolStripMenuItem();
            toolStripButton4 = new ToolStripMenuItem();
            toolStripButton5 = new ToolStripMenuItem();
            toolStripButton6 = new ToolStripMenuItem();
            toolStripButton7 = new ToolStripMenuItem();
            качествоToolStripMenuItem = new ToolStripMenuItem();
            toolStrip8 = new ToolStripMenuItem();
            panel1 = new Panel();
            trackBar2 = new TrackBar();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            panel2 = new Panel();
            btnFull = new Button();
            label1 = new Label();
            btnVolume = new Button();
            trackBar1 = new TrackBar();
            left = new Button();
            rigt = new Button();
            btnPlay = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { openfile, авторToolStripMenuItem, btnSetting });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1026, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // openfile
            // 
            openfile.Image = (Image)resources.GetObject("openfile.Image");
            openfile.Name = "openfile";
            openfile.Size = new Size(143, 24);
            openfile.Text = "Відкрити файл";
            openfile.Click += openfile_Click;
            // 
            // авторToolStripMenuItem
            // 
            авторToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { воликМаксим202ТКToolStripMenuItem });
            авторToolStripMenuItem.Image = (Image)resources.GetObject("авторToolStripMenuItem.Image");
            авторToolStripMenuItem.Name = "авторToolStripMenuItem";
            авторToolStripMenuItem.Size = new Size(85, 24);
            авторToolStripMenuItem.Text = "Автор";
            // 
            // воликМаксим202ТКToolStripMenuItem
            // 
            воликМаксим202ТКToolStripMenuItem.Image = (Image)resources.GetObject("воликМаксим202ТКToolStripMenuItem.Image");
            воликМаксим202ТКToolStripMenuItem.Name = "воликМаксим202ТКToolStripMenuItem";
            воликМаксим202ТКToolStripMenuItem.Size = new Size(224, 26);
            воликМаксим202ТКToolStripMenuItem.Text = "Варинська Євгенія";
            // 
            // btnSetting
            // 
            btnSetting.DropDownItems.AddRange(new ToolStripItem[] { скоростьToolStripMenuItem, качествоToolStripMenuItem });
            btnSetting.Image = (Image)resources.GetObject("btnSetting.Image");
            btnSetting.Margin = new Padding(20, 0, 0, 0);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(34, 24);
            // 
            // скоростьToolStripMenuItem
            // 
            скоростьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3, toolStripButton4, toolStripButton5, toolStripButton6, toolStripButton7 });
            скоростьToolStripMenuItem.Image = (Image)resources.GetObject("скоростьToolStripMenuItem.Image");
            скоростьToolStripMenuItem.Name = "скоростьToolStripMenuItem";
            скоростьToolStripMenuItem.Size = new Size(156, 26);
            скоростьToolStripMenuItem.Text = "Скорость";
            // 
            // toolStripButton1
            // 
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(180, 26);
            toolStripButton1.Text = "0,25";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(180, 26);
            toolStripButton2.Text = "0,5";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(180, 26);
            toolStripButton3.Text = "0,75";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // toolStripButton4
            // 
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(180, 26);
            toolStripButton4.Text = "Стандарт(1х)";
            toolStripButton4.Click += toolStripButton4_Click;
            // 
            // toolStripButton5
            // 
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(180, 26);
            toolStripButton5.Text = "1,25";
            toolStripButton5.Click += toolStripButton5_Click;
            // 
            // toolStripButton6
            // 
            toolStripButton6.Name = "toolStripButton6";
            toolStripButton6.Size = new Size(180, 26);
            toolStripButton6.Text = "1,5";
            toolStripButton6.Click += toolStripButton6_Click;
            // 
            // toolStripButton7
            // 
            toolStripButton7.Name = "toolStripButton7";
            toolStripButton7.Size = new Size(180, 26);
            toolStripButton7.Text = "1,75";
            toolStripButton7.Click += toolStripButton7_Click;
            // 
            // качествоToolStripMenuItem
            // 
            качествоToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStrip8 });
            качествоToolStripMenuItem.Image = (Image)resources.GetObject("качествоToolStripMenuItem.Image");
            качествоToolStripMenuItem.Name = "качествоToolStripMenuItem";
            качествоToolStripMenuItem.Size = new Size(156, 26);
            качествоToolStripMenuItem.Text = "Качество";
            // 
            // toolStrip8
            // 
            toolStrip8.Name = "toolStrip8";
            toolStrip8.Size = new Size(125, 26);
            toolStrip8.Text = "360р";
            // 
            // panel1
            // 
            panel1.Controls.Add(trackBar2);
            panel1.Controls.Add(axWindowsMediaPlayer1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(1026, 634);
            panel1.TabIndex = 1;
            // 
            // trackBar2
            // 
            trackBar2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            trackBar2.Location = new Point(919, 434);
            trackBar2.Maximum = 100;
            trackBar2.Name = "trackBar2";
            trackBar2.Orientation = Orientation.Vertical;
            trackBar2.Size = new Size(56, 151);
            trackBar2.TabIndex = 3;
            trackBar2.TickStyle = TickStyle.None;
            trackBar2.Scroll += trackBar2_Scroll;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Dock = DockStyle.Fill;
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(0, 0);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(1026, 634);
            axWindowsMediaPlayer1.TabIndex = 2;
            axWindowsMediaPlayer1.PlayStateChange += axWindowsMediaPlayer1_PlayStateChange_1;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnFull);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnVolume);
            panel2.Controls.Add(trackBar1);
            panel2.Controls.Add(left);
            panel2.Controls.Add(rigt);
            panel2.Controls.Add(btnPlay);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 609);
            panel2.Name = "panel2";
            panel2.Size = new Size(1026, 53);
            panel2.TabIndex = 2;
            // 
            // btnFull
            // 
            btnFull.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFull.BackColor = Color.Transparent;
            btnFull.BackgroundImage = (Image)resources.GetObject("btnFull.BackgroundImage");
            btnFull.BackgroundImageLayout = ImageLayout.Zoom;
            btnFull.FlatAppearance.BorderSize = 0;
            btnFull.FlatStyle = FlatStyle.Flat;
            btnFull.Location = new Point(983, 10);
            btnFull.Name = "btnFull";
            btnFull.Size = new Size(31, 31);
            btnFull.TabIndex = 7;
            btnFull.UseVisualStyleBackColor = false;
            btnFull.Click += btnFull_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(157, 15);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 6;
            label1.Text = "0:00:00";
            // 
            // btnVolume
            // 
            btnVolume.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVolume.BackColor = Color.Transparent;
            btnVolume.BackgroundImage = (Image)resources.GetObject("btnVolume.BackgroundImage");
            btnVolume.BackgroundImageLayout = ImageLayout.Zoom;
            btnVolume.FlatAppearance.BorderSize = 0;
            btnVolume.FlatStyle = FlatStyle.Flat;
            btnVolume.Location = new Point(929, 10);
            btnVolume.Name = "btnVolume";
            btnVolume.Size = new Size(31, 31);
            btnVolume.TabIndex = 4;
            btnVolume.UseVisualStyleBackColor = false;
            btnVolume.Click += btnVolume_Click;
            // 
            // trackBar1
            // 
            trackBar1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            trackBar1.Location = new Point(288, 15);
            trackBar1.Maximum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.RightToLeft = RightToLeft.No;
            trackBar1.Size = new Size(627, 56);
            trackBar1.TabIndex = 3;
            trackBar1.TickStyle = TickStyle.None;
            trackBar1.Scroll += trackBar1_Scroll_1;
            // 
            // left
            // 
            left.BackColor = Color.Transparent;
            left.BackgroundImage = (Image)resources.GetObject("left.BackgroundImage");
            left.BackgroundImageLayout = ImageLayout.Zoom;
            left.FlatAppearance.BorderSize = 0;
            left.FlatStyle = FlatStyle.Flat;
            left.Location = new Point(64, 10);
            left.Name = "left";
            left.Size = new Size(31, 31);
            left.TabIndex = 2;
            left.UseVisualStyleBackColor = false;
            left.Click += left_Click;
            // 
            // rigt
            // 
            rigt.BackColor = Color.Transparent;
            rigt.BackgroundImage = (Image)resources.GetObject("rigt.BackgroundImage");
            rigt.BackgroundImageLayout = ImageLayout.Zoom;
            rigt.FlatAppearance.BorderSize = 0;
            rigt.FlatStyle = FlatStyle.Flat;
            rigt.Location = new Point(110, 10);
            rigt.Name = "rigt";
            rigt.Size = new Size(31, 31);
            rigt.TabIndex = 1;
            rigt.UseVisualStyleBackColor = false;
            rigt.Click += rigt_Click;
            // 
            // btnPlay
            // 
            btnPlay.BackColor = Color.Transparent;
            btnPlay.BackgroundImage = (Image)resources.GetObject("btnPlay.BackgroundImage");
            btnPlay.BackgroundImageLayout = ImageLayout.Zoom;
            btnPlay.FlatAppearance.BorderSize = 0;
            btnPlay.FlatStyle = FlatStyle.Flat;
            btnPlay.Location = new Point(12, 10);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(31, 31);
            btnPlay.TabIndex = 0;
            btnPlay.UseVisualStyleBackColor = false;
            btnPlay.Click += btnPlay_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 662);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "VideoPlay";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem openfile;
        private ToolStripMenuItem авторToolStripMenuItem;
        private ToolStripMenuItem воликМаксим202ТКToolStripMenuItem;
        private Panel panel1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private Panel panel2;
        private Button btnPlay;
        private TrackBar trackBar1;
        private Button left;
        private Button rigt;
        private Button btnVolume;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private TrackBar trackBar2;
        private ToolStripMenuItem btnSetting;
        private ToolStripMenuItem скоростьToolStripMenuItem;
        private ToolStripMenuItem toolStripButton1;
        private ToolStripMenuItem toolStripButton2;
        private ToolStripMenuItem toolStripButton3;
        private ToolStripMenuItem toolStripButton4;
        private ToolStripMenuItem toolStripButton5;
        private ToolStripMenuItem toolStripButton6;
        private ToolStripMenuItem toolStripButton7;
        private ToolStripMenuItem качествоToolStripMenuItem;
        private ToolStripMenuItem toolStrip8;
        private Button btnFull;
    }
}
