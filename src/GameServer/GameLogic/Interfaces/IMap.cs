namespace GameServer.GameLogic;

public interface IMap
{
    /// <summary>
    /// generate the supplies and their position
    /// </summary>
    public void GenerateSupplies();

    /// <summary>
    /// generate the barrier and supplies
    /// </summary>
    public void GenerateMap();

    /// <summary>
    /// update the supplies in map
    /// </summary>
    public void updateSupplies();

    /// <summary>
    /// update the safe zone
    /// </summary>
    public void updateSafeZone();
}
