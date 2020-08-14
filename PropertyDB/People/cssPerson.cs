using PropertyDB.Admin;
using PropertyDB.Building;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PropertyDB
{
    public class CssPerson
    {

        [Key]
        public int Code { get; set; }
        [Display(Name = "Nombre(s)")]
        public string FirstName { get; set; }

        [Display(Name = "Apellido(s)")]
        public string LastName{ get; set; }
        
        public CssAddress Address { get; set; }

        public CssPhone Phone { get; set; }

        public CssEmail Email { get; set; }

        public CssGeneral SocialNetwork { get; set; }

        public CssPicture Pic { get; set; }
    }
}
