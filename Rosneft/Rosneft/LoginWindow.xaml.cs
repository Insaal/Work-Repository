using System.Windows;
using Rosneft.Properties;

namespace Rosneft
{
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            tbUser.Text = Settings.Default.UserName;
            pbPassword.Password = Settings.Default.Password;
        }

        private void PbPassword_OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            tbPassword.Text = pbPassword.Password;
        }
    }
}