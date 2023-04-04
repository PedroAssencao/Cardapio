using System.ComponentModel.DataAnnotations;

namespace Cardápio.Models
{
	public class LuluComidaCaseiraModels
	{
		[Key] public int LuluComidaCaseiraID { get; set; }
		public string? NomeProduto { get; set; }
		public string? Nomecategoria { get; set; }
		public string? NutricaoProduto { get; set; }
		public string? IngredientesProduto { get; set; }
		public double? valorProduto { get; set; }
	}
}
