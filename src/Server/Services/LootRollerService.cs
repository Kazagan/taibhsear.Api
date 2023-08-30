using Server.Dto;

namespace Server.Services;

public class LootRollerService
{
    public Loot GetLoot(int level)
    {
        return new Loot()
        {
            Coins = new Coins()
            {
                Name = "Gold",
                Quantity = 50,
            }
        };
    }
}