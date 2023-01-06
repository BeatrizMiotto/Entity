using Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace entity.Database;

public class BaseContext: DbContext
{
    public BaseContext(DbContextOptions<BaseContext> options) : base(options) { }
    
    public DbSet<Cliente> Clientes { get; set; } = default!;
    public DbSet<Carro> Carros { get; set; } = default!;
    public DbSet<Pedido> Pedidos { get; set; } = default!;

} 