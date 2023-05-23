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
            var sql = qtdDias != 0
                ? $"Select * from Pedidos where PedDataPedido >= Date_Sub(Curdate(), Interval {qtdDias} DAY) and EmpresaId = {empresaId}"
                : $"Select * from Pedidos where EmpresaId = {empresaId}";
            List<Pedidos> dados = (List<Pedidos>)_connection.Query<Pedidos>(sql);
            return dados;
        }

      
        public int insertNovoPedido(Pedidos novoPedido)
        {
            var sql = "insert Pedidos (PedNomeCliente, PedEnderecoCliente, PedTelefoneCliente, PedDataPedido, TipoPagamento, EmpresaId) values (@PedNomeCliente, @PedEnderecoCliente, @PedTelefoneCliente, @PedDataPedido, @TipoPagamento, @EmpresaId); SELECT LAST_INSERT_ID();";

            return _connection.ExecuteScalar <int> (sql, novoPedido);


        }
    }
}
