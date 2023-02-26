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

        //public DataCollection GetUsersCollection(DataCollection data)
        //{
        //    return RepositoryClass.GetUsersCollection(data);
        //}

        //public DataCollection GetEmployeesCollection(DataCollection data)
        //{
        //    return RepositoryClass.GetEmployeesCollection(data);
        //}

        //public DataCollection GetBushCollection(DataCollection data)
        //{
        //    return RepositoryClass.GetBushCollection(data);
        //}

        //public DataCollection GetDepartmentCollection(DataCollection data)
        //{
        //    return RepositoryClass.GetDepartmentCollection(data);
        //}

        //public DataCollection GetFieldCollection(DataCollection data)
        //{
        //    return RepositoryClass.GetFieldCollection(data);
        //}

        //public DataCollection GetTeamCollection(DataCollection data)
        //{
        //    return RepositoryClass.GetTeamCollection(data);
        //}

        //public DataCollection GetPostCollection(DataCollection data)
        //{
        //    return RepositoryClass.GetPostCollection(data);
        //}

    }
}