using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PropertyDB.Admin
{
    /// <summary>
    /// This class is for the different types of General Concepts that will be used in the system
    /// Example: Building Type (Code = 1, Description: "Apartment")
    /// </summary>
    public class CssKind
    {
        [Key]
        public int Code { get; set; }
        [Column(TypeName = "Varchar(100)")]
        [Display(Name = "Descripción del Concepto")]
        public string Description { get; set; }
    }
}
