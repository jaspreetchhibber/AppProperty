using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using PropertyDB.Admin;

namespace PropertyDB.Building
{
    /// <summary>
    /// Unit In Out Class
    /// </summary>
    public class CssUnitInOut
    {
        [Key]
        public int Code { get; set; }
        public CssUnit UnitCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int PeriodTime { get; set; }
        public string Plate { get; set; }
        public CssUser User { get; set; }
    }
}
