using ComercioBom.Models;
using Microsoft.EntityFrameworkCore;

namespace ComercioBom.Context
{
    public class ApplicationDbContext : DbContext
    {        
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<Item> Itens { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ) : base (options)
        {
            
        }

    }
}