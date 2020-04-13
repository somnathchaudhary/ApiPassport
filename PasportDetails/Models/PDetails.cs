using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PasportDetails.Models
{
    public class PDetails
    {
        [Key]
        public int PId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string PHolderName { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(8)")]
        public string PPNumber { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(5)")]
        public string PPExp { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(6)")]
        public string PPOCode { get; set; }
    }
}
