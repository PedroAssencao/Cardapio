using System.ComponentModel.DataAnnotations;

namespace Cardápio.Models
{
	public class categoriaProduto
	{
        [Key] public int CategoriaP { get; set; }
        public string NomeProduto { get; set; }
        public string Nomecategoria { get; set; }
        public string NutricaoProduto { get; set; }
        public string IngredientesProduto { get; set; }
        public double valorProduto { get; set; }

    }
}
