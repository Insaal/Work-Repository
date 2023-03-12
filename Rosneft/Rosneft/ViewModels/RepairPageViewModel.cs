using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Rosneft.DialogsWindow;
using Rosneft.Helpers;

namespace Rosneft.ViewModels
{
    public class RepairPageViewModel:BaseViewModel
    {
        private readonly DataContext _context = new DataContext();
        private readonly DefaultDialogService _dialogService = new DefaultDialogService();
        private DataCollection _dataCollection;
        private RelayCommand _openAddRepair;
        private RelayCommand _openContinueRepair;


        public DataCollection DataCollection
        {
            get => _dataCollection;
            set
            {
                _dataCollection = value;
                OnPropertyChanged();
            }
        }

        public RepairPageViewModel()
        {
            try
            {
                if (DataCollection == null)
                    DataCollection = new DataCollection();
                DataCollection = _context.FillDataRepairPage(DataCollection);
            }
            catch (Exception e)
            {
                _dialogService.ShowMessage(e.Message, "Ошибка");
                throw;
            }
        }

        public RelayCommand OpenContinueRepairCommand
        {
            get
            {
                return _openContinueRepair ??
                       (_openContinueRepair = new RelayCommand(obj =>
                       {
                           var dWindow = new ContinueRepairWindow
                           {
                               Owner = Application.Current.MainWindow
                           };
                           dWindow.ShowDialog();
                       }));
            }
        }

        public RelayCommand OpenAddRepairCommand
        {
            get
            {
                return _openAddRepair ??
                       (_openAddRepair = new RelayCommand(obj =>
                       {
                           var dWindow = new AddRepairWindow
                           {
                               Owner = Application.Current.MainWindow
                           };
                           dWindow.ShowDialog();
                       }));
            }
        }

    }
}
