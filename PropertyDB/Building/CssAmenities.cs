using PropertyDB.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PropertyDB.Building
{
   public class CssAmenities
    {
        [Key]
        public int Code { get; set; }
        [Display(Name = "Comodidad")]
        public CssGeneral KindAmenities{ get; set; } // Kitchen, Bathroom,Bedroom, Parking, Internet, Media & Technology, Room Amenities, Health & Wellness Facilities, Living Area, Services
        [Display(Name = "Descripción")]
        public string Description { get; set; } //Toilet paper, Bathtub or shower, Private Bathroom, Toilet, Hairdryer, Shower
        public CssGeneral Status { get; set; } // 
        public int CssUnitCode { get; set; }
    }
}
