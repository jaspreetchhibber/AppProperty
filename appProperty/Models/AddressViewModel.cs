using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace appProperty.Models
{
    public class AddressViewModel
    {
        public int Code { get; set; }
        [Display(Name = "Dirección")]
        [Column(TypeName = "Varchar(200)")]
        public string Address { get; set; }
        [Display(Name = "Ciudad")]
        public int CityCode { get; set; }
        public int StateCode { get; set; }
        public int CountryCode { get; set; }
        public int RegionCode { get; set; }
        public int ContinentCode { get; set; }
    }
}
