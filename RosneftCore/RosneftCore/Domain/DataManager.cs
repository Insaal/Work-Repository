using RosneftCore.Domain.Repositories.Abstract;

namespace RosneftCore.Domain
{
    public class DataManager
    {
        //связывание классов интерфейсов в репозиториях
        public IIdentityRole IdentityRoleRepository { get; set; }
        public IIdentityUser IdentityUserRepository { get; set; }
        public IIdentityUserRole IdentityUserRoleRepository { get; set; }

        //создание метода для работы с таблицами БД
        public DataManager(IIdentityRole iidentityRoleRepository, IIdentityUser iidentityUserRepository, 
        IIdentityUserRole iidentityUserRoleRepository)
        {
            IdentityRoleRepository = iidentityRoleRepository;
            IdentityUserRepository = iidentityUserRepository;
            IdentityUserRoleRepository = iidentityUserRoleRepository;
        }
    }
}