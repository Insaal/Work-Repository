using System;
using System.Linq;
using RosneftCore.Domain.Entities;
using RosneftCore.Domain.Repositories.Abstract;

namespace RosneftCore.Domain.Repositories.EntityFramework
{
    public class EFIdentityUserRole : IIdentityUserRole
    {
        private readonly AppDbContext _context;

        public EFIdentityUserRole(AppDbContext context)
        {
            _context = context;
        }

        //Метод для получения всех записей
        public IQueryable<IdentityUserRole> GetIdentityUserRole()
        {
            return _context.TbIdentityUserRole;
        }

        //Метод для получения записей по id
        public IQueryable<IdentityUserRole> GetIdentityUserRoleById(string idRole)
        {
            return _context.TbIdentityUserRole.Where(x => x.RoleId == idRole).AsQueryable();
        }
    }
}