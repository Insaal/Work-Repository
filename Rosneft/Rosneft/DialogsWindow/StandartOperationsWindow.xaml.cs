using System.Windows;
using Rosneft.ViewModels;

namespace Rosneft.DialogsWindow
{
    public partial class StandartOperationsWindow : Window
    {
        public StandartOperationsWindow()
        {
            InitializeComponent();
        }

        private void StandartOperationsWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            DataContext = new StandartOperationViewModel();
        }
    }
}