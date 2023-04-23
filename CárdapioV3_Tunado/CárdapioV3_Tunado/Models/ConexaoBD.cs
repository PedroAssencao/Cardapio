using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace CárdapioV3_Tunado.Models
{
    public class ConexaoBD
    {
        private static SqlConnection _banco;

        public static SqlConnection getConexao()
        {
            if (_banco == null)
            {
                return _banco = new SqlConnection(@"Server=DESKTOP-VIKGCGP\SQLEXPRESS; Database=Cardapio; User Id =sa; Password=31102006;");
            }
            else
            {
                return _banco;
            }
        }
    }
}
