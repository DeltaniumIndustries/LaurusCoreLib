using XRL.UI;

public static class ConfigHandler
{
    public static readonly bool GLOBAL_LOGGING_ENABLED = GetBooleanOption("OptionLaurusCoreLoggingEnabled");

    private static bool GetBooleanOption(string optionKey) =>
        Options.GetOption(optionKey).EqualsNoCase("Yes");
}
