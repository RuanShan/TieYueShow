using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TieYueShow
{
    class BoundObject
    {
        public void OnFrameLoadEnd(object sender, FrameLoadEndEventArgs e)
        {
            if ( e.Frame.IsMain)
            {
                e.Frame.ExecuteJavaScriptAsync(@"
                    var exitBtn = document.getElementById('exit_btn');
                    if( exitBtn != null){
                        exitBtn.addEventListener('click',function(){
                            c_bound.onTrigger( 'exit' );

                        });
                    }
                ");
            }
        }

        public void OnSelected(string selected)
        {
            MessageBox.Show("The user selected some text [" + selected + "]");
        }

        public void OnTrigger(string e)
        {
            //MessageBox.Show(string.Format("trigger: {0}", e));
            if (e == "exit")
            {
                Application.Exit();
            }
            else { 
                MessageBox.Show( string.Format( "trigger: {0}", e));
            }
        }
    }
}
