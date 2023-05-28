using System.Windows;
using System.Windows.Controls;
using Rosneft.ViewModels;

namespace Rosneft.Pages
{
    public partial class CalculationNormsPage : Page
    {
        public CalculationNormsPage()
        {
            InitializeComponent();
        }

        private void CalculationNormsPage_OnLoaded(object sender, RoutedEventArgs e)
        {
            DataContext = new CalculationNormsViewModel();
        }
    }
}