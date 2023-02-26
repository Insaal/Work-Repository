using System.Collections.ObjectModel;
using System.Linq;

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

        #region FillDataCollection

        public static DataCollection GetData(DataCollection data)
        {
            int i = 1;
            data.ObservableUsers = new ObservableCollection<InputLogginCollection>();
            data.ObservableEmployees = new ObservableCollection<EmployeesCollection>();
            data.ObservableDepartment = new ObservableCollection<DepartmentCollection>();
            data.ObservableBush = new ObservableCollection<BushCollection>();
            data.ObservableTeam = new ObservableCollection<TeamCollection>();
            data.ObservableField = new ObservableCollection<FieldCollection>();
            data.ObservablePost = new ObservableCollection<PostCollection>();


            var queryGetUser = _context.TbIdentityUser.Join(_context.TbEmployees, user => user.UserName,
                employees => employees.Id,
                (user, employees) => new
                    { user.Login, user.Password, employees.Name, employees.Surname, employees.Patronymic });

            var queryGetEmployees = _context.TbEmployees.Join(_context.TbDepartment, employees => employees.DepartmentId,
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


            foreach (var e in queryGetUser)
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
            i = 1;
            foreach (var e in queryGetEmployees)
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
            i = 1;
            foreach (var e in _context.TbDepartment)
            {
                data.ObservableDepartment.Add(new DepartmentCollection
                {
                    Rows = i.ToString(),
                    Department = e.DepartmentName,
                });
                i++;
            }
            i = 1;
            foreach (var e in _context.TbBush)
            {
                data.ObservableBush.Add(new BushCollection
                {
                    Rows = i.ToString(),
                    Bush = e.BushName,
                });
                i++;
            }
            i = 1;
            foreach (var e in _context.TbField)
            {
                data.ObservableField.Add(new FieldCollection
                {
                    Rows = i.ToString(),
                    Field = e.FieldName,
                });
                i++;
            }
            i = 1;
            foreach (var e in _context.TbTeam)
            {
                data.ObservableTeam.Add(new TeamCollection
                {
                    Rows = i.ToString(),
                    Team = e.TeamName,
                });
                i++;
            }
            i = 1;
            foreach (var e in _context.TbPost)
            {
                data.ObservablePost.Add(new PostCollection
                {
                    Rows = i.ToString(),
                    Post = e.PostName,
                });
                i++;
            }

            return data;
        }

        //public static DataCollection GetUsersCollection(DataCollection data)
        //{
        //    var query = _context.TbIdentityUser.Join(_context.TbEmployees, user => user.UserName,
        //        employees => employees.Id,
        //        (user, employees) => new
        //        { user.Login, user.Password, employees.Name, employees.Surname, employees.Patronymic });
        //    data.ObservableUsers = new ObservableCollection<InputLogginCollection>();
        //    foreach (var e in query)
        //        data.ObservableUsers.Add(new InputLogginCollection
        //        {
        //            Login = e.Login,
        //            Password = e.Password,
        //            UserName = e.Surname + " " + e.Name + " " + e.Patronymic
        //        });

        //    return data;
        //}

        //public static DataCollection GetEmployeesCollection(DataCollection data)
        //{
        //    var query = _context.TbEmployees.Join(_context.TbDepartment, employees => employees.DepartmentId,
        //        department => department.Id,
        //        (employees, department) => new { employees, department }).Join(_context.TbTeam,
        //        teamid => teamid.employees.TeamId,
        //        teamname => teamname.Id, (teamid, teamname) => new { teamid, teamname }).Join(_context.TbPost,
        //        postid => postid.teamid.employees.PostId, postname => postname.Id,
        //        (postid, postname) => new
        //        {
        //            postid.teamid.employees.Surname,
        //            postid.teamid.employees.Name,
        //            postid.teamid.employees.Patronymic,
        //            postid.teamid.department.DepartmentName,
        //            postid.teamname.TeamName,
        //            postname.PostName
        //        });
        //    data.ObservableEmployees = new ObservableCollection<EmployeesCollection>();
        //    foreach (var e in query)
        //        data.ObservableEmployees.Add(new EmployeesCollection
        //        {
        //            SurName = e.Surname,
        //            Name = e.Name,
        //            ThirdName = e.Patronymic,
        //            Department = e.DepartmentName,
        //            Team = e.TeamName,
        //            Post = e.PostName
        //        });

        //    return data;
        //}

        //public static DataCollection GetDepartmentCollection(DataCollection data)
        //{
        //    data.ObservableDepartment = new ObservableCollection<DepartmentCollection>();
        //    foreach (var e in _context.TbDepartment)
        //        data.ObservableDepartment.Add(new DepartmentCollection
        //        {
        //            Department = e.DepartmentName,
        //        });

        //    return data;

        //}

        //public static DataCollection GetBushCollection(DataCollection data)
        //{
        //    data.ObservableBush = new ObservableCollection<BushCollection>();
        //    foreach (var e in _context.TbBush)
        //        data.ObservableBush.Add(new BushCollection
        //        {
        //            Bush = e.BushName,
        //        });

        //    return data;

        //}

        //public static DataCollection GetFieldCollection(DataCollection data)
        //{
        //    data.ObservableField = new ObservableCollection<FieldCollection>();
        //    foreach (var e in _context.TbField)
        //        data.ObservableField.Add(new FieldCollection
        //        {
        //            Field = e.FieldName,
        //        });

        //    return data;

        //}

        //public static DataCollection GetTeamCollection(DataCollection data)
        //{
        //    data.ObservableTeam = new ObservableCollection<TeamCollection>();
        //    foreach (var e in _context.TbTeam)
        //        data.ObservableTeam.Add(new TeamCollection
        //        {
        //            Team = e.TeamName,
        //        });

        //    return data;

        //}

        //public static DataCollection GetPostCollection(DataCollection data)
        //{
        //    data.ObservablePost = new ObservableCollection<PostCollection>();
        //    foreach (var e in _context.TbPost)
        //        data.ObservablePost.Add(new PostCollection
        //        {
        //            Post = e.PostName,
        //        });

        //    return data;

        //}


        #endregion
    }
}