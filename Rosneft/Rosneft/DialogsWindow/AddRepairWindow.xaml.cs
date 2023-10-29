using System.Windows;
using Rosneft.ViewModels;

namespace Rosneft.DialogsWindow
{
    public partial class AddRepairWindow : Window
    {
        public AddRepairWindow()
        {
            InitializeComponent();
        }

        private void AddRepairWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            DataContext = new AddRepairViewModel();
        }
    }
}