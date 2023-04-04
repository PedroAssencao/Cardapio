using Cardápio.Models;
using Microsoft.EntityFrameworkCore;

namespace Cardápio.Context
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

		public DbSet<EstabelecimentoModels> estabelecimento { get; set; }
		public DbSet<categoriaProduto> categoriaProduto { get; set; }
		public DbSet<LuluComidaCaseiraModels> LuluComidaCaseira { get; set; }
	}
}
