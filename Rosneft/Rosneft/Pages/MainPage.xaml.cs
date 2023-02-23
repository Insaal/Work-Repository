using System.Windows;
using System.Windows.Controls;

namespace Rosneft.Pages
{
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_OnLoaded(object sender, RoutedEventArgs e)
        {
            DataContext = new ApplicationViewModel();
        }
    }
}