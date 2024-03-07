using GameServer.Engine.Shapes;

namespace GameServer.Engine.Collision;

public class CollisionDetector
{
    /// <summary>
    /// Check whether a circle is colliding with a segment.
    /// </summary>
    /// <typeparam name="T">Type of number(int, float, etc.)</typeparam>
    /// <param name="circle"></param>
    /// <param name="segment"></param>
    /// <returns>True whether is colliding. False otherwise.</returns>
    public static bool IsColliding<T>(Circle<T> circle, Segment<T> segment)
    {
        // TODO: Implement
        throw new NotImplementedException();
    }

    /// <summary>
    /// Check whether two circles are colliding.
    /// </summary>
    /// <typeparam name="T">Type of number(int, float, etc.)</typeparam>
    /// <param name="circle1"></param>
    /// <param name="circle2"></param>
    /// <returns>True whether colliding. False otherwise.</returns>
    public static bool IsColliding<T>(Circle<T> circle1, Circle<T> circle2)
    {
        // TODO: Implement
        throw new NotImplementedException();
    }

    /// <summary>
    /// Check whether two segments are colliding.
    /// </summary>
    /// <typeparam name="T">Type of number(int, float, etc.)</typeparam>
    /// <param name="segment1"></param>
    /// <param name="segment2"></param>
    /// <returns>True whether colliding. False otherwise.</returns>
    /// <exception cref="NotImplementedException"></exception>
    public static bool IsColliding<T>(Segment<T> segment1, Segment<T> segment2)
    {
        // TODO: Implement
        throw new NotImplementedException();
    }

    /// <summary>
    /// Check whether a circle will collide with a segment when it moves from startingPoint to endingPoint.
    /// </summary>
    /// <typeparam name="T">Type of number(int, float, etc.)</typeparam>
    /// <param name="movingObject"></param>
    /// <param name="staticObject"></param>
    /// <param name="startingPoint"></param>
    /// <param name="endingPoint"></param>
    /// <returns></returns>
    public static bool WillCollide<T>(
        Circle<T> movingObject, Segment<T> staticObject, Point<T> startingPoint, Point<T> endingPoint)
    {
        // TODO: Implement
        throw new NotImplementedException();
    }

    /// <summary>
    /// Check where a circle will stop at with a segment existing
    /// when it moves from startingPoint to endingPoint.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="movingObject"></param>
    /// <param name="staticObject"></param>
    /// <param name="startingPoint"></param>
    /// <param name="endingPoint"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public static Point<T> StopAt<T>(
        Circle<T> movingObject, Segment<T> staticObject, Point<T> startingPoint, Point<T> endingPoint)
    {
        throw new NotImplementedException();
    }
}
