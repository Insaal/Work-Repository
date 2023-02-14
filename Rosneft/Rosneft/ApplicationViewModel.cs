using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Rosneft
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        private readonly DataContext context = new DataContext();
        private RelayCommand _getMessage;
        private string[] data;


        public RelayCommand GetMessage
        {
            get
            {
                return _getMessage ??
                       (_getMessage = new RelayCommand(obj =>
                       {
                           var values = (Tuple<String, String>)obj;
                           data = new string[] { values.Item1, values.Item2 };
                           context.Enter(data[0], data[1]);
                       }));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }

    public class RelayCommand : ICommand
    {
        #region Fields
        private Action<object> execute;
        private Func<object, bool> canExecute;
        #endregion

        #region Constructor
        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }
        #endregion

        #region ICommand Implementation
        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }
        public bool CanExecute(object parameter)
        {
            return this.canExecute == null || this.canExecute(parameter);
        }
        public void Execute(object parameter)
        {
            this.execute(parameter);
        }
        #endregion
    }

}
