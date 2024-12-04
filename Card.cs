namespace MonsterTradingCardsGame;

public class Card : ICard
{
    public string Name { get; set; }
    public int Damage { get; }
    public Element ElementType { get; set; }

    protected Card(string name, int damage,  Element elementType)
    {
        Name = name;
        Damage = damage;
        ElementType = elementType;
    }
    
}