using Microsoft.EntityFrameworkCore;
using BlazingPizza.Model;

namespace BlazingPizza.Data;

public class PizzaStoreContext : DbContext
{
    public PizzaStoreContext(DbContextOptions options)
        : base(options) { }

    public DbSet<PizzaSpecial> Specials { get; set; }
}
