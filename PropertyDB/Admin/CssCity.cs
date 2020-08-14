using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PropertyDB.Admin
{
    /// <summary>
    /// City Class
    /// </summary>
    public class CssCity
    {
        [Key]
        public int Code { get; set; }
        [Column(TypeName = "Varchar(100)")]
        [Display(Name = "Ciudad")]
        public string City { get; set; }
        
        /// <summary>
        /// State Class with atribute
        /// </summary>
        public CssState State{ get; set; }
    }
}
