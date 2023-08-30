using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Data;

public class LootContextFactory : IDesignTimeDbContextFactory<LootContext>
{

    public LootContext CreateDbContext(string[] args)
    {
        var options = new DbContextOptionsBuilder<LootContext>();
        
        options.UseNpgsql("Host=db;Username=lootManager;Password=Password#123;Database=lootManager_db");

        return new LootContext(options.Options);
    }
}