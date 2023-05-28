using System;
using System.Collections.ObjectModel;
using Rosneft.Helpers;

namespace Rosneft
{
    public class InputLogginCollection : BaseViewModel
    {
        private string _rows { get; set; }

        private string _login;

        private string _password;

        private string _userName;

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
        private string _rows { get; set; }

        private string _surname { get; set; }

        private string _name { get; set; }

        private string _patronymic { get; set; }

        private string _department { get; set; }

        private string _team { get; set; }

        private string _post { get; set; }

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
                OnPropertyChanged();
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
                OnPropertyChanged();
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
        private bool _entering;
        private string _role;
        private string _userName;

        public bool Entering
        {
            get => _entering;
            set
            {
                _entering = value;
                OnPropertyChanged();
            }
        }

        public string Role
        {
            get => _role;
            set
            {
                _role = value;
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

    public class OperationCollection : BaseViewModel
    {
        private string _rows { get; set; }

        private string _operationName { get; set; }

        private string _normMin { get; set; }

        public string Rows
        {
            get => _rows;
            set
            {
                _rows = value;
                OnPropertyChanged();
            }
        }

        public string OperationName
        {
            get => _operationName;
            set
            {
                _operationName = value;
                OnPropertyChanged();
            }
        }

        public string NormMin 
        {
            get => _normMin;
            set
            {
                _normMin = value;
                OnPropertyChanged("NormMin ");
            }
        }
    }

    public class PipeDiameterCollection : BaseViewModel
    {
        private string _rows { get; set; }

        private string _pipeDiameter { get; set; }

        public string Rows
        {
            get => _rows;
            set
            {
                _rows = value;
                OnPropertyChanged();
            }
        }

        public string PipeDiameter
        {
            get => _pipeDiameter;
            set
            {
                _pipeDiameter = value;
                OnPropertyChanged();
            }
        }
    }

    public class ProtectorTypeCollection : BaseViewModel
    {
        private string _rows { get; set; }

        private string _protectorType { get; set; }

        public string Rows
        {
            get => _rows;
            set
            {
                _rows = value;
                OnPropertyChanged();
            }
        }

        public string ProtectorType
        {
            get => _protectorType;
            set
            {
                _protectorType = value;
                OnPropertyChanged();
            }
        }
    }

    public class TypeOfDescentEquipmentCollection : BaseViewModel
    {
        private string _rows { get; set; }

        private string _typeOfDescentEquipment { get; set; }

        public string Rows
        {
            get => _rows;
            set
            {
                _rows = value;
                OnPropertyChanged();
            }
        }

        public string TypeOfDescentEquipment
        {
            get => _typeOfDescentEquipment;
            set
            {
                _typeOfDescentEquipment = value;
                OnPropertyChanged();
            }
        }
    }

    public class HoleCollection : BaseViewModel
    {
        private string _rows { get; set; }

        private string _hole { get; set; }

        public string Rows
        {
            get => _rows;
            set
            {
                _rows = value;
                OnPropertyChanged();
            }
        }

        public string Hole
        {
            get => _hole;
            set
            {
                _hole = value;
                OnPropertyChanged("Hole");
            }
        }
    }

    public class RepairCollection : BaseViewModel
    {
        private string _rows { get; set; }

        private string _team { get; set; }

        private string _field { get; set; }

        private string _bush { get; set; }

        private string _hole { get; set; }

        private string _dateCreate { get; set; }

        private string _timeCreate { get; set; }

        private bool _archiveRepair { get; set; }

        private string _dateEnd { get; set; }

        private string _timeEnd { get; set; }

        public string Rows
        {
            get => _rows;
            set
            {
                _rows = value;
                OnPropertyChanged();
            }
        }

        public string Team
        {
            get => _team;
            set
            {
                _team = value;
                OnPropertyChanged("Team");
            }
        }

        public string Field
        {
            get => _field;
            set
            {
                _field = value;
                OnPropertyChanged("Field");
            }
        }

        public string Bush
        {
            get => _bush;
            set
            {
                _bush = value;
                OnPropertyChanged("Bush");
            }
        }

        public string Hole
        {
            get => _hole;
            set
            {
                _hole = value;
                OnPropertyChanged("Hole");
            }
        }

        public string DateCreate
        {
            get => _dateCreate;
            set
            {
                _dateCreate = value;
                OnPropertyChanged("DateCreate");
            }
        }

        public string TimeCreate
        {
            get => _timeCreate;
            set
            {
                _timeCreate = value;
                OnPropertyChanged("TimeCreate");
            }
        }

        public bool ArchiveRepair
        {
            get => _archiveRepair;
            set
            {
                _archiveRepair = value;
                OnPropertyChanged("ArchiveRepair");
            }
        }

        public string DateEnd
        {
            get => _dateEnd;
            set
            {
                _dateEnd = value;
                OnPropertyChanged("DateEnd");
            }
        }

        public string TimeEnd
        {
            get => _timeEnd;
            set
            {
                _timeEnd = value;
                OnPropertyChanged("TimeEnd");
            }
        }
    }

    public class RepairDescriptionCollection : BaseViewModel
    {
        private string _descriptionOfWork { get; set; }

        private string _dateTimeOfWork { get; set; }

        public string DescriptionOfWork
        {
            get => _descriptionOfWork;
            set
            {
                _descriptionOfWork = value;
                OnPropertyChanged("DescriptionOfWork");
            }
        }

        public string DateTimeOfWork
        {
            get => _dateTimeOfWork;
            set
            {
                _dateTimeOfWork = value;
                OnPropertyChanged("DateOfWork");
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
        private ObservableCollection<OperationCollection> _operation { get; set; }
        private ObservableCollection<PipeDiameterCollection> _pipeDiameter { get; set; }
        private ObservableCollection<ProtectorTypeCollection> _protectorType { get; set; }
        private ObservableCollection<TypeOfDescentEquipmentCollection> _typeOfDescentEquipment { get; set; }
        private ObservableCollection<HoleCollection> _hole { get; set; }
        private ObservableCollection<RepairCollection> _repair { get; set; }
        private ObservableCollection<RepairDescriptionCollection> _repairDescription { get; set; }

        public ObservableCollection<HoleCollection> ObservableHole
        {
            get => _hole;
            set
            {
                _hole = value;
                OnPropertyChanged("ObservableHole");
            }
        }

        public ObservableCollection<RepairDescriptionCollection> ObservableRepairDescription
        {
            get => _repairDescription;
            set
            {
                _repairDescription = value;
                OnPropertyChanged("ObservableRepairDescription");
            }
        }

        public ObservableCollection<RepairCollection> ObservableRepair
        {
            get => _repair;
            set
            {
                _repair = value;
                OnPropertyChanged("ObservableRepair");
            }
        }

        public ObservableCollection<OperationCollection> ObservableOperation
        {
            get => _operation;
            set
            {
                _operation = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<PipeDiameterCollection> ObservablePipeDiameter
        {
            get => _pipeDiameter;
            set
            {
                _pipeDiameter = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<ProtectorTypeCollection> ObservableProtectorType
        {
            get => _protectorType;
            set
            {
                _protectorType = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<TypeOfDescentEquipmentCollection> ObservableTypeOfDescentEquipment
        {
            get => _typeOfDescentEquipment;
            set
            {
                _typeOfDescentEquipment = value;
                OnPropertyChanged();
            }
        }

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