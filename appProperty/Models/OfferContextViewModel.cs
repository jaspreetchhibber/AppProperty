using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace appProperty.Models
{
    public class OfferContextViewModel
    {
        public int Code { get; set; }
        [Display(Name = "Ruta del Logo")]
        public string PathLogo { get; set; }

        [Column(TypeName = "Varchar(75)")]
        [Display(Name = "Ruta de la Foto")]
        public string Desctription { get; set; }

        [Display(Name = "Precio de oferta")]
        public decimal Price { get; set; }

        [Display(Name = "Codigo del Producto")]
        public int PageToGo { get; set; }

        [Display(Name = "Ruta de la Foto")]
        public string PathPic { get; set; }

        [Display(Name = "Estatus")]
        public int Status { get; set; }
    }
}
