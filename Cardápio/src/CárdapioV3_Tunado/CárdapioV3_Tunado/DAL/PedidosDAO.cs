using CárdapioV3_Tunado.Models;
using Dapper;
using MySql.Data.MySqlClient;

namespace CárdapioV3_Tunado.DAL
{
    public class PedidosDAO
    {

        MySqlConnection _connection;

        public PedidosDAO()
        {
            _connection = ConexaoBD.getConexao();
        }
        public List<Pedidos> getTodosPedidos(int qtdDias, int empresaId)
        {
            var sql = $"Select * from Pedidos where PedDataPedido >= Date_Sub(Curdate(), Interval {qtdDias} DAY) and EmpresaId = {empresaId}";
            List<Pedidos> dados = (List<Pedidos>)_connection.Query<Pedidos>(sql);
            return dados;
        }

        public void insertNovoPedido(Pedidos novoPedido)
        {
            var sql = "insert Pedidos (PedNomeCliente, PedEnderecoCliente, PedTelefoneCliente, PedDataPedido, EmpresaId, QuantidadePesquisa) values (@PedNomeCliente, @PedEnderecoCliente, @PedTelefoneCliente, @PedDataPedido, @EmpresaId, @QuantidadePesquisa)";

            var dados = _connection.Execute(sql, novoPedido);
        }

        public int qtdPedidosbyEmpresa(int idEmpresa)
        {
            var sql = $"select Count(*) from Pedidos where EmpresaId={idEmpresa}";

            int dados = _connection.QueryFirst<int>(sql);

            return dados;
        }
    }
}
