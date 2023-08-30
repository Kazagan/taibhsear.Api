using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

public class CoinResults
{
    public int Id { get; set; }

    public int Level { get; set; }

    /// <summary>
    /// Number of rolls
    /// </summary>
    public int Rolls { get; set; }

    /// <summary>
    /// Dice sides, or max result 1-sides
    /// </summary>
    public int Sides { get; set; }

    public int Multiplier { get; set; }

    public int CoinId { get; set; }
    
    public Coin Coin { get; set; } = null!;
}