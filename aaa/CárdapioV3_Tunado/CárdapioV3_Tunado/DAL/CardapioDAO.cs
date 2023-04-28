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

        public List<Produto> getTodasSobremesas()
        {
            var sql = "SELECT * FROM Produto WHERE CategoriaProduto = 'Petisco'";
            var dados = (List<Produto>)_connection.Query<Produto>(sql);
            return dados;
        }

        public List<Produto> getTodasBebidasAlcholicas()
        {
            var sql = "select * from Produto where CategoriaProduto='Bebidas Alcholicas'";
            var dados = (List<Produto>)_connection.Query<Produto>(sql);
            return dados;
        }

        public List<Produto> getTodosProdutos()
        {
            var sql = "select * from Produto";
            var dados = (List<Produto>)_connection.Query<Produto>(sql);
            return dados;
        }



    }
}
