using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuwoMusic2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
       
        List<Song> songs = new List<Song>();

        bool isPalying = false;
        private void picPlayPause_Click(object sender, EventArgs e)
        {
            isPalying = !isPalying;
            if (isPalying)
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                picPlayPause.BackgroundImage=Properties.Resources.play;
            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                picPlayPause.BackgroundImage = Properties.Resources.pause;
            }
        }

        Lyric ly = new Lyric();
       
        int currentMusic = 0;

        private void button1_Click(object sender, EventArgs e)
        {

           

            //歌词载入进来

            //打开文件
            /*FileStream fs = new FileStream("陈一发儿-童话镇.lrc", FileMode.Open);

            //读文件
            Encoding encode = Encoding.GetEncoding("GB2312");
            StreamReader sr = new StreamReader(fs,encode);

            //一行一行的读
            string strLyric = "";
            int ypos = 0;
            while ((strLyric=sr.ReadLine())!=null)
            {
                string str = sr.ReadLine();
                //创建lable控件
                Label lblLyric = new Label();
                lblLyric.Width = 200;
                lblLyric.BackColor = Color.Transparent;
                lblLyric.Location = new Point(200, ypos);
                ypos += 30;

                lblLyric.Text = strLyric;
                this.Controls.Add(lblLyric);*/
            /*}*/

        }

        /*每100hm处理一次*/
        private void timer1_Tick(object sender, EventArgs e)
        {
            double curTime = axWindowsMediaPlayer1.Ctlcontrols.currentPosition;

            for (int i = 1; i < ly.lstLyrics.Count; i++)
            {
                if (ly.lstLyrics[i].time > curTime)
                {
                    lblLyric.Text = ly.lstLyrics[i - 1].text;
                    break;
                }
            }

            /*显示播放时间*/
            lblCurPlayTime.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
        }
        //加载歌曲
        private void Form1_Load(object sender, EventArgs e)
        {
            //第一首歌曲
            Song song1 = new Song();
            song1.name = "薛之谦";
            song1.album = "薛之谦";
            song1.mp3FileName = "薛之谦-演员.mp3";
            song1.lricFileName = "薛之谦-演员.lrc";
            song1.lstBgImages = new List<string>();
            song1.lstBgImages.Add("薛之谦1.jpeg");
            song1.lstBgImages.Add("薛之谦2.jpeg");
            song1.lstBgImages.Add("薛之谦3.jpeg");
            songs.Add(song1);
            //第二首歌曲
            Song song2 = new Song();
            song2.name = "童话镇";
            song2.album = "童话镇";
            song2.mp3FileName = "陈一发儿-童话镇.mp3";
            song2.lricFileName = "陈一发儿-童话镇.lrc";
            song2.lstBgImages = new List<string>();
            song2.lstBgImages.Add("陈一发1.jpg");
            song2.lstBgImages.Add("陈一发2.jpg");
            song2.lstBgImages.Add("陈一发3.jpg");
            songs.Add(song2);

        }
        //循环播放图片
        int imgIdx = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            imgIdx++;
            this.BackgroundImage = Image.FromFile(songs[currentMusic].lstBgImages[imgIdx%songs[currentMusic].lstBgImages.Count]);
        }
       
        private void lblSonginfo1_Click(object sender, EventArgs e)
        {
            //当前list序号
            currentMusic = 0;
      
            //设置背景图片
            this.BackgroundImage = Image.FromFile(songs[currentMusic].lstBgImages[currentMusic]);
            //歌词添加
            ly.Load(songs[currentMusic].lricFileName);
            //歌曲播放
            axWindowsMediaPlayer1.URL = songs[currentMusic].mp3FileName;
            axWindowsMediaPlayer1.Ctlcontrols.play();
            //进度条设置
            Color c = Color.Red;
            lblSongInfo2.ForeColor = c;

        }

        private void lblSongInfo2_Click(object sender, EventArgs e)
        {
            currentMusic = 1;


            this.BackgroundImage = Image.FromFile(songs[currentMusic].lstBgImages[currentMusic]);

            ly.Load(songs[currentMusic].lricFileName);
            axWindowsMediaPlayer1.URL = songs[currentMusic].mp3FileName;
            axWindowsMediaPlayer1.Ctlcontrols.play();
            Color c = Color.Red;
            lblSongInfo2.ForeColor = c;
        }

        private void lblLyric_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lblSongInfo2_Click( sender,  e);
            Color c = Color.Black;
            lblSonginfo1.ForeColor = c;
            c = Color.Red;
            lblSongInfo2.ForeColor = c;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            lblSonginfo1_Click(sender, e);
            Color c = Color.Black;
            lblSongInfo2.ForeColor = c;
            c = Color.Red;
            lblSonginfo1.ForeColor = c;
        }
    }
}