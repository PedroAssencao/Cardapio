using Cardápio.Context;
using Cardápio.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cardápio.Controllers
{
	public class LuluComidaCaseiraController : Controller
	{
		private readonly AppDbContext _context;
		public LuluComidaCaseiraController(AppDbContext context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			LuluComidaCaseiraModels novoproduto = new LuluComidaCaseiraModels { };

			_context.LuluComidaCaseira.Add(novoproduto);
			return View(_context.LuluComidaCaseira.ToList());
		}
		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		[ActionName("Create")]
		public IActionResult Create(LuluComidaCaseiraModels model)
		{
			if (ModelState.IsValid)
			{
				_context.LuluComidaCaseira.Add(model);
				_context.SaveChanges();
				return RedirectToAction(nameof(Index));
			}

			return View();
		}

		public IActionResult Editar(int id)
		{
			LuluComidaCaseiraModels lulu = _context.LuluComidaCaseira.Find(id);
			return View(lulu);
		}





		[HttpGet]
		public IActionResult CreateLogin()
		{ 
			return View();
		}

		[HttpPost]
		[ActionName("Create")]
		public IActionResult CreateLogin(EstabelecimentoModels model)
		{
			if (ModelState.IsValid)
			{
		        if (model.verificaSenha())
		        {
				_context.estabelecimento.Add(model);
				_context.SaveChanges();
				return RedirectToAction(nameof(Index));

		        }

			}
			return View(model);

		}

		public IActionResult Login()
		{
			return View();
		}
	}
}
