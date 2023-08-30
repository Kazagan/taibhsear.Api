using Data.Mapping;
using Data.Seeding;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Data;

public class LootContext : DbContext
{
    public LootContext(DbContextOptions<LootContext> options) : base(options)
    {
        
    }

    public LootContext() : base()
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.MapCoin();
        modelBuilder.MapCoinResult();
        
        modelBuilder.SeedCoin();
        modelBuilder.SeedCoinResult();
        
    }
}