namespace azure_monitoring;

public static class StartHandler
{
    public const string Pattern = "/start";
    public const string Name = "Start";

    public static readonly Delegate Handler = () =>
    {
        return "Started";
    };
}