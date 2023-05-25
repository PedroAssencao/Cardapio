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

        public async Task< List<CategoriaProdutoView>> getTodosProdutos()
        {
            var sql = "select * from Produto";

            var dados = (List<CategoriaProdutoView>) await _connection.QueryAsync<CategoriaProdutoView>(sql);
            return dados;
        }

        public List<CategoriaProdutoView> SepararProdutos()
        {
            var sql = "SELECT distinct produtos.*, empresas.NomeEmpresa FROM Produto produtos JOIN Empresa empresas ON produtos.EmpresaID=empresas.EmpresaID;";

            var dados = (List<CategoriaProdutoView>)_connection.Query<CategoriaProdutoView>(sql);
            return dados;
        }

        public List<CategoriaProdutoView> getMaisPedidos(int idEmpresa)
        {
            string sql = $"select NomeProduto, QuantidadePesquisa from Produto where EmpresaID={idEmpresa} Order By QuantidadePesquisa desc";

            var dados = (List<CategoriaProdutoView>)_connection.Query<CategoriaProdutoView>(sql);

            return dados;
        }

        public int getQtdProdutosbyEmpresa(int idEmpresa)
        {
            var sql = $"select Count(*) from Produto where EmpresaID= {idEmpresa}";

            int dados = _connection.QueryFirst<int>(sql);

            return dados;
        }

        public void InsertProduto(CategoriaProdutoView novoProduto)
        {
            string query = "Insert Produto (NomeProduto, DescricaoProduto, NutricaoProduto, PrecoProduto, CategoriaID, EmpresaID, QuantidadePesquisa) values (@NomeProduto, @DescricaoProduto, @NutricaoProduto, @PrecoProduto, @CategoriaID, @EmpresaID, @QuantidadePesquisa)";

            int qtdinserida = _connection.Execute(query, novoProduto);
        }

        public int ProdutoIDRetornar()
        {
            int result = _connection.QueryFirst<int>("select Max(ProID) from Produto ");

            return result;
        }

        //update

        public void UptdateProduto(CategoriaProdutoView EditarProduto)
        {
            string query = "update Produto set NomeProduto=@NomeProduto, DescricaoProduto=@DescricaoProduto, NutricaoProduto=@NutricaoProduto, PrecoProduto=@PrecoProduto, CategoriaID=@CategoriaID, EmpresaID=@EmpresaID, QuantidadePesquisa=@QuantidadePesquisa where ProID=@ProID";

            int qtdAtualizada = _connection.Execute(query, EditarProduto);

        }

        //apagar

        public void ApagarProduto(CategoriaProdutoView deleteProduto)
        {
            string query = "Delete from Produto where ProID=@ProID";

            int qtdAtualizada = _connection.Execute(query, deleteProduto);

        }

        public async Task atualizarqtdPesquisaProdutos(int[] idProdutos)
        {
            try
            {
                string sql = "update Produto set QuantidadePesquisa = @quantidade where ProID = @ProID";
                foreach (int id in idProdutos)
                {
                    var produto = (await this.getTodosProdutos()).FirstOrDefault(x => x.ProID == id);
                    if (produto != null) { 
                
                    
                        produto.QuantidadePesquisa++;
                    await _connection.ExecuteAsync(sql, new { quantidade = produto.QuantidadePesquisa, ProID = id});

                
                    }

                }
            }
            catch
            {
                throw new Exception("Erro ao atualizar dados do produto");
            }
        }
    }
}
