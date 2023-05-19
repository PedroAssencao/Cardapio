using CárdapioV3_Tunado.DAL;
using CárdapioV3_Tunado.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CárdapioV3_Tunado.Controllers
{
    [Authorize(Roles = "MASTER")]
    public class CategoriaController : Controller
    {
        CategoriaDAO categoria = new CategoriaDAO();

        public IActionResult Index()
        {
            ViewBag.listaCategorias = categoria.getTodasCategorias();
            return View();
        }

        //create
        [HttpGet]
        public IActionResult create()
        {
            return View();

        }

        [HttpPost]
        public IActionResult create(string NomeCategoria, string CategoriaDescricao, IFormFile Foto)
        {
            CategoriaProdutoView NovaCategoria = new CategoriaProdutoView();
            NovaCategoria.Nome = NomeCategoria;
            NovaCategoria.CategoriaDescricao = CategoriaDescricao;
            string path = $"wwwroot/Images/Categoria_{NovaCategoria.CategoriaID}";
            if (Foto is not null)
            {
                using var stream = new MemoryStream();
                Foto.CopyToAsync(stream);
                stream.Position = 0;
                using var fileStream = new FileStream($"{path}empresa_{NovaCategoria.CategoriaID}.png", FileMode.OpenOrCreate);
                stream.CopyTo(fileStream);
                fileStream.Close();
            }
            NovaCategoria.CategoriaFoto = $"{path}empresa_{NovaCategoria.CategoriaID}.png".Replace(@"wwwroot", string.Empty);

            categoria.InsertCategoria(NovaCategoria);
            return RedirectToAction("Index");

        }

        //atualizar

        [HttpGet]
        public IActionResult Atualizar(int id)
        {
            ViewBag.CategoriaAtualizar = categoria.getTodasCategorias().Where(x => x.CategoriaID == id).FirstOrDefault();
            return View();
        }

        [HttpPost]
        public IActionResult Atualizar(string NomeCategoria, string CategoriaDescricao, IFormFile CategoriaFoto, string codigo)
        {

            CategoriaProdutoView AtualizarCategoria = new CategoriaProdutoView();
            AtualizarCategoria.CategoriaID = Convert.ToInt32(codigo);
            AtualizarCategoria.Nome = NomeCategoria;
            AtualizarCategoria.CategoriaDescricao = CategoriaDescricao;

            string path = $"wwwroot/Images/Categoria_{AtualizarCategoria.CategoriaID}";
            if (CategoriaFoto is not null)
            {
                using var stream = new MemoryStream();
                CategoriaFoto.CopyToAsync(stream);
                stream.Position = 0;
                using var fileStream = new FileStream($"{path}empresa_{AtualizarCategoria.CategoriaID}.png", FileMode.OpenOrCreate);
                stream.CopyTo(fileStream);
            }
            AtualizarCategoria.CategoriaFoto = $"{path}empresa_{AtualizarCategoria.CategoriaID}.png".Replace(@"wwwroot", string.Empty);
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
