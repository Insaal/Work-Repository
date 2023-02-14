using System;
using System.Windows;
using Rosneft.Domain;
using System.Threading;
using System.Linq;
using Rosneft.Domain.Entities;

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
            LoginWindow loginWindow = new LoginWindow
            {
                Owner = this
            };
            loginWindow.Show();
        }
    }
}