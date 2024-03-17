namespace GameServer.GameLogic;


public class Bandage : IMedicine
{
    static IMedicine CreateFromItem(IItem item)
    {
        throw new NotImplementedException();
    }
}

public class Medicine : IMedicine
{
    public int Heal = 30;

    public Medicine()
    {
        // Do nothing
    }

    public void Use(IPlayer owner)
    {
        // TODO: Implement
        throw new NotImplementedException();
    }
}
