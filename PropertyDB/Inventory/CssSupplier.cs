using PropertyDB.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PropertyDB.Inventory
{
    public class CssSupplier
    {
        [Key]
        public int Code { get; set; }
        //Get all Info from Person
        public CssPerson Supplier { get; set; }
        
        [Display(Name = "Categoria ")]
        public CssGeneral Category { get; set; }
        
        [Display(Name = "Limite Credito")]
        public decimal LineCredit { get; set; }
        
        [Display(Name = "Contacto")]
        [Column(TypeName = "varchar(50)")]
        public string NameContact { get; set; }
        
        [Display(Name = "Telefono")]
        [Column(TypeName = "varchar(15)")]
        public string PhoneContact { get; set; }
        
        [Display(Name = "Corre Electronico")]
        [Column(TypeName = "varchar(100)")]
        public string EmailContact { get; set; }
    }
}
