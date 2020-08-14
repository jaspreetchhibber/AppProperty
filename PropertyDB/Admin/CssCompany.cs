using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PropertyDB.Admin
{
	public class CssCompany
	{
		[Key]
		public int Codigo { get; set; }
		[Display(Name = "NombreEmpresa")]
		[Column(TypeName = "varchar(75)")]
		public string Company { get; set; }

		public CssAddress Address { get; set; }

		public CssPhone Phone { get; set; }

		[Display(Name = "NombreEmpresa")]
		[Column(TypeName = "varchar(35)")]
		public string LegalRegiter { get; set; }

		[Display(Name = "CFN Numero")]
		[Column(TypeName = "varchar(75)")]
		public string CFNNumer { get; set; }

		[Display(Name = "CFN Secuencia")]
		[Column(TypeName = "varchar(75)")]
		public string CFNSecuencia { get; set; }

		[Display(Name = "Fecha Inicio")]
		public DateTime DateStart { get; set; }
		[Display(Name = "Fecha de Pago")]
		public DateTime DatePay { get; set; }
		[Display(Name = "Ultimo Pago")]
		public DateTime DateLastPay { get; set; }
		[Display(Name = "Estatus")]
		public CssGeneral Status { get; set; }
		[Display(Name = "Logo")]
		[Column(TypeName = "varchar(255)")]
		public string Logo { get; set; }
		[Display(Name = "Contacto")]
		[Column(TypeName = "varchar(50)")]
		public string Contact { get; set; }
	}
}