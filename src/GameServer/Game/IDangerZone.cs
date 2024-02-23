namespace GameServer.Game;

public interface IDangerZone
{
    public int TicksUntilFull { get; }
    public Position<float> InitialCenter { get; }
    public Position<float> FinalCenter { get; }
    public float InitialRadius { get; }
    public float FinalRadius { get; }
    public float CurrentCenter { get; }
    public float CurrentRadius { get; }
}
