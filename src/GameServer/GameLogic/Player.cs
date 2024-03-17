namespace GameServer.GameLogic;

public class Player : IPlayer
{
    // TODO: Implement
    public int Health;
    public double Speed;
    public Armor? PlayerArmor = null;
    public Position PlayerPosition = new Position();
    public IWeapon PlayerWeapon = new Fist();
    
    public void TakeDamage(int damage)
    {
        //TODO: implement
        //return not implemented error
        throw new NotImplementedException();
    }
}
