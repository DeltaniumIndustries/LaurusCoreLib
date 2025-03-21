using XRL.UI;

namespace LaurusCoreLib.Net.Laurus.Config
{
    public static class ConfigHandler
    {
        public static bool GLOBAL_LOGGING_ENABLED => Options.GetOptionBool("OptionLaurusCoreLoggingEnabled");
        public static bool GLOBAL_LOGGING_DEBUG_ENABLED => Options.GetOptionBool("OptionLaurusCoreLoggingDebugEnabled");

    }
}