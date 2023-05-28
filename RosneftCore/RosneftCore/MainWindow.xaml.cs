﻿using System.Windows;

namespace RosneftCore
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
