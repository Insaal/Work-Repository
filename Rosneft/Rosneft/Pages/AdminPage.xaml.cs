using System.Windows;
using System.Windows.Controls;
using Rosneft.ViewModels;

namespace Rosneft.Pages
{
    public partial class AdminPage : Page
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void AdminPage_OnLoaded(object sender, RoutedEventArgs e)
        {
            DataContext = new AdminPageViewModel();
        }
    }
}