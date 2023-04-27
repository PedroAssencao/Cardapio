using System.Runtime.InteropServices;

namespace CárdapioV3_Tunado.Models
{
    public class Produto
    {
        public int ProID { get; set; }
        public string NomePruduto { get; set; }
        public string DetalhesProduto { get; set; }
        public string NutricaoProduto { get; set; }
        public double PrecoProduto { get; set; }
        public string CategoriaProduto { get; set; }
    }
}