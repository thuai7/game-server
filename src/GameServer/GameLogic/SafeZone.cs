using System.Numerics;

namespace GameServer.GameLogic;
public class SafeZone : ISafeZone
{
    
    public Vector<int> safeChunk = new Vector<int>();

    public bool IsSafe(Position position)
    {
        // TODO: Implement
        return true;
    }

    public void SafeZoneUpdate(int numb)
    {
        // TODO: Implement
    }
}
