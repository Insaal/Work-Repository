using System;
using System.ComponentModel.DataAnnotations;

namespace Rosneft.Domain.Entities
{
    public class PipeDiameter
    {
        [Key]
        [Required] public Guid Id { get; set; }

        [Required] public string Diameter { get; set; }
    }
}