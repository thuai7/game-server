using System.Numerics;

namespace GameServer.GameLogic;

public class Map : IMap
{
    
    public Vector<int> mapChunk = new Vector<int>();

    public Dictionary<Position, object> Supplies = new Dictionary<Position, object>();

    public Barrier barrier = new Barrier();

    public SafeZone safeZone = new SafeZone();

    public void GenerateSupplies()
    {
        // TODO: Implement
    }

    public void GenerateMap()
    {
        GenerateSupplies();
        barrier.GenerateBarrier();// TODO: Implement
    }

    public void updateSupplies()
    {
        // TODO: Implement
    }

    public void updateSafeZone()
    {
        int times = 0;  //the safe zone will be ruduced in several times
        safeZone.SafeZoneUpdate(8*times);// TODO: Implement
    }
}
