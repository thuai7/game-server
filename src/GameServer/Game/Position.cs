namespace GameServer.Game;

public readonly struct Position<T>
{
    public T PositionX { get; }
    public T PositionY { get; }

    public Position(T positionX, T positionY)
    {
        PositionX = positionX;
        PositionY = positionY;
    }
}
