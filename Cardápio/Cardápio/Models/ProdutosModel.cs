using System.ComponentModel.DataAnnotations;

namespace Cardápio.Models
{
	public class ProdutosModel
	{
        [Key] public int ProdutoID { get; set; }
        public string Descricao { get; set; }
        public string Nutricao { get; set; }
        public string Ingredientes { get; set; }
        public double Valor { get; set; }

    }
}
