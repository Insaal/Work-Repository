using System;
using System.Linq;
using Rosneft.Domain.Entities;

namespace Rosneft.Domain.Repositories.Abstract
{
    public interface IIdentityRole
    {
        IQueryable<IdentityRole> GetIdentityRole();

        IQueryable<IdentityRole> GetIdentityRoleById(Guid idRole);
    }
}