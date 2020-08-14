using PropertyDB.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PropertyDB.Inventory
{
    public class CssPurchaseOrderDetail
    {
        [Key]
        public int Code { get; set; }

        public CssCompany Company { get; set; }
        [Display(Name = "# Factura")]
        public CssPurchaseOrder PurchaseOrder { get; set; }

        [Display(Name = "Producto")]
        public CssItem ProductID { get; set; }

        [Display(Name = "Cantidad ")]
        public decimal Quantity { get; set; }

        [Display(Name = "Precio ")]
        public decimal Price { get; set; }

        [Display(Name = "Costo ")]
        public decimal Cost { get; set; }

        [Display(Name = "Descuento")]
        public decimal Descuent { get; set; }

        [Display(Name = "Total")]
        public decimal NetPrice { get; set; }

        [Display(Name = "Lote")]
        [Column(TypeName = "Varchar(30)")]
        public string LoteId { get; set; }

        [Display(Name = "Zona")]
        public CssGeneral Zone{ get; set; } //Zona A, B, ... Where the Item will be located

        [Display(Name = "Tramo")] // a location of the Item  
        public CssGeneral Stretch { get; set; }

        [Display(Name = "Factor Unidad")]
        public decimal UndFactor { get; set; }

        [Display(Name = "Fecha de Vencimiento")]
        public DateTime BestDate{ get; set; }
    }
}
