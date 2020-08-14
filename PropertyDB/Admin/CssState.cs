using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PropertyDB.Admin
{
    public class CssState
    {
        [Key]
        public int Code { get; set; }

        [Column(TypeName = "Varchar(100)")]
        [Display(Name = "Estado")]
        public string State { get; set; }

        /// <summary>
        /// Country Class with atribute 
        /// </summary>
        public CssCountry Country { get; set; }
    }
}
