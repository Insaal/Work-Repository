using Rosneft.Helpers;

namespace Rosneft
{
    public class InputLogginCollection : BaseViewModel
    {
        private string _userName;
        private string _userPassword;

        public string UserName
        {
            get => _userName;
            set
            {
                _userName = value;
                OnPropertyChanged();
            }
        }

        public string UserPassword
        {
            get => _userPassword;
            set
            {
                _userPassword = value;
                OnPropertyChanged();
            }
        }
    }
}