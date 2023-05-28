using System;
using System.Linq;
using RosneftCore.Domain.Entities;

namespace RosneftCore.Domain.Repositories.Abstract
{
    public interface IIdentityRole
    {
        IQueryable<IdentityRole> GetIdentityRole();

        IQueryable<IdentityRole> GetIdentityRoleById(string idRole);
    }
}