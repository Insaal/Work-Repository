using System;
using System.ComponentModel.DataAnnotations;

namespace Rosneft.Domain.Entities
{
    public class Field
    {
        [Key]
        [Required] public Guid Id { get; set; }

        [Required] public string FieldName { get; set; }
    }
}