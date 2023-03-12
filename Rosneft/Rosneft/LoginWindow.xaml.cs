using System.Windows;
using Rosneft.Properties;

namespace Rosneft
{
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            TbUser.Text = Settings.Default.UserName;
            PbPassword.Password = Settings.Default.Password;
        }

        private void PbPassword_OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            TbPassword.Text = PbPassword.Password;
        }
    }
}