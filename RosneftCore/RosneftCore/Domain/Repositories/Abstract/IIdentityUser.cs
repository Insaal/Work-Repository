using System;
using System.Linq;
using RosneftCore.Domain.Entities;

namespace RosneftCore.Domain.Repositories.Abstract
{
    public interface IIdentityUser
    {
        IQueryable<IdentityUser> GetIdentityUser();

        IQueryable<IdentityUser> GetIdentityUserById(string idUser);
    }
}