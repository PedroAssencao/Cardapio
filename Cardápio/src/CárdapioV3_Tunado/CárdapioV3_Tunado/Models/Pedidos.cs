namespace CárdapioV3_Tunado.Models
{
    public class Pedidos
    {
        public int PedID { get; set; }
        public string PedNomeCliente { get; set; }
        public string PedEnderecoCliente { get; set; }
        public string PedTelefoneCliente { get; set; }
        public DateTime PedDataPedido { get; set; }
        public string TipoPagamento { get; set; }
        public int EmpresaId { get; set; }
    }
}
