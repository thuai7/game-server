namespace GameServer.GameLogic;

public abstract class IMedicine
{
    // TODO: Define the interface
    public double weight;

    public void setWeight(double w)
    {
        weight = w;
    }
    /// <summary>
    /// implement specific function, sunch as recover health or speed up
    /// </summary>
    public abstract void Function();
}
