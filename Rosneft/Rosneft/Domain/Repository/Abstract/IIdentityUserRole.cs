using System;
using System.Linq;
using Rosneft.Domain.Entities;

namespace Rosneft.Domain.Repositories.Abstract
{
    public interface IIdentityUserRole
    {
        IQueryable<IdentityUserRole> GetIdentityUserRole();

        IQueryable<IdentityUserRole> GetIdentityUserRoleById(Guid idUser);
    }
}