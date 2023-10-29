using System;
using System.ComponentModel.DataAnnotations;

namespace Rosneft.Domain.Entities
{
    public class TypeOfDescentEquipment
    {
        [Key]
        [Required] public Guid Id { get; set; }

        [Required] public string TypeName { get; set; }
    }
}