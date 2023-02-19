using System;
using System.Windows;
using Rosneft.Helpers;
using Rosneft.Pages;

namespace Rosneft
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Navigation.Service = MainFrame.NavigationService;
            Navigation.Service.Navigate(new MainPage());
            var loginWindow = new LoginWindow
            {
                Owner = this
            };
            loginWindow.ShowDialog();
        }
    }
}