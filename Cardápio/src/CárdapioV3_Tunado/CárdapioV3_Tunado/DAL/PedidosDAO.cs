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
        public async Task <List<Pedidos>> getTodosPedidos(int qtdDias, int empresaId)
        {
            var sql = qtdDias != 0
                ? $"Select * from Pedidos where PedDataPedido >= Date_Sub(Curdate(), Interval {qtdDias} DAY) and EmpresaId = {empresaId}"
                : $"Select * from Pedidos where EmpresaId = {empresaId}";
            List<Pedidos> dados = (List<Pedidos>) await _connection.QueryAsync<Pedidos>(sql);
            return dados;
        }

      
        public async Task<int> insertNovoPedido(Pedidos novoPedido)
        {
            var sql = "insert Pedidos (PedNomeCliente, PedEnderecoCliente, PedTelefoneCliente, PedDataPedido, TipoPagamento, EmpresaId) values (@PedNomeCliente, @PedEnderecoCliente, @PedTelefoneCliente, @PedDataPedido, @TipoPagamento, @EmpresaId); SELECT LAST_INSERT_ID();";

            return await _connection.ExecuteScalarAsync <int> (sql, novoPedido);
            throw new Exception("Erro ao inserir pedido");
        }
    }
}
