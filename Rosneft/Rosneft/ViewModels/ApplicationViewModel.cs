using System;
using System.ComponentModel;
using System.Windows;
using Rosneft.Helpers;
using Rosneft.Pages;
using Rosneft.Properties;

namespace Rosneft
{
    public class ApplicationViewModel : BaseViewModel
    {
        private readonly DataContext context = new DataContext();
        private readonly DefaultDialogService dialogService = new DefaultDialogService();
        private EnteringData entering = new EnteringData();
        private DataCollection _dataCollection;
        private RelayCommand _enterCommand;
        private RelayCommand _exitCommand;
        private RelayCommand _getMessage;
        private RelayCommand<CancelEventArgs> _exitRelayCommand;
        private RelayCommand _goAdmin;
        private RelayCommand _goMain;
        private string[] _data;

        public DataCollection DataCollection
        {
            get => _dataCollection;
            set
            {
                _dataCollection = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand GetMessage
        {
            get
            {
                return _getMessage ??
                       (_getMessage = new RelayCommand(obj =>
                       {
                       }));
            }
        }

        public ApplicationViewModel()
        {
            try
            {
                DataCollection = new DataCollection();
                DataCollection = context.FillData(DataCollection);

                //DataCollection = context.GetUsersCollection(DataCollection);
                //DataCollection = context.GetEmployeesCollection(DataCollection);
                //DataCollection = context.GetBushCollection(DataCollection);
                //DataCollection = context.GetFieldCollection(DataCollection);
                //DataCollection = context.GetDepartmentCollection(DataCollection);
                //DataCollection = context.GetPostCollection(DataCollection);
                //DataCollection = context.GetTeamCollection(DataCollection);
            }
            catch (Exception e)
            {
                dialogService.ShowMessage(e.Message, "Ошибка");
                throw;
            }
        }

        public RelayCommand EnterCommand
        {
            get
            {
                return _enterCommand ??
                       (_enterCommand = new RelayCommand(obj =>
                       {
                           try
                           {
                               var values = (Tuple<string, string, bool>)obj;
                               _data = new[] { values.Item1, values.Item2 };
                               if (_data[0] == string.Empty || _data[1] == string.Empty)
                               {
                                   dialogService.ShowMessage("Заполните поля", "Сообщение");
                                   return;
                               }

                               entering = context.Enter(_data[0], _data[1]);
                               if (entering.Entering)
                               {
                                   if (values.Item3)
                                   {
                                       Settings.Default.Login = _data[0];
                                       Settings.Default.Password = _data[1];
                                       Settings.Default.Save();
                                   }
                                   else
                                   {
                                       Settings.Default.Login = string.Empty;
                                       Settings.Default.Password = string.Empty;
                                       Settings.Default.Save();
                                   }

                                   dialogService.ShowMessage(
                                       "Добро пожаловать " + entering.Role + " " + entering.UserName,
                                       "Сообщение");
                                   Application.Current.Windows[1]?.Hide();
                               }
                               else
                               {
                                   dialogService.ShowMessage("Неправильный логин или пароль", "Сообщение");
                               }
                           }
                           catch (Exception e)
                           {
                               dialogService.ShowMessage(e.Message, "Ошибка");
                               throw;
                           }
                       }));
            }
        }

        public RelayCommand ExitCommand
        {
            get
            {
                return _exitCommand ??
                       (_exitCommand = new RelayCommand(obj =>
                       {
                           if (dialogService.Close("Вы действительно хотите выйти?", "Выход"))
                               Closing();
                       }));
            }
        }

        public RelayCommand<CancelEventArgs> ExitRelayCommand
        {
            get
            {
                return _exitRelayCommand ??
                       (_exitRelayCommand = new RelayCommand<CancelEventArgs>(obj =>
                       {
                           if (dialogService.Exit("Вы действительно хотите выйти?", "Выход", obj))
                               Closing();
                           else
                               obj.Cancel = true;
                       }));
            }
        }

        public RelayCommand GoMain
        {
            get
            {
                return _goMain ??
                       (_goMain = new RelayCommand(obj => { GoMainCommandExecute(); }));
            }
        }

        public RelayCommand GoAdminCommand
        {
            get
            {
                return _goAdmin ??
                       (_goAdmin = new RelayCommand(obj => { GoToAboutCommandExecute(); }));
            }
        }


        //public void LogginWindow_Closing(object sender, CancelEventArgs e)
        //{
        //    if (_closedlogginwindow == 1)
        //    {
        //        MessageBox.Show("HUI");
        //    }
        //    else
        //    if (dialogService.Exit("Вы действительно хотите выйти?", "Выход", e))
        //    {
        //        _closedlogginwindow = 1;
        //        Closing();
        //    }
        //    else
        //        e.Cancel = true;
        //}

        //public void MainWindow_Closing(object sender, CancelEventArgs e)
        //{
        //    if (_closedlogginwindow == 1)
        //    {
        //        MessageBox.Show("HUI");
        //    }
        //    if (_closedlogginwindow == 0)
        //    {
        //        Closing();
        //        if (dialogService.Exit("Вы действительно хотите выйти?", "Выход", e))
        //            Closing();
        //        else
        //            e.Cancel = true;
        //    }
        //}

        public void Closing()
        {
            Application.Current.Shutdown();
        }

        private void GoToAboutCommandExecute()
        {
            var page = new AdminPage();
            if (Application.Current.MainWindow != null) Application.Current.MainWindow.Title = page.Title;
            Navigation.Navigate(Navigation.AdminPage);
        }

        private void GoMainCommandExecute()
        {
            var page = new MainPage();
            Navigation.Navigate(Navigation.MainPage);
        }
    }
}