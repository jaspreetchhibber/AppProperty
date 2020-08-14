
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PropertyDB.Admin
{
    public class CssAddress
    {
        [Key]
        public int Code { get; set; }
        [Display(Name = "Dirección")]
        [Column(TypeName = "Varchar(200)")]
        public string Address { get; set; }
        [Display(Name = "Ciudad")]
        public CssCity City { get; set; }

    }
}
