using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PropertyDB.Admin
{
    public class CssReponsability
    {

        [Key]
        public string Code { get; set; }

        [Display(Name = "Reponsabilidad")]
        public CssGeneral ResponsabilityKind { get; set; }  //  Loan, missing cash, call, ...

        [Display(Name = "Monto")]
        public decimal OriginalAmount { get; set; }

        [Display(Name = "Balance")]
        public decimal Balance { get; set; }

        [Display(Name = "Cuota")]
        public decimal PayAmount { get; set; }      // OrignalAmount div DealAmount

        [Display(Name = "Numero de Pago")]
        public decimal DealAmount { get; set; }      

        [Display(Name = "Fecha de Creación")]
        public DateTime DateResponsability { get; set; }

        [Display(Name = "Frecuencia")]
        public CssGeneral Frequency { get; set; } // Weekly / biweekly / monthly

        [Display(Name = "Estatus")]
        public CssGeneral Status { get; set; }

    }
}