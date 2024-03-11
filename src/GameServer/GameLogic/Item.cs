namespace GameServer.GameLogic;

public class Item : IItem
{
    public IItem.ItemKind Kind { get; }
    public int ItemSpecificId { get; }
    public int Count { get; set; }
    public int WeightOfSingleItem
    {
        get => Kind switch
        {
            _ => throw new NotImplementedException()
        };
    }

    public Item(IItem.ItemKind kind, int itemSpecificId, int count)
    {
        Kind = kind;
        ItemSpecificId = itemSpecificId;
        Count = count;
    }
}
