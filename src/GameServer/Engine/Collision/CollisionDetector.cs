using GameServer.Engine.Shapes;

namespace GameServer.Engine.Collision;

public class CollisionDetector
{
    /// <summary>
    /// Check if a circle is colliding with a segment.
    /// </summary>
    /// <typeparam name="T">Type of number(int, float, etc.)</typeparam>
    /// <param name="circle"></param>
    /// <param name="segment"></param>
    /// <returns>True if is colliding. False otherwise.</returns>
    public static bool IsColliding<T>(Circle<T> circle, Segment<T> segment)
    {
        // TODO: Implement
        throw new NotImplementedException();
    }

    /// <summary>
    /// Check if two circles are colliding.
    /// </summary>
    /// <typeparam name="T">Type of number(int, float, etc.)</typeparam>
    /// <param name="circle1"></param>
    /// <param name="circle2"></param>
    /// <returns>True if colliding. False otherwise.</returns>
    public static bool IsColliding<T>(Circle<T> circle1, Circle<T> circle2)
    {
        // TODO: Implement
        throw new NotImplementedException();
    }
}
