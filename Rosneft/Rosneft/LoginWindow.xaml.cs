using System;
using System.Windows;
using System.Windows.Controls;

namespace Rosneft
{
    public partial class LoginWindow : Window
    {
        private readonly DataContext context = new DataContext();
        public ApplicationViewModel ApplicationViewModel = new ApplicationViewModel();

        public LoginWindow()
        {
            InitializeComponent();
            DataContext = ApplicationViewModel;
        }

        //private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        //{
        //    //switch ((sender as Button).Content)
        //    //{
        //    //    case "Enter":
        //    //    {
        //    //        MessageBox.Show(ApplicationViewModel.InputLogginCollection.UserName);
        //    //            //if (tbUser.Text.Equals(String.Empty) || pbPassword.Password.Equals(String.Empty))
        //    //            //{
        //    //            //    MessageBox.Show("Fill login and password", "Warning", MessageBoxButton.OK,
        //    //            //        MessageBoxImage.Error);
        //    //            //    return;
        //    //            //}
        //    //            //context.Enter(tbUser.Text, pbPassword.Password);
        //    //            break;
        //    //        }
        //    //    case "Exit":
        //    //        {
        //    //            var result = MessageBox.Show("Do you want exit?", "Exit", MessageBoxButton.YesNo,
        //    //                MessageBoxImage.Question);

        //    //            if (result == MessageBoxResult.Yes) Application.Current.Shutdown();
        //    //            break;
        //    //        }
        //    }
       // }
       private void PbPassword_OnPasswordChanged(object sender, RoutedEventArgs e)
       {
           tbPassword.Text = pbPassword.Password;
       }
    }
}