using Serilog;

public static class Logger
{
    public static void Init()
    {
        Log.Logger = new LoggerConfiguration()
            .WriteTo.File(
                "logs/log-.txt",
                rollingInterval: RollingInterval.Day,
                retainedFileCountLimit: 7 // giữ 7 ngày
            )
            .CreateLogger();
    }

    public static void Info(string message)
    {
        Log.Information("{Message}", message);
    }

    public static void Error(Exception ex)
    {
        Log.Error(ex, "Exception occurred");
    }

    public static void Error(string message)
    {
        Log.Error("{Message}", message);
    }
}