using System;
using System.Windows.Forms;
using Rosneft.Domain.Repository;

namespace Rosneft
{
    public class DataContext
    {
        public (bool entering, string role) Enter(string user, string password)
        {
            try
            {
                if (RepositoryClass.AuthorizationUser(user, password).entering)
                    return (true, RepositoryClass.AuthorizationUser(user, password).roleName);
                return (false, null);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
        }
    }
}