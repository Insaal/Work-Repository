using System;
using System.Linq;

namespace Rosneft.Domain.Repository
{
    public class RepositoryClass
    {
        public static AppDbContext _context = new AppDbContext();

        public static string AuthorizationUser(string login, string password)
        {
            if (Authorize(login, password))
            {

                return GetRoleName(SelectRoleId(SelectUserId(login, password)));
            }
            else
            {
                return "Sasi";
            }
        }

        public static bool Authorize(string login, string password)
        {
            return _context.TbIdentityUser.Any(x => x.UserName.Equals(login) && x.PasswordHash.Equals(password));
        }

        public static Guid SelectUserId(string login, string password)
        {
            return _context.TbIdentityUser.Where(x => x.UserName.Equals(login) && x.PasswordHash.Equals(password)).Select(y => y.Id).FirstOrDefault();
        }

        public static Guid SelectRoleId(Guid idUser)
        {
            return _context.TbIdentityUserRole.Where(x => x.UserId.Equals(idUser)).Select(x => x.RoleId).FirstOrDefault();
        }

        public static string GetRoleName(Guid idRole)
        {
            return _context.TbIdentityRole.Where(x => x.Id.Equals(idRole)).Select(x => x.Name).FirstOrDefault();
        }

    }
}