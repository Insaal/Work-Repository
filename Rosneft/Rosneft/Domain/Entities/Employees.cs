using System;
using System.ComponentModel.DataAnnotations;

namespace Rosneft.Domain.Entities
{
    public class Employees
    {
        //Обязательное поле для заполнения идентификатора
        [Key]
        [Required] public Guid Id { get; set; }

        //Обязательное поле для заполнения логина
        [Required] public string Surname { get; set; }

        [Required] public string Name { get; set; }

        [Required] public string Patronymic { get; set; }

        [Required] public Guid DepartmentId { get; set; }

        [Required] public Guid TeamId { get; set; }

        [Required] public Guid PostId { get; set; }
    }
}