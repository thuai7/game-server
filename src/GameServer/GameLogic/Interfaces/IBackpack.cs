using System.Numerics;

namespace GameServer.GameLogic;

public interface IBackPack
{
    /// <summary>
    /// return the total capacity of the backpack
    /// </summary>
    /// <returns></returns>
    public double totalCapacity();

    /// <summary>
    /// return the used capacity
    /// </summary>
    /// <returns></returns>
    public double usedCapacity();

    /// <summary>
    /// return the number of the supply
    /// </summary>
    /// <param name="supply"></param>
    /// <returns></returns>
    public int supplyNumb(object supply);


    /// <summary>
    /// add supplies, determine whether the capacity is exceeded
    /// </summary>
    /// <param name="supply"></param>
    /// <param name="numb"></param> the number of the suppply
    /// <returns></returns>
    public bool addSupplies(object supply, double numb);


    /// <summary>
    /// remove supplies, deter whether the operation succeeds
    /// </summary>
    /// <param name="supply"></param>
    /// <param name="numb"></param>
    /// <returns></returns>
    public bool removeSupplies(object supply,double numb);
}
