using PropertyDB.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PropertyDB.Payroll
{
    public class CssCompensation
    {
        [Key]
        public string Code { get; set; }

        [Display(Name = "Tipo de Compensación")]
        public CssGeneral CompensationKind { get; set; }

        [Display(Name = "Monto de Compensación")]
        public decimal CompensationAmount { get; set; }

        [Display(Name = "Fecha de Pago")]
        public decimal DatePay{ get; set; }

        [Display(Name = "Estatus")]
        public CssGeneral Estatus { get; set; }

    }
}
