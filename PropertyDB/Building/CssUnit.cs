using PropertyDB.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace PropertyDB.Building
{
    /// <summary>
    /// Unit Class: it will store all the information regarding a unit of the building. Also, it is related to the class CssUnitHas that defines all belongs to this unit.
    /// </summary>
    public class CssUnit
    {
        [Key]
        public int Code { get; set; }
        [Required]
        [Display(Name = "Unidad ")]
        public string UnitNumber { get; set; }
        
        [Required]
        [Display(Name = "Descripción")]
        public string Description { get; set; }
        
        [Required]
        [Display(Name = "Precio")]
        public Decimal RentalAmount { get; set; }
        
        [Display(Name = "Dimenciones (Largo x Ancho)")]
        public string LotSize { get; set; }
        
        [Display(Name = "Tamaño (Pies/Mts)")]
        public string SquareFoot { get; set; }

        [Display(Name = "Numero Piso")]
        public int Level { get; set; }

        public List<CssUnitHas> UnitHas { get; set; }

        public List<CssAmenities> Amenities { get; set; }

        [Required]
        public CssBuilding Building { get; set; }

        [Display(Name = "Estatus")]
        public CssGeneral Status { get; set; }

        public int CssBuildingCode { get; set; }

    }
}
