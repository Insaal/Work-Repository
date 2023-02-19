using System;
using System.ComponentModel.DataAnnotations;

namespace Rosneft.Domain.Entities
{
    public class Team
    {
        [Key]
        [Required] public Guid Id { get; set; }

        [Required] public string TeamName { get; set; }
    }
}