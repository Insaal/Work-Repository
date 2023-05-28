using System;
using System.ComponentModel.DataAnnotations;

namespace Rosneft.Domain.Entities
{
    public class Department
    {
        [Key]
        [Required] public Guid Id { get; set; }

        [Required] public string DepartmentName { get; set; }
    }
}