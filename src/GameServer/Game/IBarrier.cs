namespace GameServer.Game;

public interface IBarrier
{
    public Position<float> Point1 { get; }
    public Position<float> Point2 { get; }
    public float Width { get; }
}
