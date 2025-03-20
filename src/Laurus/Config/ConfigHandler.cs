using XRL.UI;

public static class ConfigHandler
{
    public static bool GLOBAL_LOGGING_ENABLED => GetBooleanOption("OptionLaurusCoreLoggingEnabled");
    public static bool GLOBAL_LOGGING_DEBUG_ENABLED => GetBooleanOption("OptionLaurusCoreLoggingDebugEnabled");

    private static bool GetBooleanOption(string optionKey) =>
        Options.GetOption(optionKey).EqualsNoCase("Yes");
}
