
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PropertyDB.Admin
{
    /// <summary>
    /// Kind of Phones (Home, Cell, Work Phone)
    /// </summary>
    public enum PhoneType
    {
        Casa, Celular, Trabajo, Otro
    }

    public class CssPhone
    {
        [Key]
        public int Code { get; set; }
        [Column(TypeName = "Varchar(15)")]
        [Display(Name = "Tipo de Telefono")]
        public PhoneType? PhoneType { get; set; }

        [Column(TypeName = "Varchar(16)")] //1 (917) 346-4416
        [Display(Name = "Tipo de Telefono")]
        public string PhoneNumber { get; set; }

        [Column(TypeName = "Varchar(50)")]
        [Display(Name = "Proveedor de Servicio")]
        public string Provider { get; set; }
    }
}

