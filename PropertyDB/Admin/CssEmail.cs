using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PropertyDB.Admin
{

    /// <summary>
    /// Email Accounting for keep more that one email.
    /// </summary>
    public class CssEmail
    {
        [Key]
        public int Code { get; set; }   // 1 

        [Display(Name = "Correo Electronico")]
        [Column(TypeName = "Varchar(150)")]
        public string Email { get; set; } // Cluanamoon@hotmail.com

    }
}
