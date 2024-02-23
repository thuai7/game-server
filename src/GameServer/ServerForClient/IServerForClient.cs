using GameServer.Message;

namespace GameServer.ServerForClient;

public interface ServerForClient
{
    public void Start();
    public void Stop();
    public void Send(IMessage Message);
}
