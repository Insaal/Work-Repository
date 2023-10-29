using System.Windows;
using System.Windows.Controls;

namespace Rosneft.Pages
{
    public partial class DocumentsPage : Page
    {
        public DocumentsPage()
        {
            InitializeComponent();
        }

        private void DocumentsPage_OnLoaded(object sender, RoutedEventArgs e)
        {
            DataContext = new ApplicationViewModel();
        }
    }
}