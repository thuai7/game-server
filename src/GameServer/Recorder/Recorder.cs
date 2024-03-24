using GameServer.GameLogic;
using LevelDB;
using Microsoft.Data.Sqlite;

namespace GameServer.Recorder;

public class Recorder : IRecorder
{
    public SqliteConnection? SqliteDB { get; private set; } = null;

    public void CreateNewRecord(string recordName)
    {
        SqliteDB?.Close();
        var options = new Options { CreateIfMissing = true };
        SqliteDB = new SqliteConnection("Data Source=Recorder.db;Version=3;");
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
