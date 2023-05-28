using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Rosneft.Domain.Entities
{
    public class RepairDescription
    {
        [Key] [Required] public Guid Id { get; set; }

        [Required] public Guid RepairId { get; set; }

        [Column(DbType = "nvarchar(max)")] public string DescriptionOfWork { get; set; }

        //[Column(DbType = "varbinary(max)")] public Binary DocFile { get; set; }

        //[Column(DbType = "varbinary(max)")] public Binary PdfFile { get; set; }

        //[Column(DbType = "varbinary(max)")] public Binary ExcelFile { get; set; }

        public string DateOfWork { get; set; }

        public string TimeOfWork { get; set; }
    }
}