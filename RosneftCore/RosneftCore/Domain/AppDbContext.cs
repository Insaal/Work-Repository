using System;
using RosneftCore.Domain.Entities;
using System.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace RosneftCore.Domain
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("db2")
        {
        }

        //Запросы для всех таблиц

        public DbSet<IdentityRole> TbIdentityRole {get;set;}
        public DbSet<IdentityUser> TbIdentityUser {get;set;}
        public DbSet<IdentityUserRole> TbIdentityUserRole {get;set;}

        //Инициализация метода создания таблиц

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //конфигурационная схема для создания таблиц
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "e68665b5-1762-4c11-81be-de07883f9204",
                Name = "admin",
            });
            
            //создания администратора
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "733055de-a32d-4bd7-84b6-6389e9407919",
                UserName = "admin",
                PasswordHash = "superadmin",
            });

            //связывание роли и пользователя с полномочиями администратора 
            modelBuilder.Entity<IdentityUserRole>().HasData(new IdentityUserRole
            {
                RoleId = "e68665b5-1762-4c11-81be-de07883f9204",
                UserId = "733055de-a32d-4bd7-84b6-6389e9407919"
            });
        }
    }
}