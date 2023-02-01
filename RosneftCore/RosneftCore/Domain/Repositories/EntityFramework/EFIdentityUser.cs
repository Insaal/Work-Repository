using System;
using System.Linq;
using RosneftCore.Domain.Entities;
using RosneftCore.Domain.Repositories.Abstract;

namespace RosneftCore.Domain.Repositories.EntityFramework
{
    public class EFIdentityUser : IIdentityUser
    {
        private readonly AppDbContext _context;

        public EFIdentityUser(AppDbContext context)
        {
            _context = context;
        }

        //Метод для получения всех записей
        public IQueryable<IdentityUser> GetIdentityUser()
        {
            return _context.TbIdentityUser;
        }

        //Метод для получения записей по id
        public IQueryable<IdentityUser> GetIdentityUserById(string idUser)
        {
            return _context.TbIdentityUser.Where(x => x.Id == idUser).AsQueryable();
        }
    }
}