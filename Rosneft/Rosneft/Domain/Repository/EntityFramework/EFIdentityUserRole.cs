using System;
using System.Linq;
using Rosneft.Domain.Entities;
using Rosneft.Domain.Repositories.Abstract;

namespace Rosneft.Domain.Repositories.EntityFramework
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
        public IQueryable<IdentityUserRole> GetIdentityUserRoleById(Guid idUser)
        {
            return _context.TbIdentityUserRole.Where(x => x.UserId == idUser).AsQueryable();
        }
    }
}