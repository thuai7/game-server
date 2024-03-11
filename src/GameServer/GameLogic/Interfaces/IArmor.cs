namespace GameServer.GameLogic;

public interface IArmor
{
    public int Health { get; }

    public int MaxHealth { get; }

    /// <summary>
    /// Deal some damage.
    /// </summary>
    /// <param name="Damage"></param>
    /// <returns>Damage dealt by player</returns>
    public int Hurt(int Damage);
}
