using System;
using System.ComponentModel.DataAnnotations;

namespace Rosneft.Domain.Entities
{
    public class ProtectorType
    {
        [Key]
        [Required] public Guid Id { get; set; }

        [Required] public string ProtectorTypeName { get; set; }
    }
}