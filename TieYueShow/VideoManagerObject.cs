using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TieYueShow
{

    public class VideoManagerObject
    {
        public class AsyncVideoManagerObject
        {
            //We expect an exception here, so tell VS to ignore
            [DebuggerHidden]
            public void Error()
            {
                throw new Exception("This is an exception coming from C#");
            }

            //读取视频数据文件，返回数据给JS,
            [DebuggerHidden]
            public string[] VideoFiles( )
            {
                var files = new[] { "铁越示例视频##videos/fengcai/sample.jpg##videos/fengcai/sample.webm" };
               string path = Path.Combine(BrowserForm.HtmlRootPath, "videos.dat");
               string[] lines = null;

               if (File.Exists(path))
               {
                   lines = System.IO.File.ReadAllLines(path);
                   //删除所有#开头的注释
                   lines = lines.Where(o => (!o.StartsWith("#")) && o.Contains("##")).ToArray();
               }

               return lines;//String.Join("\n",lines);
            }
        }
    }
}
