namespace GameServer.Game;

public interface IWeapon : IItem
{
    public float Damage { get; }
    public float Range { get; }
    public bool RequiresBullet { get; }

    public void Attack(IPlayer owner);
}
