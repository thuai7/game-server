namespace GameServer.GameLogic;

public interface IBlock
{
    public bool IsWall { get; }
    public const float Width = 1;
    public const float Height = 1;
    public List<IItem> Items { get; }
    public void GenerateItems();
}
