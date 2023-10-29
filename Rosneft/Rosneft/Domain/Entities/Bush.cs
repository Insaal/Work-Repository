using System;
using System.ComponentModel.DataAnnotations;

namespace Rosneft.Domain.Entities
{
    public class Bush
    {
        [Key]
        [Required] public Guid Id { get; set; }

        [Required] public string BushName { get; set; }
    }
}