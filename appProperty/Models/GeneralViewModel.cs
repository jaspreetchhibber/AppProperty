using PropertyDB.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace appProperty.Models
{
    public class GeneralViewModel
    {
        public int Code { get; set; }  
        public int KindCode { get; set; } 

        [Column(TypeName = "Varchar(100)")]
        [Display(Name = "Descripción del Concepto")]
        public string Description { get; set; } 

        [Column(TypeName = "Varchar(20)")]
        [Display(Name = "Depende")]
        public string DependsOn { get; set; } 

        [Column(TypeName = "Varchar(20)")]
        [Display(Name = "Desde")]
        public string Start { get; set; } 

        [Column(TypeName = "Varchar(20)")]
        [Display(Name = "Hasta")]
        public string End { get; set; } 

        [Display(Name = "Usar")]
        public Boolean Used { get; set; }
    }
}
