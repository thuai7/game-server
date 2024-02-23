namespace GameServer.Game;

public interface IFlyingBullet : ICircleCollision
{
    public float Speed { get; }
    public float Damage { get; }
    public float MaxDistance { get; }
    public float CurrentDistance { get; }
    public Position<float> CurrentPosition { get; }
    public float Direction { get; }
}
