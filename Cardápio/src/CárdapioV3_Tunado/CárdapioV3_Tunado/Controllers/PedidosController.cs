using CárdapioV3_Tunado.DAL;
using CárdapioV3_Tunado.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CárdapioV3_Tunado.Controllers
{
    public class PedidosNoGeral
    {
        public IEnumerable<Pedidos> Ultimos7Dias { get; set; }
        public IEnumerable<Pedidos> Ultimos15Dias { get; set; }
        public IEnumerable<Pedidos> Ultimos30Dias { get; set; }
    }

    [Authorize]
    public class PedidosController : Controller
    {
        private readonly PedidosDAO _pedidosContext;

        public PedidosController()
        {
            _pedidosContext = new PedidosDAO();
        }

        public IActionResult Index()
        {
            ViewBag.Pedidos = new PedidosNoGeral
            {
                Ultimos7Dias = _pedidosContext.getTodosPedidos(7, int.Parse(User.Identity!.Name!)),
                Ultimos15Dias = _pedidosContext.getTodosPedidos(15, int.Parse(User.Identity!.Name!)),
                Ultimos30Dias = _pedidosContext.getTodosPedidos(30, int.Parse(User.Identity!.Name!)),
            };
            return View();
        }
    }
}
