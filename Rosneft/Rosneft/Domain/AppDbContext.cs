using System;
using System.Data.Entity;
using Rosneft.Domain.Entities;

namespace Rosneft.Domain
{
    public class AppDbContext : DbContext
    {
        static AppDbContext()
        {
            Database.SetInitializer(new ContextInitializer());
        }

        public AppDbContext() : base("DBConnection")
        {
        }

        //Запросы для всех таблиц

        public DbSet<IdentityRole> TbIdentityRole { get; set; }
        public DbSet<IdentityUser> TbIdentityUser { get; set; }
        public DbSet<IdentityUserRole> TbIdentityUserRole { get; set; }
    }

    public class ContextInitializer : DropCreateDatabaseIfModelChanges<AppDbContext>
    {
        protected override void Seed(AppDbContext context)
        {
            base.Seed(context);

            var role = new IdentityRole
            {
                Id = new Guid("f9896f9f-4fe8-4f13-a9f3-83e30fe11667"),
                Name = "Admin"
            };
            var user = new IdentityUser
            {
                Id = new Guid("954715db-12b6-4382-8ec5-be22f50e6e9b"),
                UserName = "admin",
                PasswordHash = "admin"
            };
            var userRole = new IdentityUserRole
            {
                Id = new Guid("75dc0763-bace-4db5-8d54-4867494c0b4a"),
                RoleId = new Guid("f9896f9f-4fe8-4f13-a9f3-83e30fe11667"),
                UserId = new Guid("954715db-12b6-4382-8ec5-be22f50e6e9b")
            };
            context.TbIdentityRole.Add(role);
            context.TbIdentityUser.Add(user);
            context.TbIdentityUserRole.Add(userRole);
            //context.Set<IdentityRole>().Add(new IdentityRole
            //{
            //    Id = new Guid("f9896f9f-4fe8-4f13-a9f3-83e30fe11667"),
            //    Name = "Admin"
            //});
            //context.Set<IdentityUser>().Add(new IdentityUser
            //{
            //    Id = new Guid("954715db-12b6-4382-8ec5-be22f50e6e9b"),
            //    UserName = "admin",
            //    PasswordHash = "admin"
            //});
            //context.Set<IdentityUserRole>().Add(new IdentityUserRole
            //{
            //    Id = new Guid(),
            //    RoleId = new Guid("f9896f9f-4fe8-4f13-a9f3-83e30fe11667"),
            //    UserId = new Guid("954715db-12b6-4382-8ec5-be22f50e6e9b")
            //});

            context.SaveChanges();
        }
    }
}