using System;
using System.ComponentModel.DataAnnotations;

namespace Rosneft.Domain.Entities
{
    public class Hole
    {
        [Key] [Required] public Guid Id { get; set; }

        [Required] public string HoleName { get; set; }
    }
}