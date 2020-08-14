using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using PropertyDB.People;

namespace PropertyDB.Building
{
    /// <summary>
    /// Section Class
    /// </summary>
    public class CssSection
    {
        [Key]
        public int Code { get; set; }

        [Required]
        [Display(Name = "Descripción")]
        public string Description { get; set; }
        public CssEmployee Employee { get; set; }
        public CssBuilding Building { get; set; }
    }
}
