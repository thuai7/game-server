using GameServer.Message;

namespace GameServer.ServerForAgent;

public interface IServerForAgent
{
    public void Start();
    public void Stop();
    public void Send(IMessage Message);
}
