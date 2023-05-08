using CárdapioV3_Tunado.DAL;
using CárdapioV3_Tunado.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CárdapioV3_Tunado.Controllers
{
    public class CardapioController : Controller
    {
        ListCategoriaProduto cardapio2 = new ListCategoriaProduto();
        CardapioDAO cardapio = new CardapioDAO();
        EmpresaDAO empresa = new EmpresaDAO();
        public IActionResult Index()
        {
            
            return View();
        }

        
        public IActionResult Foda(int idEmpresa)
        {
            List<CategoriaProdutoView> lista = cardapio.getTodosProdutosbyEmpresa(idEmpresa);
            var t = cardapio.getFotosEmpresa(idEmpresa).First().FotoEmpresa;
            ViewBag.listaFotos = t;
            List<CategoriaProdutoView> listaCategoria = cardapio.getTodosCategorias();

            var emp = empresa.getTodasEmpresas().First(x => x.EmpresaID == lista.First().EmpresaID);
             
            lista = lista.Select(x =>
            {
                x.Telefone = emp.Telefone;
                return x;
            }).ToList();
            listaCategoria.Select(x =>
            {
                x.Telefone = emp.Telefone;
                return x;
            }).ToList();

            lista = lista.Select(x =>
            {
                x.Taxa = emp.taxaEmpresa;
                return x;
            }).ToList();
            listaCategoria.Select(x =>
            {
                x.Taxa = emp.taxaEmpresa;
                return x;
            }).ToList();

            var listas = new ListCategoriaProduto
            {
                Lista1 = lista,
                Lista2 = lista
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
