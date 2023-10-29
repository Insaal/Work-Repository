using System;
using System.Linq;
using RosneftCore.Domain.Entities;

namespace RosneftCore.Domain.Repositories.Abstract
{
    public interface IIdentityUserRole
    {
        IQueryable<IdentityUserRole> GetIdentityUserRole();

        IQueryable<IdentityUserRole> GetIdentityUserRoleById(string idRole);
    }
}