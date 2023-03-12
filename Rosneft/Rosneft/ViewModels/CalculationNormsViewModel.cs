using System;
using System.Windows;
using Rosneft.DialogsWindow;
using Rosneft.Helpers;

namespace Rosneft.ViewModels
{
    public class CalculationNormsViewModel : BaseViewModel
    {
        private readonly DataContext _context = new DataContext();
        private readonly DefaultDialogService _dialogService = new DefaultDialogService();
        private DataCollection _dataCollection;
        private RelayCommand _openCalculateWindow;
        private RelayCommand _openStandartOperation;

        public DataCollection DataCollection
        {
            get => _dataCollection;
            set
            {
                _dataCollection = value;
                OnPropertyChanged();
            }
        }

        public CalculationNormsViewModel()
        {
            try
            {
                if (DataCollection == null)
                    DataCollection = new DataCollection();
                DataCollection = _context.FillDataCalculationNormsPage(DataCollection);
            }
            catch (Exception e)
            {
                _dialogService.ShowMessage(e.Message, "Ошибка");
                throw;
            }
        }

        public RelayCommand OpenStandartOperationCommand
        {
            get
            {
                return _openStandartOperation ??
                       (_openStandartOperation = new RelayCommand(obj =>
                       {
                           var dWindow = new StandartOperationsWindow
                           {
                               Owner = Application.Current.MainWindow
                           };
                           dWindow.ShowDialog();
                       }));
            }
        }


        public RelayCommand OpenCalculateWindowCommand
        {
            get
            {
                return _openCalculateWindow ??
                       (_openCalculateWindow = new RelayCommand(obj =>
                       {
                           var dWindow = new CalculateWindow
                           {
                               Owner = Application.Current.MainWindow
                           };
                           dWindow.ShowDialog();
                       }));
            }
        }
    }
}