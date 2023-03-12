using System;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using Rosneft.DialogsWindow;
using Rosneft.Helpers;
using Rosneft.Properties;

namespace Rosneft
{
    public class ApplicationViewModel : BaseViewModel
    {
        private readonly DataContext _context = new DataContext();
        private readonly DefaultDialogService _dialogService = new DefaultDialogService();
        private EnteringData _entering = new EnteringData();
        private DataCollection _dataCollection;
        private RelayCommand _enterCommand;
        private RelayCommand _exitCommand;
        private RelayCommand<CancelEventArgs> _exitRelayCommand;
        private RelayCommand<SizeChangedEventArgs> _sizeChange;
        private RelayCommand _goRepair;
        private RelayCommand _goRepairArchive;
        private RelayCommand _goCalculationNorms;
        private RelayCommand _goTimeSheet;
        private RelayCommand _goDocuments;
        private RelayCommand _goChat;
        private RelayCommand _goAdmin;
        private RelayCommand _goMain;
        private double _btnWidth;
        private string[] _data;


        public double BtnWidth
        {
            get => _btnWidth;
            set
            {
                _btnWidth = value;
                OnPropertyChanged();
            }
        }

        public DataCollection DataCollection
        {
            get => _dataCollection;
            set
            {
                _dataCollection = value;
                OnPropertyChanged();
            }
        }

        public ApplicationViewModel()
        {
            //try
            //{
            //    DataCollection = new DataCollection();
            //    DataCollection = _context.FillData(DataCollection);
            //}
            //catch (Exception e)
            //{
            //    _dialogService.ShowMessage(e.Message, "Ошибка");
            //    throw;
            //}
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
                               if (_data.Any(a=>a.Length == 0))
                               {
                                   _dialogService.ShowMessage("Заполните поля", "Сообщение");
                                   return;
                               }

                               _entering = _context.Enter(_data[0], _data[1]);
                               if (_entering.Entering)
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

                                   _dialogService.ShowMessage(
                                       "Добро пожаловать " + _entering.Role + " " + _entering.UserName,
                                       "Сообщение");
                                   Application.Current.Windows[1]?.Hide();
                               }
                               else
                               {
                                   _dialogService.ShowMessage("Неправильный логин или пароль", "Сообщение");
                               }
                           }
                           catch (Exception e)
                           {
                               _dialogService.ShowMessage(e.Message, "Ошибка");
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
                           if (_dialogService.Close("Вы действительно хотите выйти?", "Выход"))
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
                           if (_dialogService.Exit("Вы действительно хотите выйти?", "Выход", obj))
                               Closing();
                           else
                               obj.Cancel = true;
                       }));
            }
        }

        public RelayCommand<SizeChangedEventArgs> SizeChange
        {
            get
            {
                return _sizeChange ??
                       (_sizeChange = new RelayCommand<SizeChangedEventArgs>(obj =>
                       {
                           BtnWidth = obj.NewSize.Width / 10;
                       }));
            }
        }

        public RelayCommand GoRepairCommand
        {
            get
            {
                return _goRepair ??
                       (_goRepair = new RelayCommand(obj => { Navigation.Navigate(Navigation.RepairPage); }));
            }
        }

        public RelayCommand GoRepairArchiveCommand
        {
            get
            {
                return _goRepairArchive ??
                       (_goRepairArchive = new RelayCommand(obj =>
                       {
                           Navigation.Navigate(Navigation.RepairArchivePage);
                       }));
            }
        }

        public RelayCommand GoCalculationNormsCommand
        {
            get
            {
                return _goCalculationNorms ??
                       (_goCalculationNorms = new RelayCommand(obj =>
                       {
                           Navigation.Navigate(Navigation.CalculationNormsPage);
                       }));
            }
        }

        public RelayCommand GoTimeSheetCommand
        {
            get
            {
                return _goTimeSheet ??
                       (_goTimeSheet = new RelayCommand(obj => { Navigation.Navigate(Navigation.TimeSheetPage); }));
            }
        }

        public RelayCommand GoDocumentsCommand
        {
            get
            {
                return _goDocuments ??
                       (_goDocuments = new RelayCommand(obj => { Navigation.Navigate(Navigation.DocumentsPage); }));
            }
        }

        public RelayCommand GoChatCommand
        {
            get
            {
                return _goChat ??
                       (_goChat = new RelayCommand(obj => { Navigation.Navigate(Navigation.ChatPage); }));
            }
        }

        public RelayCommand GoMain
        {
            get
            {
                return _goMain ??
                       (_goMain = new RelayCommand(obj => { Navigation.Navigate(Navigation.MainPage); }));
            }
        }

        public RelayCommand GoAdminCommand
        {
            get
            {
                return _goAdmin ??
                       (_goAdmin = new RelayCommand(obj => { Navigation.Navigate(Navigation.AdminPage); }));
            }
        }

        public void Closing()
        {
            Application.Current.Shutdown();
        }

    }
}