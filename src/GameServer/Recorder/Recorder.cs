using GameServer.GameLogic;
using LevelDB;

namespace GameServer.Recorder;

public class Recorder : IRecorder
{
    public DB? LevelDB { get; } = null;

    public void CreateNewRecord(string recordName)
    {
        throw new NotImplementedException();
    }
    public void RecordInitialInformation(IGame game)
    {
        throw new NotImplementedException();
    }

    public void RecordEvents(EventArgs e)
    {
        throw new NotImplementedException();
    }
}
