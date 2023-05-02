using CárdapioV3_Tunado.DAL;
using CárdapioV3_Tunado.Models;
using Microsoft.AspNetCore.Mvc;

namespace CárdapioV3_Tunado.Controllers
{
    public class ProdutoController : Controller
    {
        ProdutoDAO produto = new ProdutoDAO();
        public IActionResult Index()
        {
            ViewBag.listaProdutosController = produto.getTodosProdutos();
            return View();
        }

        //create
        [HttpGet]
        public IActionResult create()
        {
            return View();

        }

        [HttpPost]
        public IActionResult create(string NomeProduto, string ProdutoDescricao, string NutricaoProduto, double PrecoProduto, int CategoriaProduto)
        {
            CategoriaProdutoView NovoProduto = new CategoriaProdutoView();
            NovoProduto.NomeProduto = NomeProduto;
            NovoProduto.DescricaoProduto = ProdutoDescricao;
            NovoProduto.NutricaoProduto = NutricaoProduto;
            produto.InsertProduto(NovoProduto);
            return RedirectToAction("Index");

        }

        //atualizar

        [HttpGet]
        public IActionResult Atualizar(int id)
        {
            ViewBag.CategoriaAtualizar = produto.getTodosProdutos().Where(x => x.ProID == id).FirstOrDefault();
            return View();
        }

        [HttpPost]
        public IActionResult Atualizar(string NomeProduto, string DescricaoProduto, string NutricaoProduto, string codigo, double PrecoProduto, int CategoriaProduto)
        {

            CategoriaProdutoView AtualizarProduto = new CategoriaProdutoView();
            AtualizarProduto.ProID = Convert.ToInt32(codigo);
            AtualizarProduto.NomeProduto = NomeProduto;
            AtualizarProduto.DescricaoProduto = DescricaoProduto;
            AtualizarProduto.NutricaoProduto = NutricaoProduto;
            AtualizarProduto.PrecoProduto = PrecoProduto;
            AtualizarProduto.CategoriaProduto = CategoriaProduto;
            produto.UptdateProduto(AtualizarProduto);

            return RedirectToAction("Index");
        }

        //apagar
        [HttpGet]
        public IActionResult Apagar(string id)
        {

            CategoriaProdutoView apagarProduto = new CategoriaProdutoView();
            apagarProduto.ProID = Convert.ToInt32(id);
            produto.ApagarProduto(apagarProduto);

            return RedirectToAction("Index");
        }
    }
}
