using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuwoMusic2022
{
    class Song
    {
        public string name;  //歌曲名称
        public string album;  //专辑名称
        public string singerName;  //歌手名称
        public string mp3FileName;  //MP3文件名称及位置
        public string lricFileName;    //歌词文件名称
        public List<string> lstBgImages;   //封面图片
    }
}
