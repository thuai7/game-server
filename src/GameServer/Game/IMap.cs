namespace GameServer.Game;

public interface IMap
{
    public float Width { get; }
    public float Height { get; }
    public List<IItem> ItemSource { get; }
    public List<IBarrier> BarrierSource { get; }

    public void GenerateItems();
    public void GenerateBarriers();
}
