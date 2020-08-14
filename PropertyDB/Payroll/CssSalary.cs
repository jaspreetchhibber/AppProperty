using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PropertyDB
{
    /// <summary>
    /// Salary Change: it will be the history of the wages that the Employee has had ( Class only set when change salary Employee)
    /// </summary>
    public class CssSalary
    {
        [Key]
        public int Code { get; set; }
        public DateTime DateFrom{ get; set; }
        public DateTime DateTo { get; set; }
        public decimal Salary { get; set; }
        public string Note { get; set; }
    }
}
