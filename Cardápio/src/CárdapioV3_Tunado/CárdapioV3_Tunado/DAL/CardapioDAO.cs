using CárdapioV3_Tunado.Models;
using Dapper;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace CárdapioV3_Tunado.DAL
{
    public class CardapioDAO
    {
        private MySqlConnection _connection;

        public CardapioDAO()
        {
            _connection = ConexaoBD.getConexao();
        }


        public List<CategoriaProdutoView> getTodosCategorias()
        {
            var sql = "select * from Categoria";

            var dados = (List<CategoriaProdutoView>)_connection.Query<CategoriaProdutoView>(sql);
            return dados;

        }

        public List<Empresa> getFotosEmpresa(int idEmpresa)
        {
            var query = "select FotoEmpresa from Empresa where EmpresaID=" + idEmpresa;

            var dados = (List<Empresa>)_connection.Query<Empresa>(query);
            return dados;
        }

        public List<CategoriaProdutoView> getTodasCategoriasbyEmpresa(int idEmpresa)
        {
            var sql = "select distinct categorias.categoriaID, categorias.nome, categorias.CategoriaFoto, categorias.CategoriaDescricao  from produto produtos join categoria categorias on produtos.categoriaID=categorias.categoriaID where EmpresaID=" + idEmpresa;

            var dados = _connection.Query<CategoriaProdutoView>(sql);
            return (List<CategoriaProdutoView>)dados;
        }

        public List<CategoriaProdutoView> getTodosProdutosbyEmpresa(int idEmpresa)
        {
            var sql = "select produtos.*, categorias.*, empresas.* from produto produtos join categoria categorias on produtos.categoriaID=categorias.categoriaID join Empresa empresas on produtos.EmpresaID=empresas.EmpresaID where empresas.EmpresaID=" + idEmpresa;

            var dados = _connection.Query<CategoriaProdutoView>(sql);
            return (List<CategoriaProdutoView>)dados;
        }

            
        public List<CategoriaProdutoView> getTodosProdutos()
        {
            var sql = "select * from Produto";
            
            var dados = (List<CategoriaProdutoView>)_connection.Query<CategoriaProdutoView>(sql);
            return dados;
        }

        //inserir produtos

        public void InsertProdutos(CategoriaProdutoView Produto)
        {

            string query = "insert Produto (NomeProduto,DescricaoProduto,PrecoProduto,CategoriaProduto) values (@NomeProduto,@DescricaoProduto,@PrecoProduto,@CategoriaProduto)";


            int qtdInserida = _connection.Execute(query, Produto);
        }
        
        //update

        public void UptdateProdutos(CategoriaProdutoView novoProduto)
        {
            string query = "update Produto set NomeProduto=@NomeProduto, DescricaoProduto=@DescricaoProduto, PrecoProduto=@PrecoProduto, CategoriaProduto=@CategoriaProduto where ProID=@ProID";

            int qtdAtualizada = _connection.Execute(query, novoProduto);

        }

        //apagar

        public void ApagarProdutos(CategoriaProdutoView Produto)
        {
            string query = "Delete Produto where ProID=@ProID";

            int qtdAtualizada = _connection.Execute(query, Produto);

        }








    }
}
