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
        public List<Pedidos> getTodosPedidos(int qtdDias)
        {
            var sql = $"Select * from Pedidos where PedDataPedido >= Date_Sub(Curdate(), Interval + {qtdDias}";

            List<Pedidos> dados = (List<Pedidos>)_connection.Query<Pedidos>(sql);

            return dados;
        }
    }
}
