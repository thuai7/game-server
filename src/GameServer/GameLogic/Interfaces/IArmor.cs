namespace GameServer.GameLogic;

public interface IArmor
{
    public enum Type
    {
        NO_ARMOR,
        PRIMARY_ARMOR,
        PREMIUM_ARMOR
    };
    /// <summary>
    /// return the type of the armor
    /// </summary>
    /// <returns></returns>
    public Type armorType();

    /// <summary>
    /// return current points of the armor
    /// </summary>
    /// <returns></returns>
    public int armorPoints();

    /// <summary>
    /// when the player was injured, call this function to change the points of the armor
    /// </summary>
    public void Injured();
}
