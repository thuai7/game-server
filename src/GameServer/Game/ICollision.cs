namespace GameServer.Game;

public interface ICollision
{
    public bool IsCollidingWith(ICollision another);
}

public interface ICircleCollision : ICollision
{
    public float Radius { get; }
}

public interface ISegmentCollision : ICollision
{
    public Position<float> Point1 { get; }
    public Position<float> Point2 { get; }
}

public interface ICollisionDetector
{
    public bool IsColliding(ICollision a, ICollision b);
}
