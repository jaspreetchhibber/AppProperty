using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PropertyDB.Admin
{
    public class CssCountry
    {
        [Key]

        public int Code { get; set; }
        [Column(TypeName = "Varchar(3)")]
        [Display ( Name ="Abreviatura del Pais")]
        public string CountryAbr { get; set; }

        [Column(TypeName = "Varchar(100)")]
        [Display(Name = "País")]
        public string Country { get; set; }

        [Column(TypeName = "Varchar(75)")]
        [Display(Name = "Región")]
        public string Region { get; set; }

        [Column(TypeName = "Varchar(50)")]
        [Display(Name = "Continente")]
        public string Continent { get; set; }
    }
}
