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
        EmpresaDAO empresa = new EmpresaDAO();

        [Authorize]
        public IActionResult Index(int? EmpresaID)
        {
            if (User.IsInRole(nameof(E_Perfil.MASTER)) && EmpresaID != null)
            {
                ViewBag.listaProdutosController = cardapio.getTodosProdutosbyEmpresa(Convert.ToInt32(EmpresaID));
                ViewBag.NomeEmpresa = empresa.getTodasEmpresasbyID(Convert.ToInt32(EmpresaID));
                ViewBag.TodasEmpresasBox = empresa.getTodasEmpresas();
                ViewBag.EmpresaIDSubmit = EmpresaID;
                return View();
            }
            else
            {
                if (User.Identity!.Name is null) return RedirectToAction("/empresa/logar");
                var idEmpresa = int.Parse(User.Identity!.Name);
                ViewBag.listaProdutosController = cardapio.getTodosProdutosbyEmpresa(idEmpresa);
                ViewBag.todosProdutos = produto.SepararProdutos();
                ViewBag.NomeEmpresa = empresa.getTodasEmpresasbyID(idEmpresa);
                ViewBag.TodasEmpresasBox = empresa.getTodasEmpresas();
                return View();
            }
        }

        //create
        [HttpGet]
        [Authorize]
        public IActionResult create(int idEmpresa)
        {
            if (User.Identity!.Name is null) return RedirectToAction("/empresa/logar");
            CategoriaDAO cardapio = new CategoriaDAO();
            idEmpresa = int.Parse(User.Identity!.Name);
            ViewBag.listaCategorias = cardapio.getTodasCategorias();
            return View();

        }

        [HttpPost]
        [Authorize]
        public IActionResult create(string NomeProduto, string ProdutoDescricao, string NutricaoProduto, double PrecoProduto, int Categorias)
        {
            if (User.Identity!.Name is null) return RedirectToAction("/empresa/logar");
            int idEmpresa = int.Parse(User.Identity!.Name);
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
        public async Task <IActionResult> Atualizar(int id)
        {
            CategoriaDAO categoria = new CategoriaDAO();
            ViewBag.ProdutoAtualizar = (await produto.getTodosProdutos()).FirstOrDefault(x => x.ProID == id);
            ViewBag.Categoria = categoria.getTodasCategorias();
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult Atualizar(string NomeProduto, string DescricaoProduto, string NutricaoProduto, string codigo, double PrecoProduto, int CategoriaID, int EmpresaID)
        {
            if (User.Identity!.Name is null) return RedirectToAction("/empresa/logar");
            EmpresaID = int.Parse(User.Identity!.Name);
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
        public IActionResult Apagar(string id)
        {

            CategoriaProdutoView apagarProduto = new CategoriaProdutoView();
            apagarProduto.ProID = Convert.ToInt32(id);
            produto.ApagarProduto(apagarProduto);

            return RedirectToAction("Index");
        }
    }
}
