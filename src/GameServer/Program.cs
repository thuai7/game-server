using Serilog;

namespace GameServer;

class Program
{
    static void Main()
    {
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Information()
            .WriteTo.Console()
            .CreateLogger();

        Version version = typeof(Program).Assembly.GetName().Version ?? new Version(0, 0, 0, 0);
        Log.Information($"THUAI7 GameServer v{version.Major}.{version.Minor}.{version.Build}");
        Log.Information("Copyright (c) ");

        // TODO: Create and activate game server

        Task.Delay(-1).Wait();
    }
}
