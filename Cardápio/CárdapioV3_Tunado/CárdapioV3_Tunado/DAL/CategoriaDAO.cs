using CárdapioV3_Tunado.Models;
using Dapper;
using MySql.Data.MySqlClient;

namespace CárdapioV3_Tunado.DAL
{
    public class CategoriaDAO
    {
        MySqlConnection _connection;

        public CategoriaDAO()
        {
            _connection = ConexaoBD.getConexao();
        }

        public List<CategoriaProdutoView> getTodasCategorias()
        {
            var sql = "select * from Categoria";

            var dados = (List<CategoriaProdutoView>)_connection.Query<CategoriaProdutoView>(sql);
            return dados;
        }

        public void InsertCategoria(CategoriaProdutoView novaCategoria)
        {
            string query = "Insert Categoria (Nome, CategoriaDescricao, CategoriaFoto) values (@Nome, @CategoriaDescricao, @CategoriaFoto)";

            int qtdinserida = _connection.Execute(query, novaCategoria);

        }

        public int CategoriaIDRetornar()
        {
            int result = _connection.QueryFirst<int>("select Max(CategoriaID) from Categoria ");

            return result;
        }

        //update

        public void UptdateCategoria(CategoriaProdutoView EditarCategoria)
        {
            string query = "update Categoria set Nome=@Nome, CategoriaDescricao=@CategoriaDescricao, CategoriaFoto=@CategoriaFoto where CategoriaID=@CategoriaID";

            int qtdAtualizada = _connection.Execute(query, EditarCategoria);

        }

        //apagar

        public void ApagarCategoria(CategoriaProdutoView deleteCategoria)
        {
            string query = "Delete from Categoria where CategoriaID=@CategoriaID";

            int qtdAtualizada = _connection.Execute(query, deleteCategoria);

        }
    }
}
