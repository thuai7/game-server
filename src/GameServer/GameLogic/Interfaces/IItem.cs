namespace GameServer.GameLogic;

public interface IItem
{
    public enum ItemKind
    {
        Medicine,
        Weapon,
        Bullet,
        Grenade,
        Armor
    }

    public ItemKind Kind { get; }
    public int ItemSpecificId { get; }
    public int Count { get; set; }
    public int WeightOfSingleItem { get; }
}
