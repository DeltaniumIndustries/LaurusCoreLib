using System.Collections.Generic;
using LaurusCoreLib.Net.Laurus.Debug;
using LaurusCoreLib.Net.Laurus.Enums;
using LaurusCoreLib.Net.Laurus.Logging;
using LaurusCoreLib.Net.Laurus.Util;
using XRL;
using XRL.World;

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

            var exporter = new BlueprintExporter("laurus-blueprints.txt");
            exporter.ExportBlueprints();
            LL.Info("Dumped all blueprints.", LogCategory.Setup);


        }
    }
}