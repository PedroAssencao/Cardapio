using CárdapioV3_Tunado.DAL;
using CárdapioV3_Tunado.Models;
using Microsoft.AspNetCore.Mvc;

namespace CárdapioV3_Tunado.Controllers
{
    public class CardapioController : Controller
    {
        CardapioDAO cardapio = new CardapioDAO();
        public IActionResult Index()
        {
            
            ViewBag.listaCardapio = cardapio.getTodosPetiscos();
            ViewBag.listaCategorias = cardapio.getTodasCategorias();
            ViewBag.listaBebidasAL = cardapio.getTodasBebidasAlcholicas();
            
            return View();
        }

        public IActionResult Foda()
        {
            List<Produto> lista = cardapio.getTodosProdutos();
            ViewBag.listaProdutos = cardapio.getTodosProdutos();
            return View(lista);
        }
    }
}
