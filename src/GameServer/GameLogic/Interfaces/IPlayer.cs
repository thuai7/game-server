namespace GameServer.GameLogic;

public interface IPlayer
{
    Position PlayerPosition { get; set; }

    // TODO: Define the interface
    void TakeDamage(int v);
}
