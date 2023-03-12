using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using Rosneft.Domain.Entities;

namespace Rosneft.Domain.Repository
{
    public class RepositoryClass
    {
        public static AppDbContext _context = new AppDbContext();

        #region Loggin

        public static EnteringData AuthorizationUser(string login, string password)
        {
            EnteringData outData = null;
            if (Authorize(login, password))
            {
                outData = new EnteringData
                    { Entering = true, Role = GetUserRole(login), UserName = GetUserName(login) };
                return outData;
            }

            outData = new EnteringData { Entering = false };
            return outData;
        }

        public static bool Authorize(string login, string password)
        {
            return _context.TbIdentityUser.Any(x => x.Login.Equals(login) && x.Password.Equals(password));
        }

        public static string GetUserRole(string login)
        {
            var query = _context.TbIdentityUser.Where(u => u.Login.Equals(login)).Join(_context.TbIdentityUserRole,
                user => user.Id, roleid => roleid.UserId,
                (user, roleid) => new { user, roleid }).Join(_context.TbIdentityRole,
                rolename => rolename.roleid.RoleId, rolename2 => rolename2.Id, (rolename, rolename2) => new
                {
                    rolename2.Name
                });
            string outString = null;
            foreach (var result in query) outString = result.Name;

            return outString;
        }

        public static string GetUserName(string login)
        {
            var query = _context.TbIdentityUser.Join(_context.TbEmployees, user => user.UserName,
                employees => employees.Id,
                (user, employees) => new
                    { employees.Name, employees.Surname, employees.Patronymic });
            string outString = null;
            foreach (var result in query) outString = result.Surname + " " + result.Name + " " + result.Patronymic;
            return outString;
        }

        #endregion

        public static bool ExistenceСheckRepair(string[] data)
        {
            if (CheckRepair(GetTeamGuid(data[0]), GetFieldId(data[1]), GetBushId(data[2]), GetHoleId(data[3])))
                return true;
            else
            {
                AddRepair(data);
                return false;
            }

            return true;
        }

        private static void AddRepair(string[] data)
        {
            var repair = new Repair
            {
                Id = Guid.NewGuid(),
                BushId = GetBushId(data[2]),
                FieldId = GetFieldId(data[1]),
                HoleId = GetHoleId(data[3]),
                TeamId = GetTeamGuid(data[0]),
                DateCreate = data[4],
                TimeCreate = DateTime.Now.ToString("t"),
                ArchiveRepair = false
            };
            _context.TbRepair.Add(repair);
            _context.SaveChanges();
        }

        private static bool CheckRepair(Guid g1, Guid g2, Guid g3, Guid g4)
        {
            return _context.TbRepair.Any(x => x.TeamId.Equals(g1) && x.FieldId.Equals(g2) && x.BushId.Equals(g3) && x.HoleId.Equals(g4));
        }

        private static Guid GetTeamGuid(string data)
        {
            return _context.TbTeam.SingleOrDefault(x => x.TeamName.Equals(data)).Id;
        }

        private static Guid GetFieldId(string data)
        {
            return _context.TbField.SingleOrDefault(x => x.FieldName.Equals(data)).Id;
        }

        private static Guid GetBushId(string data)
        {
            return _context.TbBush.SingleOrDefault(x => x.BushName.Equals(data)).Id;
        }

        private static Guid GetHoleId(string data)
        {
            return _context.TbHole.SingleOrDefault(x => x.HoleName.Equals(data)).Id;
        }


        #region FillDataCollection

        public static DataCollection FillDataToAdminPage(DataCollection data)
        {
            data = ExistenceCheck(data);
            data = GetData(1,data, "users");
            data = GetData(1, data, "employees");

            return data;
        }

        public static DataCollection FillDataToCalculationNormsPage(DataCollection data)
        {
            data = ExistenceCheck(data);
            data = GetData(1, data, "hole");
            data = GetData(1, data, "operation");
            data = GetData(1, data, "pipe");
            data = GetData(1, data, "descent");
            data = GetData(1, data, "protector");
            return data;
        }

        public static DataCollection FillDataToAddRepairWindow(DataCollection data)
        {
            data = ExistenceCheck(data);
            data = GetData(1, data, "team");
            data = GetData(1, data, "field");
            data = GetData(1, data, "bush");
            data = GetData(1, data, "hole");
            return data;
        }

        public static DataCollection FillDataContinueRepairWindow(DataCollection data)
        {
            data = ExistenceCheck(data);
            return data;
        }

        public static DataCollection FillDataStandartOperationWindow(DataCollection data)
        {
            data = ExistenceCheck(data);
            data = GetData(1, data, "operation");
            return data;
        }

        public static DataCollection FillDataToRepairPage(DataCollection data)
        {
            data = ExistenceCheck(data);
            data = GetData(1, data, "repair");

            return data;
        }

        public static DataCollection FillDataToRepairArchivePage(DataCollection data)
        {
            data = ExistenceCheck(data);
            data = GetData(1, data, "archive");

            return data;
        }

        public static DataCollection GetData(DataCollection data)
        {
            var i = 1;
            data = ExistenceCheck(data);
            return data;
        }

        #endregion

        #region Private

        private static DataCollection ExistenceCheck(DataCollection data)
        {
            if (data.ObservableUsers == null) data.ObservableUsers = new ObservableCollection<InputLogginCollection>();
            if (data.ObservableEmployees == null)
                data.ObservableEmployees = new ObservableCollection<EmployeesCollection>();
            if (data.ObservableDepartment == null)
                data.ObservableDepartment = new ObservableCollection<DepartmentCollection>();
            if (data.ObservableBush == null) data.ObservableBush = new ObservableCollection<BushCollection>();
            if (data.ObservableTeam == null) data.ObservableTeam = new ObservableCollection<TeamCollection>();
            if (data.ObservableField == null) data.ObservableField = new ObservableCollection<FieldCollection>();
            if (data.ObservablePost == null) data.ObservablePost = new ObservableCollection<PostCollection>();
            if (data.ObservableOperation == null)
                data.ObservableOperation = new ObservableCollection<OperationCollection>();
            if (data.ObservablePipeDiameter == null)
                data.ObservablePipeDiameter = new ObservableCollection<PipeDiameterCollection>();
            if (data.ObservableProtectorType == null)
                data.ObservableProtectorType = new ObservableCollection<ProtectorTypeCollection>();
            if (data.ObservableTypeOfDescentEquipment == null)
                data.ObservableTypeOfDescentEquipment = new ObservableCollection<TypeOfDescentEquipmentCollection>();
            if (data.ObservableRepair == null) data.ObservableRepair = new ObservableCollection<RepairCollection>();
            if (data.ObservableRepairDescription == null)
                data.ObservableRepairDescription = new ObservableCollection<RepairDescriptionCollection>();
            if (data.ObservableHole == null) data.ObservableHole = new ObservableCollection<HoleCollection>();

            return data;
        }

        private static DataCollection GetData(int i, DataCollection data, string collectionName)
        {
            switch (collectionName)
            {
                case "users":
                    {
                        var getUsers = _context.TbIdentityUser.Join(_context.TbEmployees, user => user.UserName,
                            employees => employees.Id,
                            (user, employees) => new
                            { user.Login, user.Password, employees.Name, employees.Surname, employees.Patronymic });

                        foreach (var e in getUsers)
                        {
                            data.ObservableUsers.Add(new InputLogginCollection
                            {
                                Rows = i.ToString(),
                                Login = e.Login,
                                Password = e.Password,
                                UserName = e.Surname + " " + e.Name + " " + e.Patronymic
                            });
                            i++;
                        }
                    }
                    return data;

                case "employees":
                    {
                        var getEmployees = _context.TbEmployees.Join(_context.TbDepartment,
                            employees => employees.DepartmentId,
                            department => department.Id,
                            (employees, department) => new { employees, department }).Join(_context.TbTeam,
                            teamid => teamid.employees.TeamId,
                            teamname => teamname.Id, (teamid, teamname) => new { teamid, teamname }).Join(_context.TbPost,
                            postid => postid.teamid.employees.PostId, postname => postname.Id,
                            (postid, postname) => new
                            {
                                postid.teamid.employees.Surname,
                                postid.teamid.employees.Name,
                                postid.teamid.employees.Patronymic,
                                postid.teamid.department.DepartmentName,
                                postid.teamname.TeamName,
                                postname.PostName
                            });

                        foreach (var e in getEmployees)
                        {
                            data.ObservableEmployees.Add(new EmployeesCollection
                            {
                                Rows = i.ToString(),
                                SurName = e.Surname,
                                Name = e.Name,
                                ThirdName = e.Patronymic,
                                Department = e.DepartmentName,
                                Team = e.TeamName,
                                Post = e.PostName
                            });
                            i++;
                        }
                    }
                    return data;

                case "hole":
                    {
                        foreach (var e in _context.TbHole)
                            data.ObservableHole.Add(new HoleCollection
                            {
                                Rows = i.ToString(),
                                Hole = e.HoleName
                            });
                    }
                    return data;

                case "operation":
                    {
                        foreach (var e in _context.TbOperations)
                        {
                            data.ObservableOperation.Add(new OperationCollection
                            {
                                Rows = i.ToString(),
                                OperationName = e.OperationName,
                                NormMin = e.NormMin
                            });
                            i++;
                        }
                    }
                    return data;

                case "pipe":
                    {
                        foreach (var e in _context.TbPipeDiameters)
                        {
                            data.ObservablePipeDiameter.Add(new PipeDiameterCollection
                            {
                                Rows = i.ToString(),
                                PipeDiameter = e.Diameter
                            });
                            i++;
                        }

                    }
                    return data;

                case "protector":
                    {
                        foreach (var e in _context.TbProtectorTypes)
                        {
                            data.ObservableProtectorType.Add(new ProtectorTypeCollection
                            {
                                Rows = i.ToString(),
                                ProtectorType = e.ProtectorTypeName
                            });
                            i++;
                        }

                    }
                    return data;

                case "descent":
                    {
                        foreach (var e in _context.TbTypeOfDescentEquipments)
                        {
                            data.ObservableTypeOfDescentEquipment.Add(new TypeOfDescentEquipmentCollection
                            {
                                Rows = i.ToString(),
                                TypeOfDescentEquipment = e.TypeName
                            });
                            i++;
                        }

                    }
                    return data;

                case "archive":
                    {
                        var queryGetRepair = _context.TbRepair
                            .Join(_context.TbTeam, rprTeam => rprTeam.TeamId, team => team.Id,
                                (rprTeam, team) => new { rprTeam, team }).Join(_context.TbField,
                                rprField => rprField.rprTeam.FieldId, field => field.Id,
                                (rprField, field) => new { rprField, field }).Join(_context.TbBush,
                                rprBush => rprBush.rprField.rprTeam.BushId, bush => bush.Id,
                                (rprBush, bush) => new { rprBush, bush }).Join(_context.TbHole,
                                rprHole => rprHole.rprBush.rprField.rprTeam.HoleId, hole => hole.Id, (rprHole, hole) => new
                                {
                                    rprHole.rprBush.rprField.team.TeamName,
                                    rprHole.rprBush.field.FieldName,
                                    rprHole.bush.BushName,
                                    hole.HoleName,
                                    rprHole.rprBush.rprField.rprTeam.DateCreate,
                                    rprHole.rprBush.rprField.rprTeam.TimeCreate,
                                    rprHole.rprBush.rprField.rprTeam.ArchiveRepair,
                                    rprHole.rprBush.rprField.rprTeam.DateEnd,
                                    rprHole.rprBush.rprField.rprTeam.TimeEnd
                                });
                        var query = queryGetRepair.Where(archive => archive.ArchiveRepair == true);

                        foreach (var e in query)
                        {
                            data.ObservableRepair.Add(new RepairCollection
                            {
                                Rows = i.ToString(),
                                Team = e.TeamName,
                                Field = e.FieldName,
                                Bush = e.BushName,
                                Hole = e.HoleName,
                                DateCreate = e.DateCreate,
                                TimeCreate = e.TimeCreate,
                                DateEnd = e.DateEnd,
                                TimeEnd = e.TimeEnd,
                                ArchiveRepair = e.ArchiveRepair
                            });
                            i++;
                        }
                    }
                    return data;

                case "repair":
                    {
                        var queryGetRepair = _context.TbRepair
                            .Join(_context.TbTeam, rprTeam => rprTeam.TeamId, team => team.Id,
                                (rprTeam, team) => new { rprTeam, team }).Join(_context.TbField,
                                rprField => rprField.rprTeam.FieldId, field => field.Id,
                                (rprField, field) => new { rprField, field }).Join(_context.TbBush,
                                rprBush => rprBush.rprField.rprTeam.BushId, bush => bush.Id,
                                (rprBush, bush) => new { rprBush, bush }).Join(_context.TbHole,
                                rprHole => rprHole.rprBush.rprField.rprTeam.HoleId, hole => hole.Id, (rprHole, hole) => new
                                {
                                    rprHole.rprBush.rprField.team.TeamName,
                                    rprHole.rprBush.field.FieldName,
                                    rprHole.bush.BushName,
                                    hole.HoleName,
                                    rprHole.rprBush.rprField.rprTeam.DateCreate,
                                    rprHole.rprBush.rprField.rprTeam.TimeCreate,
                                    rprHole.rprBush.rprField.rprTeam.ArchiveRepair,
                                    rprHole.rprBush.rprField.rprTeam.DateEnd,
                                    rprHole.rprBush.rprField.rprTeam.TimeEnd
                                });
                        var query = queryGetRepair.Where(archive => archive.ArchiveRepair == false);

                        foreach (var e in query)
                        {
                            data.ObservableRepair.Add(new RepairCollection
                            {
                                Rows = i.ToString(),
                                Team = e.TeamName,
                                Field = e.FieldName,
                                Bush = e.BushName,
                                Hole = e.HoleName,
                                DateCreate = e.DateCreate,
                                TimeCreate = e.TimeCreate,
                                DateEnd = e.DateEnd,
                                TimeEnd = e.TimeEnd,
                                ArchiveRepair = e.ArchiveRepair
                            });
                            i++;
                        }
                    }
                    return data;

                case "department":
                    {
                        foreach (var e in _context.TbDepartment)
                        {
                            data.ObservableDepartment.Add(new DepartmentCollection
                            {
                                Rows = i.ToString(),
                                Department = e.DepartmentName
                            });
                            i++;
                        }

                    }
                    return data;

                case "bush":
                    {
                        foreach (var e in _context.TbBush)
                        {
                            data.ObservableBush.Add(new BushCollection
                            {
                                Rows = i.ToString(),
                                Bush = e.BushName
                            });
                            i++;
                        }

                    }
                    return data;

                case "field":
                    {
                        foreach (var e in _context.TbField)
                        {
                            data.ObservableField.Add(new FieldCollection
                            {
                                Rows = i.ToString(),
                                Field = e.FieldName
                            });
                            i++;
                        }

                    }
                    return data;

                case "team":
                    {
                        foreach (var e in _context.TbTeam)
                        {
                            data.ObservableTeam.Add(new TeamCollection
                            {
                                Rows = i.ToString(),
                                Team = e.TeamName
                            });
                            i++;
                        }

                    }
                    return data;

                case "post":
                    {
                        foreach (var e in _context.TbPost)
                        {
                            data.ObservablePost.Add(new PostCollection
                            {
                                Rows = i.ToString(),
                                Post = e.PostName
                            });
                            i++;
                        }

                    }
                    return data;
            }

            return null;
        }

        #endregion
    }
}