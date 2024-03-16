using System.Numerics;

namespace GameServer.GameLogic;
public class SafeZone : ISafeZone
{
    
    public Vector<int> safeChunk = new Vector<int>();

    public bool IsSafe(Position position)
    {
        return true; // TODO: Implement
    }

    public void SafeZoneUpdate(int numb)
    {
        // TODO: Implement
    }
}
