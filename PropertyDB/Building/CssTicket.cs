using PropertyDB.Admin;
using PropertyDB.People;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PropertyDB.Building
{
    public class CssTicket
    {
        /// <summary>
        /// 
        /// </summary>

        [Key]
        public int Code { get; set; }

        // Priority that request the service high/normal/low
        [Display(Name = "Prioridad")] 
        public CssGeneral Priority { get; set; }

        [Display(Name = "Requerido")]
        public DateTime Requested { get; set; }

        [Display(Name = "Asignado")]
        public DateTime Assigned{ get; set; }

        [Display(Name = "Solucionado")]
        public DateTime Resolved{ get; set; }

        /// <summary>
        /// Unit that will be defined a ticket to perform an action: Maintanance
        /// </summary>
        [Required]
        public CssUnit UnitNumber { get; set; }

        [Required]
        [Display(Name = "Descripción")]
        [Column(TypeName = "Varchar(100)")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Detalle")]
        [Column(TypeName = "Varchar(255)")]
        public string Detail { get; set; }

        [Required]
        [Display(Name = "Descripción")]
        [Column(TypeName = "Varchar(255)")]
        public string Resolution { get; set; }

        [Required]
        [Display(Name = "Presupuesto")]
        public decimal Cost { get; set; }

        [Display(Name = "Estatus")]
        public CssGeneral Status { get; set; }

        // employee or service provider in which will assigned the maintanance
        public CssAsignedTo AsignedTo { get; set; }

        // Picture's group for maintanance
        public IEnumerable<CssPicture> Pics { get; set; }
    }
}

