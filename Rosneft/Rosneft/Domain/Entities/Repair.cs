using System;
using System.ComponentModel.DataAnnotations;

namespace Rosneft.Domain.Entities
{
    public class Repair
    {
        [Key] [Required] public Guid Id { get; set; }

        [Required] public Guid TeamId { get; set; }

        [Required] public Guid FieldId { get; set; }

        [Required] public Guid BushId { get; set; }

        [Required] public Guid HoleId { get; set; }

        [Required] public string DateCreate { get; set; }

        [Required] public string TimeCreate { get; set; }

        [Required] public bool ArchiveRepair { get; set; }

        public string DateEnd { get; set; }

        public string TimeEnd { get; set; }
    }
}