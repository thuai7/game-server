namespace GameServer.GameLogic;

public class Player : IPlayer
{
    // TODO: Implement
    public double health;
    public double speed;
    public Armor playerArmor = new Armor();
    public Position playerPosition = new Position();
    public IWeapon playerWeapon = new Fist();
    public BackPack playerBackpack = new BackPack();
}
