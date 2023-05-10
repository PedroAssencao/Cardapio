using CárdapioV3_Tunado.DAL;
using CárdapioV3_Tunado.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text;

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
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(bool continuar = true)
        {
            if (continuar == true)
            {
                var idEmpresa = int.Parse(User.Identity!.Name);
                var CategoriaID = int.Parse(Request.Cookies["ID"]);
                var ProdutoID = int.Parse(Request.Cookies["IDProduto"]);
                ProdutoEmpresa novoProdutoEmpresa = new ProdutoEmpresa();
                novoProdutoEmpresa.EmpresaID = idEmpresa;
                novoProdutoEmpresa.ProdutoID = ProdutoID;
                novoProdutoEmpresa.CategoriaID = CategoriaID;
                empresa.InsertProdutoEmpresa(novoProdutoEmpresa);

                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult ApagarProduto(string id)
        {

            ProdutoEmpresa apagarProduto = new ProdutoEmpresa();
            apagarProduto.ProdutoID = Convert.ToInt32(id);
            empresa.ApagarProduto(apagarProduto);

            return RedirectToAction("Index");
        }

        public IActionResult ApagarCategoria(string id)
        {

            ProdutoEmpresa apagarCategoria = new ProdutoEmpresa();
            apagarCategoria.CategoriaID = Convert.ToInt32(id);
            empresa.ApagarCategoria(apagarCategoria);

            return RedirectToAction("Index");
        }
    }
}
