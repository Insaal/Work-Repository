using System;
using System.ComponentModel.DataAnnotations;

namespace Rosneft.Domain.Entities
{
    public class Users
    {
        //Обязательное поле для заполнения идентификатора
        [Required] public Guid Id { get; set; }

        //Обязательное поле для заполнения идентификатора сотрудника
        [Required] public Guid EmployeeId { get; set; }

        //Обязательное поле для заполнения идентификатора рабочего года
        [Required] public Guid YearId { get; set; }

        //Обязательное поле для заполнения рабочего месяца
        [Required] public Guid MonthId { get; set; }

        //Обязательное поле для заполнения рабочего дня
        [Required] public int Day { get; set; }

        //Обязательное поле для заполнения время прибытия на работу
        public string TimeArrival { get; set; }

        //Обязательное поле для заполнения прибытия
        [Required] public bool Arrival { get; set; }
    }
}
