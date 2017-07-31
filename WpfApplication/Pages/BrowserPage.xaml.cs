using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication.Pages
{
    /// <summary>
    /// Interaction logic for BrowserPage.xaml
    /// </summary>
    public partial class BrowserPage : Page
    {
        private static readonly string _myPath = AppDomain.CurrentDomain.BaseDirectory;
        private static readonly string _pagesPath = System.IO.Path.Combine(_myPath, "Assets","Htmls");

        public BrowserPage()
        {
            InitializeComponent();
            string uri = new Uri(GetPagePath("index.html")).AbsoluteUri;
            this.webBrowser.Address = uri;
        }

        private string GetPagePath(string pageName)
        {
            return System.IO.Path.Combine(_pagesPath, pageName);
        }

        private void Page_Unloaded(object sender, RoutedEventArgs e)
        {
            this.webBrowser.Dispose();
        }
    }
}
