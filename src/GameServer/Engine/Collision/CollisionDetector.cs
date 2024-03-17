using GameServer.Engine.Shapes;
using GameServer.GameLogic;

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

    public static double CrossProduct(Position a, Position b, Position c)
    {
        return (b.x - a.x) * (c.y - a.y) - (c.x - a.x) * (b.y - a.y);
    }

    public static bool AreOnSameSide(Position a, Position b, Position[] positions)
    {
        double abCrossProduct = CrossProduct(a, b, positions[0]);
        for (int i = 1; i < positions.Length; i++)
        {
            double currentCrossProduct = CrossProduct(a, b, positions[i]);
            if (currentCrossProduct*abCrossProduct<0)
            {
                return false; // Points are not on the same side
            }
        }
        return true; // All points are on the same side
    }

    public static bool checkCross(Position a, Position b, int i, int j)
    {
        Position[] positions = new Position[] { new Position(i, j), new Position(i, j + 1), new Position(i + 1, j), new Position(i + 1, j + 1) };
        if(!AreOnSameSide(a, b, positions))
        {
            return false;
        }
        return true;
    }
}
