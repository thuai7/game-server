namespace GameServer.Game;

public interface IHandGrenade
{
    public float Damage { get; }
    public float Range { get; }
    public float ExplosionRadius { get; }
    public int CountdownTicks { get; }
    public void Explode();
}
