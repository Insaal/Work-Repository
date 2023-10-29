using System;
using System.ComponentModel.DataAnnotations;

namespace Rosneft.Domain.Entities
{
    public class Operations
    {
        [Key]
        [Required] public Guid Id { get; set; }

        [Required] public string OperationName { get; set; }

        [Required] public string NormMin { get; set; }
    }
}