using System.Collections.Generic;
using LaurusCoreLib.Net.Laurus.Logging;
using LaurusCoreLib.Net.Laurus.Util;
using XRL;

namespace LaurusCoreLib.Net.Laurus.Startup
{

    [HasModSensitiveStaticCache]
    public static class LaurusCoreSetup
    {
        [ModSensitiveStaticCache]
        public static int Counter;

        [ModSensitiveStaticCache(true)]
        public static List<string> Colors = new();

        [ModSensitiveCacheInit]
        public static void MyModCacheResetCode()
        {
            // Order Mod Configuration options
            LL.Info("Sorting Laurus mod options.", LogCategory.Setup);
            GameOptionUtils.SortOptionsByCategory("LaurusMods");
            GameOptionUtils.MoveOptionToTop("LaurusMods", "OptionLaurusCoreLoggingEnabled");
            LL.Info("Finished sorting Laurus mod options.", LogCategory.Setup);

        }
    }
}