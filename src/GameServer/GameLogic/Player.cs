namespace GameServer.GameLogic;

public class Player : IPlayer
{
    // TODO: Implement
    public double Health;
    public double Speed;
    public Armor? PlayerArmor = null;
    public Position PlayerPosition = new Position();
    public IWeapon PlayerWeapon = new Fist();
}
