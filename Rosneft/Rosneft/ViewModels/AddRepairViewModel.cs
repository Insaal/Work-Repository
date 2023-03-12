using System;
using System.Linq;
using System.Windows;
using Rosneft.Helpers;

namespace Rosneft.ViewModels
{
    public class AddRepairViewModel : BaseViewModel
    {
        private readonly DataContext _context = new DataContext();
        private readonly DefaultDialogService _dialogService = new DefaultDialogService();
        private DataCollection _dataCollection;
        private RelayCommand _closeDialogWindow;
        private RelayCommand _addRepair;
        private string[] _data;

        public DataCollection DataCollection
        {
            get => _dataCollection;
            set
            {
                _dataCollection = value;
                OnPropertyChanged("DataCollection");
            }
        }

        public AddRepairViewModel()
        {
            try
            {
                if (DataCollection == null)
                    DataCollection = new DataCollection();
                DataCollection = _context.FillDataAddRepairWindow(DataCollection);
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

        public RelayCommand AddRepairCommand
        {
            get
            {
                return _addRepair ??
                       (_addRepair = new RelayCommand(obj =>
                       {
                           var values = (Tuple<string, string, string, string, string>)obj;
                           _data = new[] { values.Item1, values.Item2, values.Item3, values.Item4, values.Item5};
                           if (_data.Any(a=>a.Length == 0))
                           {
                               _dialogService.ShowMessage("Заполните поля", "Сообщение");
                               return;
                           }

                           if (_context.ExistenceСheckRepair(_data))
                               _dialogService.ShowMessage("Такой ремонт уже существует","Сообщение");
                           else
                           {
                               _dialogService.ShowMessage("Ремонт успешно добавлен", "Сообщение");
                               DataCollection = new DataCollection();
                               DataCollection = _context.FillDataAddRepairWindow(DataCollection);
                           }
                           //_dialogService.ShowMessage(_context.ExistenceСheckRepair(_data).ToString(),"");
                           //_dialogService.ShowMessage(
                           //    values.Item1 + " " + values.Item2 + " " + values.Item3 + " " + values.Item4 + " " +
                           //    values.Item5 + " " + DateTime.Now.ToString("t"), "");
                       }));
            }
        }
    }
}