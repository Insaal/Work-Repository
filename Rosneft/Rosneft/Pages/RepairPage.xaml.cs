using System.Windows;
using System.Windows.Controls;
using Rosneft.ViewModels;

namespace Rosneft.Pages
{
    public partial class RepairPage : Page
    {
        public RepairPage()
        {
            InitializeComponent();
        }

        private void RepairPage_OnLoaded(object sender, RoutedEventArgs e)
        {
            DataContext = new RepairPageViewModel();
        }
    }
}