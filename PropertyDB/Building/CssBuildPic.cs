using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PropertyDB.Building
{
    public class CssPicture
    {
        [Key]
        public string Code { get; set; }
        [Display(Name = "Ruta")]
        public string Path { get; set; } // photo path
    }
}
