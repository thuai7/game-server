namespace GameServer.Recorder;

public interface IRecorder
{
    public void RecordInitialInformation();
    public void RecordEvents(EventArgs e);
}
