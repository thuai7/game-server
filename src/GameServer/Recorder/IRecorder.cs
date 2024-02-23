using GameServer.Game;

namespace GameServer.Recorder;

/// <summary>
/// Interface for recorders.
/// Recorders can record a battle, which can be replayed by client.
/// </summary>
public interface IRecorder
{
    public string FileName { get; }

    public void RecordInitialGameState(IGame game);
    public void RecordEvents(object? sender, EventArgs e);
}
