using System.Collections.ObjectModel;
using Rosneft.Helpers;

namespace Rosneft
{
    public class InputLogginCollection : BaseViewModel
    {
        private string _login;
        private string _password;
        private string _userName;
        private string _rows { get; set; }

        public string Rows
        {
            get => _rows;
            set
            {
                _rows = value;
                OnPropertyChanged();
            }
        }


        public string Login
        {
            get => _login;
            set
            {
                _login = value;
                OnPropertyChanged();
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }

        public string UserName
        {
            get => _userName;
            set
            {
                _userName = value;
                OnPropertyChanged();
            }
        }
    }

    public class EmployeesCollection : BaseViewModel
    {
        private string _surname { get; set; }

        private string _name { get; set; }

        private string _patronymic { get; set; }

        private string _department { get; set; }

        private string _team { get; set; }

        private string _post { get; set; }

        private string _rows { get; set; }

        public string Rows
        {
            get => _rows;
            set
            {
                _rows = value;
                OnPropertyChanged();
            }
        }

        public string SurName
        {
            get => _surname;
            set
            {
                _surname = value;
                OnPropertyChanged("Surname");
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public string ThirdName
        {
            get => _patronymic;
            set
            {
                _patronymic = value;
                OnPropertyChanged("Partonymic");
            }
        }

        public string Department
        {
            get => _department;
            set
            {
                _department = value;
                OnPropertyChanged();
            }
        }

        public string Team
        {
            get => _team;
            set
            {
                _team = value;
                OnPropertyChanged();
            }
        }

        public string Post
        {
            get => _post;
            set
            {
                _post = value;
                OnPropertyChanged();
            }
        }
    }

    public class BushCollection : BaseViewModel
    {
        private string _rows { get; set; }

        public string Rows
        {
            get => _rows;
            set
            {
                _rows = value;
                OnPropertyChanged();
            }
        }

        private string _bush { get; set; }

        public string Bush
        {
            get => _bush;
            set
            {
                _bush = value;
                OnPropertyChanged();
            }
        }
    }

    public class DepartmentCollection : BaseViewModel
    {
        private string _rows { get; set; }

        public string Rows
        {
            get => _rows;
            set
            {
                _rows = value;
                OnPropertyChanged();
            }
        }

        private string _department { get; set; }

        public string Department
        {
            get => _department;
            set
            {
                _department = value;
                OnPropertyChanged();
            }
        }
    }

    public class FieldCollection : BaseViewModel
    {
        private string _rows { get; set; }

        public string Rows
        {
            get => _rows;
            set
            {
                _rows = value;
                OnPropertyChanged();
            }
        }

        private string _field { get; set; }

        public string Field
        {
            get => _field;
            set
            {
                _field = value;
                OnPropertyChanged();
            }
        }
    }

    public class PostCollection : BaseViewModel
    {
        private string _rows { get; set; }

        public string Rows
        {
            get => _rows;
            set
            {
                _rows = value;
                OnPropertyChanged();
            }
        }

        private string _post { get; set; }

        public string Post
        {
            get => _post;
            set
            {
                _post = value;
                OnPropertyChanged();
            }
        }
    }

    public class TeamCollection : BaseViewModel
    {
        private string _rows { get; set; }

        public string Rows
        {
            get => _rows;
            set
            {
                _rows = value;
                OnPropertyChanged();
            }
        }

        private string _team { get; set; }

        public string Team
        {
            get => _team;
            set
            {
                _team = value;
                OnPropertyChanged();
            }
        }
    }

    public class EnteringData : BaseViewModel
    {
        private bool entering;
        private string role;
        private string _userName;

        public bool Entering
        {
            get => entering;
            set
            {
                entering = value;
                OnPropertyChanged("Login");
            }
        }

        public string Role
        {
            get => role;
            set
            {
                role = value;
                OnPropertyChanged("Password");
            }
        }

        public string UserName
        {
            get => _userName;
            set
            {
                _userName = value;
                OnPropertyChanged();
            }
        }
    }

    public class DataCollection : BaseViewModel
    {
        private ObservableCollection<InputLogginCollection> _users { get; set; }
        private ObservableCollection<EmployeesCollection> _employees { get; set; }
        private ObservableCollection<BushCollection> _bush { get; set; }
        private ObservableCollection<DepartmentCollection> _department { get; set; }
        private ObservableCollection<FieldCollection> _field { get; set; }
        private ObservableCollection<TeamCollection> _team { get; set; }
        private ObservableCollection<PostCollection> _post { get; set; }


        public ObservableCollection<TeamCollection> ObservableTeam
        {
            get => _team;
            set
            {
                _team = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<PostCollection> ObservablePost
        {
            get => _post;
            set
            {
                _post = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<BushCollection> ObservableBush
        {
            get => _bush;
            set
            {
                _bush = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<DepartmentCollection> ObservableDepartment
        {
            get => _department;
            set
            {
                _department = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<FieldCollection> ObservableField
        {
            get => _field;
            set
            {
                _field = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<InputLogginCollection> ObservableUsers
        {
            get => _users;
            set
            {
                _users = value;
                OnPropertyChanged("Users");
            }
        }

        public ObservableCollection<EmployeesCollection> ObservableEmployees
        {
            get => _employees;
            set
            {
                _employees = value;
                OnPropertyChanged("Employees");
            }
        }
    }
}