using PropertyDB.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PropertyDB.Payroll
{
    public class CssBenefit
 
    {
        [Key]
        public int Code { get; set; }
        [Display(Name = "Estatus")]
        
        public CssGeneral Beneficio { get; set; }

        [Display(Name = "Estatus")]
        [DisplayFormat(DataFormatString = "{0:dd/mm/yyyy}")]
        
        public DateTime DesdeFecha { get; set; }
        [Display(Name = "Estatus")]
        [DisplayFormat(DataFormatString = "{0:dd/mm/yyyy}")]
        public DateTime HastaFecha { get; set; }

        [Display(Name = "Estatus")]
        public decimal Amount { get; set; }

        [Column(TypeName = "Varchar(255)")]
        [Display(Name = "Estatus")]
        public string Observacion { get; set; }
        
        [Display(Name = "Estatus")]
        public CssGeneral Estatus { get; set; }
    }
}
