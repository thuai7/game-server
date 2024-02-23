using GameServer.Message;

namespace GameServer.ServerForSdk;

public interface IServerForSdk
{
    public void Start();
    public void Stop();
    public void Send(IMessage Message);
}
