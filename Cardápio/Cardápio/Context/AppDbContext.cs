using Cardápio.Models;
using Microsoft.EntityFrameworkCore;

namespace Cardápio.Context
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

		public DbSet<EstabelecimentoModels> estabelecimento { get; set; }
		public DbSet<ProdutosModel> produtos { get; set; }
	}
}
