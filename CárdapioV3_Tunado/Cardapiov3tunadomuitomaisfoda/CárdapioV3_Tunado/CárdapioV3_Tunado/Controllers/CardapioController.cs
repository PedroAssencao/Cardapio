using CárdapioV3_Tunado.DAL;
using CárdapioV3_Tunado.Models;
using Microsoft.AspNetCore.Mvc;

namespace CárdapioV3_Tunado.Controllers
{
    public class CardapioController : Controller
    {
        ListCategoriaProduto cardapio2 = new ListCategoriaProduto();
        CardapioDAO cardapio = new CardapioDAO();
        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult Foda()
        {
            List<CategoriaProdutoView> lista = cardapio.getTodosProdutos();
            List<CategoriaProdutoView> listaCategoria = cardapio.getTodosCategorias();
            var listas = new ListCategoriaProduto
            {
                Lista1 = cardapio.getTodosCategorias(),
                Lista2 = cardapio.getTodosProdutos()
            };
            return View(listas);
        }





        //crud
        //create
        [HttpGet]
        public IActionResult create()
        {
            return View();

        }

        [HttpPost]
        public IActionResult create(string Nome, string Descricao, double preco, int Categoria)
        {
            CategoriaProdutoView NovoProduto = new CategoriaProdutoView();
            NovoProduto.DescricaoProduto = Descricao;
            NovoProduto.NomeProduto = Nome;
            NovoProduto.PrecoProduto = preco;
            NovoProduto.CategoriaProduto = Categoria;
            cardapio.InsertProdutos(NovoProduto);
            return RedirectToAction("Foda");

        }
        //atualizar

        [HttpGet]
        public IActionResult Atualizar(int id)
        {
            ViewBag.ProdutoAtualizar = cardapio.getTodosProdutos().Where(x => x.ProID == id).FirstOrDefault();
            return View();
        }

        [HttpPost]
        public IActionResult Atualizar(string codigo, string nome, string descricao, double preco, int CategoriaProduto)
        {

            CategoriaProdutoView AtualizarProduto = new CategoriaProdutoView();
            AtualizarProduto.ProID = Convert.ToInt32(codigo);
            AtualizarProduto.NomeProduto = nome;
            AtualizarProduto.DescricaoProduto = descricao;            
            AtualizarProduto.PrecoProduto = preco;
            AtualizarProduto.CategoriaProduto = CategoriaProduto;
            cardapio.UptdateProdutos(AtualizarProduto);

            return RedirectToAction("Foda");
        }
        //apagar
        [HttpGet]
        public IActionResult Apagar(string id)
        {

            CategoriaProdutoView apagarproduto = new CategoriaProdutoView();
            apagarproduto.ProID = Convert.ToInt32(id);
            cardapio.ApagarProdutos(apagarproduto);

            return RedirectToAction("foda");
        }
    }
}
