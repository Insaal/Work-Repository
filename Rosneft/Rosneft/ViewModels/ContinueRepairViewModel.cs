using System;
using System.Windows;
using Rosneft.Helpers;

namespace Rosneft.ViewModels
{
    public class ContinueRepairViewModel : BaseViewModel
    {
        private readonly DataContext _context = new DataContext();
        private readonly DefaultDialogService _dialogService = new DefaultDialogService();
        private DataCollection _dataCollection;
        private RelayCommand _closeDialogWindow;

        public DataCollection DataCollection
        {
            get => _dataCollection;
            set
            {
                _dataCollection = value;
                OnPropertyChanged();
            }
        }

        public ContinueRepairViewModel()
        {
            try
            {
                if (DataCollection == null)
                    DataCollection = new DataCollection();
                DataCollection = _context.FillDataContinueRepairWindow(DataCollection);
            }
            catch (Exception e)
            {
                _dialogService.ShowMessage(e.Message, "Ошибка");
                throw;
            }
        }

        public RelayCommand CloseDialogWindowCommand
        {
            get
            {
                return _closeDialogWindow ??
                       (_closeDialogWindow = new RelayCommand(obj =>
                       {
                           var a = obj as Window;
                           a.Close();
                       }));
            }
        }
    }
}