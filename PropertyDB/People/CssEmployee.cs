using PropertyDB.Admin;
using PropertyDB.Building;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Text;

namespace PropertyDB.People
{
    public class CssEmployee
    {
        [Key]
        public int Code { get; set; }

        public CssUser User{ get; set; }

        [Display(Name = "Tipo Nomina")]
        public CssGeneral PayrollKind { get; set; }

        [Display(Name = "Posición")]
        public CssGeneral Position { get; set; }
      
        [Display(Name = "Fecha Ingreso")]
        public DateTime EntryDate { get; set; }
        [Display(Name = "Salario")]
        public decimal Salary { get; set; }

        public CssSalary SalaryHistory { get; set; }

        public CssGeneral Status { get; set; }
        [Display(Name = "Foto")]
        public string Pic { get; set; }


    }
}
