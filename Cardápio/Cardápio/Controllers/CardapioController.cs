using Cardápio.Context;
using Cardápio.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cardápio.Controllers
{
	public class CardapioController : Controller
	{
		private readonly AppDbContext _context;

		public CardapioController(AppDbContext context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			categoriaProduto novoproduto = new categoriaProduto { };

			//_context.produtos.Add(novoproduto);	
			//return View(_context.produtos.ToList());
			var data = _context.categoriaProduto.ToList();
			return View(data);
		}
	}
}
