using PropertyDB.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PropertyDB.Building
{
    public class CssBuilding
    {
        [Key]
        public int Code { get; set; }
        
        [Required]
        [Display(Name = "Descripción")]
        public string Description { get; set; }
        
        [Required]
        [Display(Name = "Nombre del Edificio")]
        public string BuldingName { get; set; }

        [Display(Name = "Tipo de Propiedad")]
        public CssGeneral BuldingType { get; set; }  // List that comes from the CssGeneral class must be assigned, because it is defined. Thetable is filtered by KIND


        public CssAddress Address { get; set; }
         
        public CssPhone Phone { get; set; }

        [Display(Name = "Año: Construido")]
        public int YearBuilt { get; set; }
        
        [Display(Name = "Dimenciones (Largo x Ancho)")]
        public string LotSize { get; set; }

        [Display(Name = "Tamaño (Pies/Mts")]
        public string SquareFoot { get; set; }
        
        [Required]
        [Display(Name = "Precio")]
        public Decimal RentalAmount { get; set; }

        [Display(Name = "Cuanto Pisos?")]
        public int LevelNumber { get; set; }

        [Display(Name = "Tiene Elevador S/N ?")]
        public Boolean Elvator { get; set; }

        public List<CssUnit> Units { get; set; }

        public CssGeneral Status { get; set; }

        public List<CssPicture> Pics { get; set; }


    }
}
