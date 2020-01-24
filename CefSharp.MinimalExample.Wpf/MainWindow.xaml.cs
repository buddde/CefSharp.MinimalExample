using System.Windows;
using CefSharp.WinForms;

namespace CefSharp.MinimalExample.Wpf
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowsFormsHost1.Child = new ChromiumWebBrowser("https://www.google.com");
            WindowsFormsHost2.Child = new ChromiumWebBrowser("https://www.inveos.com");
        }

        private void Left_OnClick(object sender, RoutedEventArgs e)
        {
            if (WindowsFormsHost1.Child is ChromiumWebBrowser chromiumWebBrowser)
            {
                Grid.Children.Remove(WindowsFormsHost1);
                chromiumWebBrowser.Dispose();
                WindowsFormsHost1.Child = null;
            }
        }

        private void Right_OnClick(object sender, RoutedEventArgs e)
        {
            if (WindowsFormsHost2.Child is ChromiumWebBrowser chromiumWebBrowser)
            {
                Grid.Children.Remove(WindowsFormsHost2);
                chromiumWebBrowser.Dispose();
                WindowsFormsHost2.Child = null;
            }
        }
    }
}
