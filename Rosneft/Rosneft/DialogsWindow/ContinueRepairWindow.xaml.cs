using System.Windows;
using Rosneft.ViewModels;

namespace Rosneft.DialogsWindow
{
    public partial class ContinueRepairWindow : Window
    {
        public ContinueRepairWindow()
        {
            InitializeComponent();
        }

        private void ContinueRepairWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            DataContext = new ContinueRepairViewModel();
        }
    }
}