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
        //TODO: implement
        throw new NotImplementedException();
    }
}
