using System;
using System.Linq;
using Rosneft.Domain.Entities;

namespace Rosneft.Domain.Repositories.Abstract
{
    public interface IIdentityUser
    {
        IQueryable<IdentityUser> GetIdentityUser();

        IQueryable<IdentityUser> GetIdentityUserById(string idUser);
    }
}