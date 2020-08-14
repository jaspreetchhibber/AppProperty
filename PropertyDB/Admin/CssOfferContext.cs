using PropertyDB.Inventory;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PropertyDB.Admin
{
    public class CssOfferContext
    {
        [Key]
        public int Code { get; set; }

        [Display(Name = "Ruta del Logo")]
        public string PathLogo { get; set; }
        
        [Column(TypeName = "Varchar(75)")]
        [Display(Name = "Ruta de la Foto")]
        public string Desctription { get; set; }

        [Display(Name = "Precio de oferta")]
        public decimal Price { get; set; }

        [Display(Name = "Codigo del Producto")]
        public CssItem PageToGo { get; set; }

        [Display(Name = "Ruta de la Foto")]
        public string PathPic { get; set; }

        [Display(Name = "Estatus")]
        public CssGeneral Status { get; set; }
    }
}
