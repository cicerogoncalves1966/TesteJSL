using Microsoft.EntityFrameworkCore;

namespace TesteJSL.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<PedidoItens> PedidoItens { get; set; }
    }
}
