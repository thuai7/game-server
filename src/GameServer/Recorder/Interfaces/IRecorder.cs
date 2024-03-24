using GameServer.GameLogic;
using Microsoft.Data.Sqlite;

namespace GameServer.Recorder;

public interface IRecorder
{
    public SqliteConnection? SqliteDB { get; }

    public void CreateNewRecord(string recordName);
    public void RecordInitialInformation(IGame game);
    public void RecordEvents(EventArgs e);
}
