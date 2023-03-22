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
			ProdutosModel novoproduto = new ProdutosModel {  };
			
			_context.produtos.Add(novoproduto);	
			return View(_context.produtos.ToList());
		}
	}
}
