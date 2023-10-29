using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using gestao_pedidos.Models;

namespace gestao_pedidos.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<Cliente> Cliente { get; set; }
    public DbSet<Produto> Produto { get; set; }
    public DbSet<Pedido> Pedido { get; set; }   
}
