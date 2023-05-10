using CárdapioV3_Tunado.Models;
using Dapper;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace CárdapioV3_Tunado.DAL
{
    public class ProdutoDAO
    {
        MySqlConnection _connection;
        public ProdutoDAO()
        {
            _connection = ConexaoBD.getConexao();
        }

        public List<CategoriaProdutoView> getTodosProdutos()
        {
            var sql = "select * from Produto";

            var dados = (List<CategoriaProdutoView>)_connection.Query<CategoriaProdutoView>(sql);
            return dados;
        }

        public void InsertProduto(CategoriaProdutoView novoProduto)
        {
            string query = "Insert Produto (NomeProduto, DescricaoProduto, NutricaoProduto, PrecoProduto, CategoriaProduto) values (@NomeProduto, @DescricaoProduto, @NutricaoProduto, @PrecoProduto, @CategoriaProduto)";

            int qtdinserida = _connection.Execute(query, novoProduto);
        }

        public int ProdutoIDRetornar()
        {
            int result = _connection.QueryFirst<int>("select Max(CategoriaID) from Categoria ");

            return result;
        }

        //update

        public void UptdateProduto(CategoriaProdutoView EditarProduto)
        {
            string query = "update Produto set NomeProduto=@NomeProduto, DescricaoProduto=@DescricaoProduto, NutricaoProduto=@NutricaoProduto, PrecoProduto=@PrecoProduto, CategoriaProduto=@CategoriaProduto where ProID=@ProID";

            int qtdAtualizada = _connection.Execute(query, EditarProduto);

        }

        //apagar

        public void ApagarProduto(CategoriaProdutoView deleteProduto)
        {
            string query = "Delete from Produto where ProID=@ProID";

            int qtdAtualizada = _connection.Execute(query, deleteProduto);

        }
    }
}
