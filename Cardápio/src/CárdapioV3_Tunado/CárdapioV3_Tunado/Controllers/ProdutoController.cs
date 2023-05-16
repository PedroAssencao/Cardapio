using CárdapioV3_Tunado.DAL;
using CárdapioV3_Tunado.Models;
using CárdapioV3_Tunado.Models.enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CárdapioV3_Tunado.Controllers
{
    [Authorize]
    public class ProdutoController : Controller
    {
        CardapioDAO cardapio = new CardapioDAO();
        ProdutoDAO produto = new ProdutoDAO();
        CategoriaDAO categoria = new CategoriaDAO();
        public IActionResult Index(int idEmpresa = 0)
        {
            if (idEmpresa == 0)
                idEmpresa = int.Parse(User.Identity!.Name!);
            ViewBag.listaProdutosController = cardapio.getTodosProdutosbyEmpresa(idEmpresa);
            return View();
        }

        //create
        [HttpGet]
        public IActionResult create(int idEmpresa)
        {
            CategoriaDAO cardapio = new CategoriaDAO();
            idEmpresa = int.Parse(User.Identity!.Name!);
            ViewBag.listaCategorias = cardapio.getTodasCategorias();
            return View();

        }

        [HttpPost]
        public IActionResult create(string NomeProduto, string ProdutoDescricao, string NutricaoProduto, double PrecoProduto, int Categorias)
        {
            int idEmpresa = int.Parse(User.Identity!.Name!);
            CategoriaProdutoView NovoProduto = new CategoriaProdutoView();
            NovoProduto.NomeProduto = NomeProduto;
            NovoProduto.DescricaoProduto = ProdutoDescricao;
            NovoProduto.NutricaoProduto = NutricaoProduto;
            NovoProduto.PrecoProduto = PrecoProduto;
            NovoProduto.CategoriaID = Categorias;
            NovoProduto.EmpresaID = idEmpresa;
            produto.InsertProduto(NovoProduto);
            //int ID = produto.ProdutoIDRetornar();
            //var CookieOptions = new CookieOptions
            //{
            //    Expires = DateTime.Now.AddSeconds(50)
            //};
            //Response.Cookies.Append("IDProduto", ID.ToString(), CookieOptions);
            return RedirectToAction("Index");

        }

        //atualizar

        [HttpGet]
        public IActionResult Atualizar(int id)
        {
            CategoriaDAO categoria = new CategoriaDAO();
            ViewBag.ProdutoAtualizar = produto.getTodosProdutos().FirstOrDefault(x => x.ProID == id);
            ViewBag.Categoria = categoria.getTodasCategorias();
            return View();
        }

        [HttpPost]
        public IActionResult Atualizar(string NomeProduto, string DescricaoProduto, string NutricaoProduto, string codigo, double PrecoProduto, int CategoriaID, int EmpresaID)
        {
            EmpresaID = int.Parse(User.Identity!.Name!);
            CategoriaProdutoView AtualizarProduto = new CategoriaProdutoView();
            AtualizarProduto.ProID = Convert.ToInt32(codigo);
            AtualizarProduto.NomeProduto = NomeProduto;
            AtualizarProduto.DescricaoProduto = DescricaoProduto;
            AtualizarProduto.NutricaoProduto = NutricaoProduto;
            AtualizarProduto.PrecoProduto = PrecoProduto;
            AtualizarProduto.CategoriaID = CategoriaID;
            AtualizarProduto.EmpresaID = EmpresaID;
            produto.UptdateProduto(AtualizarProduto);

            return RedirectToAction("Index");
        }

        //apagar
        [HttpGet]
        public IActionResult Apagar(int id)
        {
            try
            {
                CategoriaProdutoView apagarProduto = new CategoriaProdutoView();
                apagarProduto.ProID = id;


                if (categoria.getTodasCategorias().Any(x => x.CategoriaID == produto.getTodosProdutos().FirstOrDefault(x => x.ProID == id)?.CategoriaID))
                    throw new Exception();

                produto.ApagarProduto(apagarProduto);

                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return Json("Você não pode apagar um produto vinculado a uma categoria");
            }

        }
    }
}
