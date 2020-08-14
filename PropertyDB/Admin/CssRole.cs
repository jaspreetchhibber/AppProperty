using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PropertyDB.Admin
{
    public class CssRole
    {
        [Key]
        public int Code { get; set; }
        
        [Required]
        [Column(TypeName = "Varchar(100)")]
        public string Role { get; set; }

        public CssGeneral Kind { get; set; }

        [Required]
        [Column(TypeName = "Varchar(255)")]
        public string Path { get; set; }

    }
}
