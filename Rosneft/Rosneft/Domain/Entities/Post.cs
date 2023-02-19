using System;
using System.ComponentModel.DataAnnotations;

namespace Rosneft.Domain.Entities
{
    public class Post
    {
        [Key]
        [Required] public Guid Id { get; set; }

        [Required] public string PostName { get; set; }
    }
}