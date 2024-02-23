namespace GameServer.Game;

public interface IBuff
{
    public int DurationTicks { get; }
    public int ElapsedTicks { get; }
    public int ActivationTickInterval { get; }
    public int LastActivatedTick { get; }

    public void Activate(IPlayer player);
}
