using System.Security.Cryptography;

namespace MonsterTradingCardsGame;

public interface ICard
{
    
    public string Name
    {
        get; set;
    }

    public int Damage
    {
        get;
    }

    public Element ElementType
    {
        get; set;
    }
    
    
}