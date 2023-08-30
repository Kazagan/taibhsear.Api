using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Mapping;

public static class CoinResultsMapping
{
    public static void MapCoinResult(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CoinResults>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Rolls);
            entity.Property(e => e.Sides);

            entity.HasOne(e => e.Coin)
                .WithMany()
                .HasForeignKey(e => e.CoinId);
        });
    }
}