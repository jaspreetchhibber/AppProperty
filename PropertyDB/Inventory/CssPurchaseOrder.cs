using PropertyDB.Admin;
using PropertyDB.People;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PropertyDB.Inventory
{
    public class CssPurchaseOrder
    {
        [Key]
        public int Code { get; set; }
        
        public CssCompany Company { get; set; }

        public CssSupplier Supplier { get; set; }
        [Display(Name = "Fecha ")]
        public DateTime PODate { get; set; }

        [Display(Name = "Total")]
        public decimal POTotal { get; set; }

        [Display(Name = "Descuento")]
        public decimal PODescuent { get; set; }

        [Display(Name = "ITBIS")]
        public decimal Itbis { get; set; }

        [Display(Name = "Tipo de Pago ")]       //-8,15, 30days
        public CssGeneral PayKind { get; set; }

        [Display(Name = "Condición")]
        public CssGeneral Condition { get; set; } // Credit / Cash

        [Display(Name = "Balance")]
        public decimal Balance { get; set; }

        [Display(Name = "Empleado")]
        public CssEmployee EmployeeID { get; set; }

        public decimal Flete { get; set; }

        public string Comment { get; set; }

        public int IdTransportista { get; set; }
        
        [Display (Name= "Comprobante")]
        public string TaxReceipt { get; set; }

        public DateTime Create { get; set; }
    }
}
