using APICatalogo1.Models;
using Microsoft.EntityFrameworkCore;

namespace APICatalogo1.Context
{
    public class APICatalogoDBContext : DbContext
    {
        public APICatalogoDBContext(DbContextOptions<APICatalogoDBContext> options) : base(options)
        {

        }

        public DbSet<Categoria>? Categorias {get; set;}
        public DbSet<Produto>? Produtos {get; set;}
    }
}
