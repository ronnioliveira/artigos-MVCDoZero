using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArtigoMVC.Models
{
	public class Carro
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public string Montadora { get; set; }
		public int Ano { get; set; }
		public string Modelo { get; set; }
	}
}