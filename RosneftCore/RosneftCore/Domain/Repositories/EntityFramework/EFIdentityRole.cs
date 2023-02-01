using System;
using System.Linq;
using RosneftCore.Domain.Entities;
using RosneftCore.Domain.Repositories.Abstract;

namespace RosneftCore.Domain.Repositories.EntityFramework
{
    public class EFIdentityRole : IIdentityRole
    {
        private readonly AppDbContext _context;

        public EFIdentityRole(AppDbContext context)
        {
            _context = context;
        }

        //Метод для получения всех записей
        public IQueryable<IdentityRole> GetIdentityRole()
        {
            return _context.TbIdentityRole;
        }

        //Метод для получения записей по id
        public IQueryable<IdentityRole> GetIdentityRoleById(string idRole)
        {
            return _context.TbIdentityRole.Where(x => x.Id == idRole).AsQueryable();
        }
    }
}