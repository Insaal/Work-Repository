using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using Rosneft.Domain.Entities;

namespace Rosneft.Domain
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("DBConnection")
        {
            Database.SetInitializer(new ContextInitializer());
        }

        //Запросы для всех таблиц

        public DbSet<IdentityRole> TbIdentityRole { get; set; }
        public DbSet<IdentityUser> TbIdentityUser { get; set; }
        public DbSet<IdentityUserRole> TbIdentityUserRole { get; set; }

        public DbSet<Bush> TbBush { get; set; }
        public DbSet<Department> TbDepartment { get; set; }
        public DbSet<Employees> TbEmployees { get; set; }

        public DbSet<Field> TbField { get; set; }
        public DbSet<Post> TbPost { get; set; }
        public DbSet<Team> TbTeam { get; set; }

    }

    public class ContextInitializer : DropCreateDatabaseIfModelChanges<AppDbContext>
    {
        protected override void Seed(AppDbContext context)
        {

            var role = new IdentityRole
            {
                Id = new Guid("f9896f9f-4fe8-4f13-a9f3-83e30fe11667"),
                Name = "Admin"
            };
            var user = new IdentityUser
            {
                Id = new Guid("954715db-12b6-4382-8ec5-be22f50e6e9b"),
                Login = "admin",
                Password = "admin",
                UserName = new Guid("0b5b827e-676d-4eea-a573-432cf860a75f")
            };
            var userRole = new IdentityUserRole
            {
                Id = new Guid("75dc0763-bace-4db5-8d54-4867494c0b4a"),
                RoleId = new Guid("f9896f9f-4fe8-4f13-a9f3-83e30fe11667"),
                UserId = new Guid("954715db-12b6-4382-8ec5-be22f50e6e9b")
            };

            var bush = new Bush
            {
                Id = new Guid("a503d6a1-7436-48a6-93be-3d05832f4c30"),
                BushName = "КУСТ21А.СС",
            };

            var department = new Department
            {
                Id = new Guid("e10d10ac-c2c5-448e-8d4d-f7f166c0f170"),
                DepartmentName = "РИТС-2"
            };

            var employee = new Employees
            {
                Id = new Guid("0b5b827e-676d-4eea-a573-432cf860a75f"),
                Name = "Иван",
                Surname = "Иванов",
                Patronymic = "Иванович",
                DepartmentId = new Guid("e10d10ac-c2c5-448e-8d4d-f7f166c0f170"),
                PostId = new Guid("24b923ad-b70f-4645-b4e3-d0a7a97c814e"),
                TeamId = new Guid("da88e233-c15e-46f6-91f0-b14b1587323d")
            };

            var field = new Field
            {
                Id = new Guid("53e07ada-481b-4e80-9839-3d4babab5911"),
                FieldName = "МР.СС"
            };

            var post = new Post
            {
                Id = new Guid("24b923ad-b70f-4645-b4e3-d0a7a97c814e"),
                PostName = "Старший бригадир"
            };

            var team = new Team
            {
                Id = new Guid("da88e233-c15e-46f6-91f0-b14b1587323d"),
                TeamName = "КРС-105"
            };

            context.TbIdentityRole.AddOrUpdate(role);
            context.TbIdentityUser.AddOrUpdate(user);
            context.TbIdentityUserRole.AddOrUpdate(userRole);

            context.TbBush.AddOrUpdate(bush);
            context.TbDepartment.AddOrUpdate(department);
            context.TbEmployees.AddOrUpdate(employee);
            context.TbField.AddOrUpdate(field);
            context.TbPost.AddOrUpdate(post);
            context.TbTeam.AddOrUpdate(team);
            
            context.SaveChanges();

            base.Seed(context);
        }
    }
}