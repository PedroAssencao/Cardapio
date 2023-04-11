using CárdapioV3_Tunado.DAL;
using Microsoft.AspNetCore.Mvc;

namespace CárdapioV3_Tunado.Controllers
{
    public class CardapioController : Controller
    {
        public IActionResult Index()
        {
            CardapioDAO cardapio = new CardapioDAO();
            ViewBag.listaCardapio = cardapio.getTodasSobremesas();
            ViewBag.listaCategorias = cardapio.getTodasCategorias();
            return View();
        }
    }
}
