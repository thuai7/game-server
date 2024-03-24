namespace GameServer.GameLogic;

public class Player : IPlayer
{
    // TODO: Implement
    public int Health{ get; set;}
    public double Speed{ get; set;}
    public Armor? PlayerArmor { get; set; }
    public Position PlayerPosition { get; set; }
    public IWeapon PlayerWeapon { get; set; }
    public IBackPack PlayerBackPack { get; set; }

    //生成构造函数
    public Player(int health, double speed, Position position)
    {
        Health = health;
        Speed = speed;
        PlayerPosition = position;
        PlayerArmor = null;
        PlayerWeapon = new Fist();
        PlayerBackPack = new BackPack(Constant.PLAYER_INITIAL_BACKPACK_SIZE);
    }

    public void TakeDamage(int damage)
    {
        throw new NotImplementedException();
    }
    public void TakeHeal(int heal)
    {
        throw new NotImplementedException();
    }
    public void SwitchWeapon(int weaponItemId)
    {
        //iterate player's backpack to find the weapon with weaponItemId
        //if found, set PlayerWeapon to the weapon
        //if not found, throw new ArgumentException("Weapon not found in backpack.");
        foreach (IItem item in PlayerBackPack.Items)
        {
            if (item.ItemSpecificId == weaponItemId)
            {
                PlayerWeapon = WeaponFactory.CreateFromItem(item);   
                return;
            }
        }
    }
}
