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
    /// Interaction logic for FirstPage.xaml
    /// </summary>
    public partial class FirstPage : Page
    {
        BrowserPage browser;

        public FirstPage()
        {
            InitializeComponent();
            browser = new BrowserPage();
        }

        private void mediaPlayer_Loaded(object sender, RoutedEventArgs e)
        {
            this.mediaPlayer.Play();

        }

        private void mediaPlayer_MediaOpened(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //关闭视频，释放内存
            var uri = new Uri("pack://application:,,,/Pages/MainPage.xaml");
            this.NavigationService.Navigate(uri);
            this.mediaPlayer.Close();
        }

        private void mediaPlayer_MediaEnded(object sender, RoutedEventArgs e)
        {
            webStartBtn_Click(sender, e);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //this.mediaPlayer.Play();

        }

        private void webStartBtn_Click(object sender, RoutedEventArgs e)
        {
            //关闭视频，释放内存
            this.NavigationService.Navigate(browser);
            this.mediaPlayer.Close();
        }

        private void Page_Unloaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void mediaPlayer_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void mediaPlayer_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            webStartBtn_Click(sender, e);
        }
    }
}
