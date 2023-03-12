using System;
using System.Collections.ObjectModel;
using Rosneft.Domain.Repository;

namespace Rosneft
{
    public class DataContext
    {
        public EnteringData Enter(string user, string password)
        {
            return RepositoryClass.AuthorizationUser(user, password);
        }

        public DataCollection FillData(DataCollection data)
        {
            return RepositoryClass.GetData(data);
        }

        public DataCollection FillDataAdminPage(DataCollection data)
        {
            return RepositoryClass.FillDataToAdminPage(data);
        }

        public DataCollection FillDataRepairPage(DataCollection data)
        {
            return RepositoryClass.FillDataToRepairPage(data);
        }

        public DataCollection FillDataRepairArchivePage(DataCollection data)
        {
            return RepositoryClass.FillDataToRepairArchivePage(data);
        }

        public DataCollection FillDataCalculationNormsPage(DataCollection data)
        {
            return RepositoryClass.FillDataToCalculationNormsPage(data);
        }

        public DataCollection FillDataAddRepairWindow(DataCollection data)
        {
            return RepositoryClass.FillDataToAddRepairWindow(data);
        }

        public DataCollection FillDataContinueRepairWindow(DataCollection data)
        {
            return RepositoryClass.FillDataContinueRepairWindow(data);
        }

        public DataCollection FillDataStandartOperationWindow(DataCollection data)
        {
            return RepositoryClass.FillDataStandartOperationWindow(data);
        }

        public bool ExistenceСheckRepair(string[] data)
        {
            return RepositoryClass.ExistenceСheckRepair(data);
        }

    }
}