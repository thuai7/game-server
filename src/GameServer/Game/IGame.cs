namespace GameServer.Game;

/// <summary>
/// Interface for games.
/// Battles run on a game.
/// </summary>
public interface IGame
{
    enum GameStatus
    {
        NotStarted = 0,
        Running,
        Ended
    }
    public const int TicksPerSecond = 20;
    public GameStatus Status { get; }
    public int ElapsedTicks { get; }
    public IMap GameMap { get; }
    public IDangerZone DangerZone { get; }
    public List<IPlayer> Players { get; }

    public void Start();
    public void End();
    public void Reset();
    public void Tick();
}
