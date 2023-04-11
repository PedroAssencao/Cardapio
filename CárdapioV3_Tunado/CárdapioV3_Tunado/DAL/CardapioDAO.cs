using CárdapioV3_Tunado.Models;
using Dapper;
using MySql.Data.MySqlClient;

namespace CárdapioV3_Tunado.DAL
{
    public class CardapioDAO
    {
        private MySqlConnection _connection;

        public CardapioDAO()
        {
            _connection = ConexaoBD.getConexao();
        }

        public List<Categoria> getTodasCategorias()
        {
            var sql = "select * from Categoria;";
            var dados = (List<Categoria>)_connection.Query<Categoria>(sql);
            return dados;
        }

        public List<Cardapio> getTodasSobremesas()
        {
            var sql = "SELECT * FROM LuluComidaCaseira WHERE NomeCategoria = 'Sobremesas'";
            var dados = (List<Cardapio>)_connection.Query<Cardapio>(sql);
            return dados;
        }

    }
}
