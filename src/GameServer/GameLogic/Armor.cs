namespace GameServer.GameLogic;

/// <summary>
/// Factory for creating armor from items.
/// </summary>
public class ArmorFactory
{
    public static IArmor CreateFromItem(IItem item)
    {
        if (item.Kind != IItem.ItemKind.Armor)
        {
            throw new ArgumentException($"Item kind {item.Kind} is not an armor.");
        }

        int maxHealth = item.ItemSpecificId switch
        {
            0 => 50,
            _ => throw new ArgumentException($"Item specific id {item.ItemSpecificId} is not valid for armor.")
        };
        return new Armor(maxHealth);
    }
}

/// <summary>
/// Armor can be worn by a player to protect them from damage.
/// </summary>
public class Armor : IArmor
{
    public int Health { get; private set; }
    public int MaxHealth { get; }

    public Armor(int maxHealth)
    {
        MaxHealth = maxHealth;
        Health = maxHealth;
    }

    public int Hurt(int Damage)
    {
        if (Health > Damage)
        {
            Health -= Damage;
            return 0;
        }
        else
        {
            Health = 0;
            return (Damage - Health);
        }
    }
}
