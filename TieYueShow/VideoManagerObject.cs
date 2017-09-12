using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            //We expect an exception here, so tell VS to ignore
            [DebuggerHidden]
            public string[] VideoFiles( )
            {
                var files = new[]{ "特大喜讯,sample.webm,sample.jpg" };
                
                return files;
            }
        }
    }
}
