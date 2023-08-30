using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Seeding;

public static class CoinSeeding
{
    public static void SeedCoin(this ModelBuilder builder)
    {
        builder.Entity<Coin>(entity =>
        {
            entity.HasData(Initial);
        });
    }

    private static IEnumerable<Coin> Initial => new List<Coin>()
    {
        new() { Id = 1, Name = "Iron" },
        new() { Id = 2, Name = "Half Copper" },
        new() { Id = 3, Name = "Copper" },
        new() { Id = 4, Name = "Nickel" },
        new() { Id = 5, Name = "Silver" },
        new() { Id = 6, Name = "Electrum" },
        new() { Id = 7, Name = "Gold" },
        new() { Id = 8, Name = "Platinum" },
    };
}