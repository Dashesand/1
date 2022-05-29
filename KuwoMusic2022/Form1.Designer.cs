namespace KuwoMusic2022
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BarSong = new System.Windows.Forms.ProgressBar();
            this.lblCurPlayTime = new System.Windows.Forms.Label();
            this.picPlayPause = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblLyric = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblSonginfo1 = new System.Windows.Forms.Label();
            this.lblSongInfo2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.BarSong);
            this.panel1.Controls.Add(this.lblCurPlayTime);
            this.panel1.Controls.Add(this.picPlayPause);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 436);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 86);
            this.panel1.TabIndex = 0;
            // 
            // BarSong
            // 
            this.BarSong.Location = new System.Drawing.Point(251, 40);
            this.BarSong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BarSong.Name = "BarSong";
            this.BarSong.Size = new System.Drawing.Size(287, 20);
            this.BarSong.TabIndex = 5;
            this.BarSong.Value = 50;
            this.BarSong.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // lblCurPlayTime
            // 
            this.lblCurPlayTime.AutoSize = true;
            this.lblCurPlayTime.BackColor = System.Drawing.Color.Transparent;
            this.lblCurPlayTime.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCurPlayTime.ForeColor = System.Drawing.Color.White;
            this.lblCurPlayTime.Location = new System.Drawing.Point(692, 35);
            this.lblCurPlayTime.Name = "lblCurPlayTime";
            this.lblCurPlayTime.Size = new System.Drawing.Size(90, 25);
            this.lblCurPlayTime.TabIndex = 4;
            this.lblCurPlayTime.Text = "label1";
            // 
            // picPlayPause
            // 
            this.picPlayPause.BackColor = System.Drawing.Color.Transparent;
            this.picPlayPause.BackgroundImage = global::KuwoMusic2022.Properties.Resources.play;
            this.picPlayPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayPause.Location = new System.Drawing.Point(56, 28);
            this.picPlayPause.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picPlayPause.Name = "picPlayPause";
            this.picPlayPause.Size = new System.Drawing.Size(56, 47);
            this.picPlayPause.TabIndex = 1;
            this.picPlayPause.TabStop = false;
            this.picPlayPause.Click += new System.EventHandler(this.picPlayPause_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(811, 60);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(178, 83);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 21);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(797, 88);
            this.axWindowsMediaPlayer1.TabIndex = 2;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // lblLyric
            // 
            this.lblLyric.BackColor = System.Drawing.Color.Transparent;
            this.lblLyric.Font = new System.Drawing.Font("宋体", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLyric.ForeColor = System.Drawing.Color.DarkRed;
            this.lblLyric.Location = new System.Drawing.Point(135, 236);
            this.lblLyric.Name = "lblLyric";
            this.lblLyric.Size = new System.Drawing.Size(805, 47);
            this.lblLyric.TabIndex = 4;
            this.lblLyric.Text = "label1";
            this.lblLyric.Click += new System.EventHandler(this.lblLyric_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 3000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblSonginfo1
            // 
            this.lblSonginfo1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSonginfo1.Location = new System.Drawing.Point(-3, 360);
            this.lblSonginfo1.Name = "lblSonginfo1";
            this.lblSonginfo1.Size = new System.Drawing.Size(164, 43);
            this.lblSonginfo1.TabIndex = 5;
            this.lblSonginfo1.Text = "薛之谦-演员";
            this.lblSonginfo1.Click += new System.EventHandler(this.lblSonginfo1_Click);
            // 
            // lblSongInfo2
            // 
            this.lblSongInfo2.Location = new System.Drawing.Point(-3, 403);
            this.lblSongInfo2.Name = "lblSongInfo2";
            this.lblSongInfo2.Size = new System.Drawing.Size(164, 31);
            this.lblSongInfo2.TabIndex = 6;
            this.lblSongInfo2.Text = "陈一发儿-童话镇";
            this.lblSongInfo2.Click += new System.EventHandler(this.lblSongInfo2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::KuwoMusic2022.Properties.Resources.widget91_next_press;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(118, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 47);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::KuwoMusic2022.Properties.Resources.widget91_pre_press;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(3, 28);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 47);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KuwoMusic2022.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(805, 522);
            this.Controls.Add(this.lblSongInfo2);
            this.Controls.Add(this.lblSonginfo1);
            this.Controls.Add(this.lblLyric);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.PictureBox picPlayPause;
        private System.Windows.Forms.Label lblLyric;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblCurPlayTime;
        private System.Windows.Forms.ProgressBar BarSong;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblSonginfo1;
        private System.Windows.Forms.Label lblSongInfo2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

