using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Documents;
using System.Windows.Forms;
using Rosneft.Domain;
using Rosneft.Domain.Repositories.EntityFramework;
using Rosneft.Domain.Repository;

namespace Rosneft
{
    public class DataContext
    {
        public void Enter(string user, string password)
        {
            try
            {
                MessageBox.Show(RepositoryClass.AuthorizationUser(user, password));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
        }
    }
}