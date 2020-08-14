using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PropertyDB.Admin
{
    public class CssUser
    {
        [Key]
        public int Code { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Clave")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar Clave")]
        [Compare("Password", ErrorMessage = "Clave y Confirmar Clave no son Iguales")]
        public string ConfirmPassword { get; set; }

        public CssRole Role { get; set; }
    }
}
