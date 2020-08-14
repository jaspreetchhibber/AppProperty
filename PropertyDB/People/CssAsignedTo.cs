using PropertyDB.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PropertyDB.People
{
    public class CssAsignedTo
    {
        [Key]
        public int Code { get; set; }

        // Who will assign. Could be a Employee or a service provider (Company)
        public CssGeneral AsignedKind { get; set; }

        // Person or Company that will asigned this ticket
        public CssPerson Asigned { get; set; }

    }
}
