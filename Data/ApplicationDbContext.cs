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
    public DbSet<gestao_pedidos.Models.Cliente> Cliente { get; set; } = default!;
    public DbSet<gestao_pedidos.Models.Produto> Produto { get; set; }
}
