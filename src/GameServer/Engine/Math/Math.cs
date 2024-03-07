using GameServer.Engine.Shapes;

namespace GameServer.Engine;

public class Math
{
    /// <summary>
    /// Calculate the distance between two points.
    /// </summary>
    /// <typeparam name="T">Type of number(int, float, etc.)</typeparam>
    /// <param name="point1"></param>
    /// <param name="point2"></param>
    /// <returns>The distance between two points.</returns>
    public static T Distance<T>(Point<T> point1, Point<T> point2)
    {
        dynamic? x1 = point1.X;
        dynamic? y1 = point1.Y;
        dynamic? x2 = point2.X;
        dynamic? y2 = point2.Y;
        try
        {
            return (T)Convert.ChangeType(System.Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2)), typeof(T));
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException(
                $"Cannot calculate distance between two points of type {typeof(T).Name}: {ex.Message}."
            );
        }

    }
}
