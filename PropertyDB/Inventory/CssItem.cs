using PropertyDB.Admin;
using PropertyDB.Building;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PropertyDB.Inventory
{
    public class CssItem
    {
        [Key]
        public int Code { get; set; }
        [Required]
        [Display(Name = "Descripción")]
        public string Description { get; set; }

        [Display(Name = "UPC Number")]
        public string UPC { get; set; }
        
        [Display(Name = "Referencia")]
        public string BarCode { get; set; }
        
        [Display(Name = "Cant Max")]
        public string MaxCant { get; set; }
        
        [Display(Name = "Cant Min")]
        public string MinCant { get; set; }
        
        [Display(Name = "Punto de Ordenar")]
        public string ReOrderPoint { get; set; }
        
        [Display(Name = "Itbis")]
        public Boolean Tax { get; set; }

        [Display(Name = "Grupo")]
        public string Belong { get; set; }
        
        [Display(Name = "Marca ")]
        public string BrandName{ get; set; }
        
        [Display(Name = "Categoria")]
        public string Category { get; set; }
        
        [Display(Name = "Und Almacenamiento")]
        public CssGeneral  StoreUnit{ get; set; }
        
        [Required]
        [Display(Name = "Costo")]
        public string ItemCost { get; set; }
        
        [Display(Name = "Foto")]
        public List<CssPicture> Pics { get; set; }
        
        [Display(Name = "Estatus")]
        public CssGeneral Status { get; set; }

        [Display(Name = "Movimiento Mensual")]
        public string MonthMove { get; }
        [Display(Name = "Movimiento Anual")]
        public string AnnualMove { get; }
        [Display(Name = "Existencia")]
        public decimal Invetory { get;  }
        public DateTime Create { get; }
    }
}
