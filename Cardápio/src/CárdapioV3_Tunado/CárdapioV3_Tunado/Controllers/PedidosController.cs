using CárdapioV3_Tunado.DAL;
using CárdapioV3_Tunado.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CárdapioV3_Tunado.Controllers
{

    public class PedidosController : Controller
    {
        private readonly PedidosDAO _pedidosContext;
        private readonly ProdutoDAO _produtoContext;
        public PedidosController()
        {
            _pedidosContext = new PedidosDAO();
            _produtoContext = new ProdutoDAO();
        }
        [Authorize]
        public IActionResult Index()
        {
            ViewBag.TodosPedidos = _pedidosContext.getTodosPedidos(0, int.Parse(User.Identity!.Name!));
            ViewBag.PedidosUltimos7Dias = _pedidosContext.getTodosPedidos(7, int.Parse(User.Identity!.Name!));
            ViewBag.PedidosUltimos15Dias = _pedidosContext.getTodosPedidos(15, int.Parse(User.Identity!.Name!));
            ViewBag.PedidosUltimos30Dias = _pedidosContext.getTodosPedidos(30, int.Parse(User.Identity!.Name!));
            return View();
        }

        [HttpPost]
        [ActionName("CriarPedido")] 
        public IActionResult Create(string NomeCliente, string EnderecoCliente, string TelefoneCliente, string DataPedido, string TipoPagamento, int EmpresaID, int[] Produtos, int empresaids)
        {
            var pedido = new Pedidos();
            pedido.PedNomeCliente = NomeCliente;
            pedido.PedEnderecoCliente = EnderecoCliente;
            pedido.PedTelefoneCliente = TelefoneCliente;
            pedido.PedDataPedido = DateTime.Parse(DataPedido);
            pedido.TipoPagamento = TipoPagamento;
            pedido.EmpresaId = EmpresaID;

            var batata = _pedidosContext.insertNovoPedido(pedido);
            _produtoContext.atualizarqtdPesquisaProdutos(Produtos);
            var model = _pedidosContext.getTodosPedidos(0, empresaids).First(x => x.PedID == batata);
            return Json(new string[] { model.PedDataPedido.ToString("dd/MM/yyyy"), model.PedID.ToString() });
        }
    }
}
