using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rosneft.Helpers;

namespace Rosneft.ViewModels
{
    public class AdminPageViewModel : BaseViewModel
    {
        private readonly DataContext _context = new DataContext();
        private readonly DefaultDialogService _dialogService = new DefaultDialogService();
        private DataCollection _dataCollection;

        public DataCollection DataCollection
        {
            get => _dataCollection;
            set
            {
                _dataCollection = value;
                OnPropertyChanged();
            }
        }

        public AdminPageViewModel()
        {
            try
            {
                if (DataCollection == null)
                    DataCollection = new DataCollection();
                DataCollection = _context.FillDataAdminPage(DataCollection);
            }
            catch (Exception e)
            {
                _dialogService.ShowMessage(e.Message, "Ошибка");
                throw;
            }
        }

    }
}
