using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PropertyDB.Admin
{
    /// <summary>
    ///      This class will store all the general concepts of the system.This avoids having multiple table with two or three fields.
    ///  I'm going to use it to store system information that needs a general table. 
    ///  example :  (Kind s 1, Description: "Building Type"); "KIND" is defined as the Building Type which you are already registering.
    /// </summary>
    
    public class CssGeneral
    {
        [Key]
        public int Code { get; set; }                       //1,2,3,4,5,6...
        
        // "Concept Type"
        public CssKind Kind { get; set; }                   // =1

        [Column(TypeName = "Varchar(100)")]
        [Display(Name = "Descripción del Concepto")]
        public string Description { get; set; }             // "Apartament"

        [Column(TypeName = "Varchar(20)")]
        [Display(Name = "Depende")]
        public string DependsOn { get; set; }               //""

        [Column(TypeName = "Varchar(20)")]
        [Display(Name = "Desde")]
        public string Start { get; set; }                   //""

        [Column(TypeName = "Varchar(20)")]
        [Display(Name = "Hasta")]
        public string End { get; set; }                    //""

        [Display(Name = "Usar")]
        public Boolean Used { get; set; }                  // True/False
    }
}
