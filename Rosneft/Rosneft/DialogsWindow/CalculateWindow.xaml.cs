using System.Windows;
using Rosneft.ViewModels;

namespace Rosneft.DialogsWindow
{
    public partial class CalculateWindow : Window
    {
        public CalculateWindow()
        {
            InitializeComponent();
        }

        private void CalculateWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            DataContext = new CalculateViewModel();
        }
    }
}