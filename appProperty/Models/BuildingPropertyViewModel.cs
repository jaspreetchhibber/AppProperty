using PropertyDB.Building;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace appProperty.Models
{
    public class BuildingPropertyViewModel
    {
        public BuildingPropertyViewModel()
        {

        }
        public int Code { get; set; }

        [Required]
        [Display(Name = "Descripción")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Nombre del Edificio")]
        public string BuldingName { get; set; }

        [Display(Name = "Tipo de Propiedad")]
        public int BuldingTypeCode { get; set; }
        public Boolean AvailableStatus { get; set; }
        public string AddressValue { get; set; }
        public int PhoneCode { get; set; }
        public int CountryCode { get; set; }
        public int StateCode { get; set; }
        public int CityCode { get; set; }

        [Display(Name = "Año: Construido")]
        public int YearBuilt { get; set; }

        [Display(Name = "Dimenciones (Largo x Ancho)")]
        public string LotSize { get; set; }

        [Display(Name = "Tamaño (Pies/Mts)")]
        public string SquareFoot { get; set; }

        [Required]
        [Display(Name = "Precio")]
        public Decimal RentalAmount { get; set; }

        [Display(Name = "Cuanto Pisos?")]
        public int LevelNumber { get; set; }

        [Display(Name = "Tiene Elevador S/N ?")]
        public Boolean Elvator { get; set; }

        public string[] Amenities { get; set; }

        public int PicCode { get; set; }
    }
}
