namespace azure_monitoring;

public static class EndHandler
{
    public const string Pattern = "/end";
    public const string Name = "End";

    public static readonly Delegate Handler = () =>
    {
        return "Ended";
    };
}