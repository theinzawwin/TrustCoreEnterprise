using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrustCoreEntity.Models
{
    [Table("RestTable")]
    public class RestTable
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Person { get; set; }
        public bool Available { get; set; }
        public bool Status { get; set; }
    }
}
