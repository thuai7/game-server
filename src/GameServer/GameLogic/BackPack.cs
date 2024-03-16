using System.Numerics;
using System.Runtime.InteropServices;

namespace GameServer.GameLogic;

public class BackPack : IBackPack
{
    private readonly Dictionary<object,int>? _backpack;// TODO: Implement

    public double capacity;
    public double totalCapacity()
    {
        return 0;// TODO: Implement
    }

    public double usedCapacity()
    {
        return 0;// TODO: Implement
    }

    public int supplyNumb(object supply)
    {
        return _backpack[supply];// TODO: Implement
    }

    public bool addSupplies(object supply, int numb)
    {
        _backpack.Add(supply, numb);
        return true;// TODO: Implement
    }

    public bool removeSupplies(object supply, double numb)
    {
        _backpack.Remove(supply);
        return true;// TODO: Implement
    }
}
