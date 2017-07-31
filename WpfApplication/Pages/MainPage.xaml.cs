using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        BrowserPage browserPage;
        public MainPage()
        {
            InitializeComponent();
            browserPage = new BrowserPage();
        }


        private void businessButton_Click(object sender, RoutedEventArgs e)
        {
            var uri = new Uri("pack://application:,,,/Pages/Business/IndexPage.xaml");
            this.NavigationService.Navigate(uri);
        }

        private void profileButton_Click(object sender, RoutedEventArgs e)
        {
            //var uri = new Uri("pack://application:,,,/Pages/BrowserPage.xaml");
            this.NavigationService.Navigate(browserPage);
        }

        private void Page_Unloaded(object sender, RoutedEventArgs e)
        {
            
        }

     
    }
}
