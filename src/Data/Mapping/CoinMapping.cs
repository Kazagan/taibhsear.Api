using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Mapping;

public static class CoinMapping
{
    public static void MapCoin(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Coin>(entity =>
        {
            entity.HasKey(e => e.Id);
            
            entity.Property(e => e.Name)
                .IsRequired()
                .VarcharWithMaxLength(50);
        });
    }
}