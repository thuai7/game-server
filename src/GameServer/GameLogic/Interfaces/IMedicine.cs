namespace GameServer.GameLogic;

public abstract class IMedicine
{
    // TODO: Define the interface

    // the weight of medicine
    public double weight;

    /// <summary>
    /// implement specific function, sunch as recover health or speed up
    /// </summary>
    public abstract void Function();
}
