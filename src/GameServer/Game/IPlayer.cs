namespace GameServer.Game;

public interface IPlayer : ICircleCollision
{
    public int PlayerId { get; }

    public float Health { get; }
    public float MaxHealth { get; }
    public float Enengy { get; }
    public float MaxEnergy { get; }

    public float BaseSpeed { get; }
    public float BaseSpeedMultipier { get; }

    public float CurrentSpeed { get; }
    public float CurrentSpeedMultipier { get; }

    public bool IsAccelerating { get; }
    public bool IsExhausted { get; }

    public float PickUpRadius { get; }
    public float SightRadius { get; }

    public Position<float> PlayerPostion { get; }
    public Position<float> MovingTo { get; }
    public Position<float> AimingAt { get; }

    public List<IItem> NearbyItems { get; }
    public List<Position<float>> PositionsOfNearbyPlayers { get;}

    public void MoveTo(Position<float> target);
    public void AimAt(Position<float> target);
    public void SetAcceleration(bool isAccelerating);

    public void AttackWithFist();
    public void AttackWithMainWeapon();

    public void PickUpItem(IItem item, int count);
    public void DropItem(IItem item, int count);
    public void UseItem(IItem item);

    public void TakeDamage(float damage);
}
