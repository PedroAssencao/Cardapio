using CárdapioV3_Tunado.Models;
using Dapper;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace CárdapioV3_Tunado.DAL
{
    public class ProdutoEmpresaDAO
    {
        private MySqlConnection _connection;
        public ProdutoEmpresaDAO()
        {
            _connection = ConexaoBD.getConexao();
        }

        public List<CategoriaProdutoView> getTodosProdutosbyEmpresa(int idEmpresa)
        {
            var sql = "Select ep.*, p.NomeProduto, p.CategoriaProduto, p.ProID, c.Nome, c.CategoriaID from produtoempresa ep join Produto p on ep.ProdutoID=p.ProID join categoria c on ep.CategoriaID=c.CategoriaID where ep.EmpresaID=" + idEmpresa;

            var dados = _connection.Query<CategoriaProdutoView>(sql);
            return (List<CategoriaProdutoView>)dados;
        }

        public void ApagarProduto(ProdutoEmpresa deleteProduto)
        {
            string query = "delete from ProdutoEmpresa where ProdutoID=@ProdutoID";

            int qtdAtualizada = _connection.Execute(query, deleteProduto);

        }
    }
}
