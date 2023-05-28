using System.Windows;
using System.Windows.Controls;
using Rosneft.ViewModels;

namespace Rosneft.Pages
{
    public partial class RepairArchivePage : Page
    {
        public RepairArchivePage()
        {
            InitializeComponent();
        }

        private void RepairArchivePage_OnLoaded(object sender, RoutedEventArgs e)
        {
            DataContext = new RepairArchiveViewModel();
        }
    }
}