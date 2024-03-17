namespace GameServer.GameLogic;

public interface ISafeZone
{
    /// <summary>
    /// judge whether the position is safe
    /// </summary>
    /// <param name="position"></param>
    /// <returns></returns>
    public bool IsSafe(Position position);

    /// <summary>
    /// update the safe zone
    /// </summary>
    /// <param name="numb">the number of safe chunks</param>
    public void SafeZoneUpdate(int numb);
}
