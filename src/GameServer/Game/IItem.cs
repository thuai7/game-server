namespace GameServer.Game;

public interface IItem
{
    enum ItemId
    {
        // TODO: Add item ids
    }

    public ItemId Id { get; }

    public int Count { get; }
    public float Weight { get; }
    public Position<float> Position { get; }
    public bool CanPile { get; }

    public void PileWith(IItem another);
}
