using Serilog;

namespace GameServer;

class Program
{
    // https://github.com/THUASTA/EDCHost/blob/main/src/EdcHost/Program.cs
    const string SerilogTemplate = "[{@t:HH:mm:ss} {@l:u3}] {#if Component is not null}{Component,-13} {#end}{@m}\n{@x}";

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
