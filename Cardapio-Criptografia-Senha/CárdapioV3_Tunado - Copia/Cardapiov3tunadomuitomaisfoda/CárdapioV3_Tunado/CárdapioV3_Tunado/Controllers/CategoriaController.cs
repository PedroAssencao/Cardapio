using CárdapioV3_Tunado.DAL;
using CárdapioV3_Tunado.Models;
using Microsoft.AspNetCore.Mvc;

namespace CárdapioV3_Tunado.Controllers
{
    public class CategoriaController : Controller
    {
        CategoriaDAO categoria = new CategoriaDAO();
        CardapioDAO cardapio = new CardapioDAO();

        public IActionResult Index(int idEmpresa)
        {
            ViewBag.listaCategorias = cardapio.getTodosProdutosbyEmpresa(idEmpresa);
            return View();
        }

        //create
        [HttpGet]
        public IActionResult create()
        {
            return View();

        }

        [HttpPost]
        public IActionResult create(string NomeCategoria, string CategoriaDescricao, string Foto)
        {
            CategoriaProdutoView NovaCategoria = new CategoriaProdutoView();
            NovaCategoria.Nome = NomeCategoria;
            NovaCategoria.CategoriaDescricao = CategoriaDescricao;
            NovaCategoria.CategoriaFoto = Foto;
            categoria.InsertCategoria(NovaCategoria);
            return RedirectToAction("Index");

        }

        //atualizar

        [HttpGet]
        public IActionResult Atualizar(int id, int idEmpresa)
        {
            EmpresaDAO empresa = new EmpresaDAO();
            ViewBag.CategoriaAtualizar = categoria.getTodasCategorias().Where(x => x.CategoriaID == id).FirstOrDefault();
            ViewBag.listaIdEmpresa = empresa.getTodasEmpresas().FirstOrDefault(x => x.EmpresaID == idEmpresa);  
            return View();
        }

        [HttpPost]
        public IActionResult Atualizar(string NomeCategoria, string CategoriaDescricao, string CategoriaFoto, string codigo)
        {

            CategoriaProdutoView AtualizarCategoria = new CategoriaProdutoView();
            AtualizarCategoria.CategoriaID = Convert.ToInt32(codigo);
            AtualizarCategoria.Nome = NomeCategoria;
            AtualizarCategoria.CategoriaDescricao = CategoriaDescricao;
            AtualizarCategoria.CategoriaFoto = CategoriaFoto;
            categoria.UptdateCategoria(AtualizarCategoria);

            return RedirectToAction("Index");
        }

        //apagar
        [HttpGet]
        public IActionResult Apagar(string id)
        {

            CategoriaProdutoView apagarCategoria = new CategoriaProdutoView();
            apagarCategoria.CategoriaID = Convert.ToInt32(id);
            categoria.ApagarCategoria(apagarCategoria);

            return RedirectToAction("Index");
        }
    }
}
