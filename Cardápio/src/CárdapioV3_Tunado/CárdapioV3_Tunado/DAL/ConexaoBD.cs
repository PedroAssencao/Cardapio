using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace CárdapioV3_Tunado.DAL
{
    public class ConexaoBD
    {
        private static MySqlConnection _banco;

        public static MySqlConnection getConexao()
        {
            if (_banco == null)
            {
                //return _banco = new MySqlConnection(@"server = localhost; port = 3306; database = Cardapio; user = root; password = 123456; Persist Security Info=False; Connect Timeout = 300");
                return _banco = new MySqlConnection(@"server=localhost;port=3306;database=Cardapio;user=root;password=123456;");
            }
            else
            {
                return _banco;
            }
        }
    }
}
