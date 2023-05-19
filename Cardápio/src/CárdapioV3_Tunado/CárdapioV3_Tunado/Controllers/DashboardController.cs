using CárdapioV3_Tunado.DAL;
using CárdapioV3_Tunado.Models.enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CárdapioV3_Tunado.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        private readonly PedidosDAO _pedidosContext;
        private readonly ProdutoDAO _produtoContext;
        private readonly CategoriaDAO _categoriaContext;

        public DashboardController()
        {
            _pedidosContext = new PedidosDAO();
            _produtoContext = new ProdutoDAO();
            _categoriaContext = new CategoriaDAO();
        }

        public IActionResult Index()
        {
            ViewBag.PedidosUltimos7Dias = _pedidosContext.getTodosPedidos(7, int.Parse(User.Identity!.Name!)).Count;
            ViewBag.PedidosUltimos15Dias = _pedidosContext.getTodosPedidos(15, int.Parse(User.Identity!.Name!)).Count;
            ViewBag.PedidosUltimos30Dias = _pedidosContext.getTodosPedidos(30, int.Parse(User.Identity!.Name!)).Count;
            ViewBag.QuantidadeProdutos = _produtoContext.getQtdProdutosbyEmpresa(int.Parse(User.Identity!.Name!));
            ViewBag.ProdutoMaisProcurado = _produtoContext.getMaisPedidos(int.Parse(User.Identity!.Name!)).FirstOrDefault();
            if (User.IsInRole(nameof(E_Perfil.MASTER)))
                ViewBag.QuantidadeCategorias = _categoriaContext.getTodasCategorias().Count;
            return View();
        }
    }
}
