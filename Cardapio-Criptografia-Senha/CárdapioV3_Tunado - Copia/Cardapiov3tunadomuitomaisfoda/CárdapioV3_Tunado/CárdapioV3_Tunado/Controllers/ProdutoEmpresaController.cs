using CárdapioV3_Tunado.DAL;
using CárdapioV3_Tunado.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CárdapioV3_Tunado.Controllers
{
    [Authorize]
    public class ProdutoEmpresaController : Controller
    {
        ProdutoEmpresaDAO empresa = new ProdutoEmpresaDAO();
        public IActionResult Index()
        {
            var idEmpresa = int.Parse(User.Identity!.Name);
            ViewBag.listaProdutosEmpresa = empresa.getTodosProdutosbyEmpresa(idEmpresa);

            return View();
        }

        [HttpGet]
        public IActionResult Apagar(string id)
        {

            ProdutoEmpresa apagarProduto = new ProdutoEmpresa();
            apagarProduto.ProdutoID = Convert.ToInt32(id);
            empresa.ApagarProduto(apagarProduto);

            return RedirectToAction("Index");
        }
    }
}
