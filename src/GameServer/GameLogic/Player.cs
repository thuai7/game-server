using static GameServer.GameLogic.IItem;

namespace GameServer.GameLogic;

public class Player : IPlayer
{
    // TODO: Implement
    public int Health;
    public double Speed;
    public Armor? PlayerArmor = null;
    public Position PlayerPosition { get; set; }
    public IWeapon PlayerWeapon = new Fist();
    public IBackPack PlayerBackPack => throw new NotImplementedException();

    //生成构造函数
    public Player(int health, double speed, Position position)
    {
        Health = health;
        Speed = speed;
        PlayerPosition = position;
    }


    public void TakeDamage(int damage)
    {
        if (PlayerArmor != null)
        {
            Health -= PlayerArmor.Hurt(damage);
        }
        else Health -= damage;
        
    }

    public void playerMove(Position position)
    {
        PlayerPosition = position;
    }

    public bool playerAttack()
    {
        if (PlayerBackPack.FindItems(ItemKind.Bullet,1)> 0)
        {
            PlayerBackPack.RemoveItems(ItemKind.Bullet, 1,1);
            return true;
        }
        else return false;
    }

    public bool playerUseGrenade()
    {
        if (PlayerBackPack.FindItems(ItemKind.Grenade, 1) > 0)
        {
            PlayerBackPack.RemoveItems(ItemKind.Grenade, 1, 1);
            return true;
        }
        else return false;
    }

    public bool playerUseMedicine()
    {
        if (PlayerBackPack.FindItems(ItemKind.Medicine, 1) > 0)
        {
            PlayerBackPack.RemoveItems(ItemKind.Medicine, 1, 1);

            //Health += Medicine.Heal;

            return true;
        }
        else return false;
    }

    public bool playerChangeWeapon()
    {
        // TODO:Implement
        throw new NotImplementedException();
    }
}
