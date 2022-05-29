using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuwoMusic2022
{
    /*每行歌词*/
    class LyricLine
    {
        public double time;
        public string text;
    }

    /*歌词*/
     class Lyric
    {
        public List<LyricLine> lstLyrics = new List<LyricLine>();

        public void Load(string fileName)
        {
            lstLyrics.Clear();
            //打开文件
            FileStream fs = new FileStream(fileName, FileMode.Open);


            //读文件
            Encoding encode = Encoding.GetEncoding("GB2312");
            StreamReader sr = new StreamReader(fs, encode);
            
            //一行一行的读
            string strLyric = "";
            int ypos = 0;
            while ((strLyric = sr.ReadLine()) != null)
            {
                if (strLyric.Equals(""))
                {
                    continue;
                }
                LyricLine ll = new LyricLine();
                string strTime = strLyric.Substring(0, 10);
                double time = Int32.Parse(strTime.Substring(1, 2)) * 60 + double.Parse(strTime.Substring(4, 5));
                ll.time = time;
                ll.text = strLyric.Substring(10);
                lstLyrics.Add(ll);
            }
            
            //关闭文件
            sr.Close();
            fs.Close();
           
        }
    }
}
