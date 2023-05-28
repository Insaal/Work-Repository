using System;
using System.Data.Entity.Migrations;
using Rosneft.Domain;
using Rosneft.Domain.Entities;

namespace Rosneft.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

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

            var operations = new Operations
            {
                Id = new Guid("ba399011-67a9-4a69-b8fc-fd327692417a"),
                OperationName = "Спуск ЭЦН",
                NormMin = "704,6"
            };

            var typeofdescentequipment = new TypeOfDescentEquipment
            {
                Id = new Guid("a7af1fa7-5efb-4663-89a1-e31cc6a2f6d9"),
                TypeName = "ЭЦН"
            };

            var protectortype = new ProtectorType
            {
                Id = new Guid("d2195e96-0481-45eb-951f-9d903e4aefbd"),
                ProtectorTypeName = "ПП"
            };

            var pipediameter = new PipeDiameter
            {
                Id = new Guid("19f3c7a0-7f14-4933-8adf-27ce79b3aab1"),
                Diameter = "33"
            };

            var hole = new Hole
            {
                Id = new Guid("d80d4ddf-b22f-40d1-909d-0f7fff635a5c"),
                HoleName = "Приобское"
            };

            var repair = new Repair
            {
                Id = new Guid("3e11ba34-fb69-4e03-93bc-eb8039dfd043"),
                BushId = new Guid("a503d6a1-7436-48a6-93be-3d05832f4c30"),
                FieldId = new Guid("53e07ada-481b-4e80-9839-3d4babab5911"),
                HoleId = new Guid("d80d4ddf-b22f-40d1-909d-0f7fff635a5c"),
                TeamId = new Guid("da88e233-c15e-46f6-91f0-b14b1587323d"),
                DateCreate = DateTime.Now.ToString("d"),
                TimeCreate = DateTime.Now.ToString("t"),
                ArchiveRepair = false
            };

            var repairdescription = new RepairDescription
            {
                Id = new Guid("ab1956d2-c5d5-40ac-bca3-36e403df305f"),
                RepairId = new Guid("3e11ba34-fb69-4e03-93bc-eb8039dfd043"),
                DateOfWork = DateTime.Now.ToString("d"),
                TimeOfWork = DateTime.Now.ToString("t"),
                DescriptionOfWork = "Начали работы по ремонту"
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

            context.TbOperations.AddOrUpdate(operations);
            context.TbTypeOfDescentEquipments.AddOrUpdate(typeofdescentequipment);
            context.TbProtectorTypes.AddOrUpdate(protectortype);
            context.TbPipeDiameters.AddOrUpdate(pipediameter);

            context.TbHole.AddOrUpdate(hole);
            context.TbRepair.AddOrUpdate(repair);
            context.TbRepairDescriptions.AddOrUpdate(repairdescription);

            context.SaveChanges();

            base.Seed(context);
        }
    }
}