using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PropertyDB.Accounting
{
    public class CssCatalog
    {
        [Key]
        public int Code { get; set; }
        public string CUENTA { get; set; }
        public string DESCRIPCION { get; set; }
        public int CUENTATIPO { get; set; }
        public int CTACONTROL { get; set; }
        public string SUPERCUENTA { get; set; }
        public decimal BALANCE { get; set; }
        public decimal ABALANCE { get; set; }
        public decimal DEBITO { get; set; }
        public decimal CREDITO { get; set; }
        public decimal DRMENSUAL { get; set; }
        public decimal CRMENSUAL { get; set; }
        public string FECHA { get; set; }
        public int RESULTADO { get; set; }
        public int SITUACION { get; set; }
        public int ANALITICO { get; set; }
    }
}
