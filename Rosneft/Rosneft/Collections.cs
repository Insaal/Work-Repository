using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Rosneft
{
    public class InputLogginCollection : INotifyPropertyChanged
    {
        private string _userName;
        private string _userPassword;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; OnPropertyChanged("UserName"); }
        }

        public string UserPassword
        {
            get { return _userPassword; }
            set { _userPassword = value; OnPropertyChanged("UserPassword"); }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
