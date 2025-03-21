using System.Collections.Generic;
using XRL.UI;

namespace LaurusCoreLib.Net.Laurus.Util
{

    public static class GameOptionUtils
    {
        public static void SortOptionsByCategory(string category)
        {
            if (Options.OptionsByCategory.TryGetValue(category, out List<GameOption> options))
            {
                options.Sort((a, b) => string.Compare(a.ID, b.ID));
            }
        }

        public static void MoveOptionToTop(string category, string id)
        {
            if (Options.OptionsByCategory.TryGetValue(category, out List<GameOption> options))
            {
                var option = options.Find(o => o.ID == id);
                if (option != null)
                {
                    options.Remove(option);
                    options.Insert(0, option);
                }
            }
        }
    }
}