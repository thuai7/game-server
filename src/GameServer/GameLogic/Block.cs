namespace GameServer.GameLogic;

public class Block : IBlock
{
    // TODO: Implement
    public bool IsWall { get; }
    public List<IItem> Items { get; }

    public Block(bool isWall)
    {
        IsWall = isWall;
        Items = new();
    }

    public void GenerateItems()
    {
        if (IsWall)
        {
            return;
        }

        // TODO: Generate items
        throw new NotImplementedException("GenerateItems() is not implemented.");
    }
}
