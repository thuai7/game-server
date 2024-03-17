using System.Numerics;
using GameServer.Engine.Collision;

namespace GameServer.GameLogic;

public class Map : IMap
{
    public Vector<Vector<int> > mapChunk=new Vector<Vector<int> >();
    public Dictionary<Position, object> Supplies = new Dictionary<Position, object>();
    public SafeZone safeZone = new SafeZone();
    private readonly int codeBarrier = 1;

    public void GenerateSupplies()
    {
        // TODO: Implement
    }

    private void GenerateBarrier() => throw new NotImplementedException();

    public void GenerateMap()
    {
        GenerateSupplies();
        GenerateBarrier();
    }

    public void updateSupplies()
    {
        // TODO: Implement
    }

    public void updateSafeZone()
    {
        int times = 0; // The safe zone will be reduced in several times
        safeZone.SafeZoneUpdate(8 * times); // TODO: Implement
    }

    

    //计算两个Position是否连通（无掩体阻挡）（mapChunk[a][b]为1表示(a,b)格子有掩体）
    public bool IsConnected(Position a, Position b)
    {
        int stx= (int)a.x, sty= (int)a.y, edx= (int)b.x, edy= (int)b.y;
        for (int i = stx; i <= edx; i++)
        {
            for (int j = sty; j <= edy; j++)
            {
                if (mapChunk[i][j] == codeBarrier 
                && CollisionDetector.checkCross(a, b, i, j))
                {
                    return false;
                }
            }
        }
        return true;

    }


}

