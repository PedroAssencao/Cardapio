using MySql.Data.MySqlClient;

namespace CárdapioV3_Tunado.Models
{
    public class ConexaoBD
    {
        private static MySqlConnection _banco;

        public static MySqlConnection getConexao()
        {
            if (_banco == null)
            {
                return _banco = new MySqlConnection("server = localhost; port = 3306; database = bdcardapio; user = root; password = Produção0310*; Persist Security Info=False; Connect Timeout = 300");
            }
            else
            {
                return _banco;
            }
        }
    }
}
