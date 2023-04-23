using CárdapioV3_Tunado.Models;
using Dapper;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace CárdapioV3_Tunado.DAL
{
    public class CardapioDAO
    {
        private SqlConnection _connection;

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

        public List<Produto> getTodosPetiscos()
        {
            var sql = "SELECT * FROM Produto WHERE CategoriaProduto = 'petisco'";
            var dados = (List<Produto>)_connection.Query<Produto>(sql);
            return dados;
        }

        public List<Produto> getTodasBebidasAlcholicas()
        {
            var sql = "select * from Produto where CategoriaProduto='Bebidas Alcholicas'";
            var dados = (List<Produto>)_connection.Query<Produto>(sql);
            return dados;
        }
        public List<Produto> getTodasTesteFODA()
        {
            var sql = "select * from Produto where CategoriaProduto='TesteFODA'";
            var dados = (List<Produto>)_connection.Query<Produto>(sql);
            return dados;
        }

        public List<Produto> getTodasTesteFODA2()
        {
            var sql = "select * from Produto where CategoriaProduto='TesteFODA2'";
            var dados = (List<Produto>)_connection.Query<Produto>(sql);
            return dados;
        }
        public List<Produto> getTodasTesteFODA4()
        {
            var sql = "select * from Produto where CategoriaDescricao='*insira texto foda*'";
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
