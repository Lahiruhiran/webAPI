using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace webAPI.Models
{
    public class DCandidate
    {
        [Key]
        public int id { get; set; }
        [Column(TypeName ="nvarchar(100)")]
        public String fulName { get; set; }
        [Column(TypeName = "nvarchar(16)")]
        public String  Mobile { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public String email { get; set; }
        public int age { get; set; }
        [Column(TypeName = "nvarchar(3)")]
        public String bloodGroup { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public String  address { get; set; }
    }
}
