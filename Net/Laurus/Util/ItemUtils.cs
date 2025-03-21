using XRL.World;

namespace LaurusCoreLib.Net.Laurus.Util
{
    public class ItemUtils
    {
        public static void TryGiveItemToGameObject(GameObject Item, GameObject Object)
        {

        }
        public static void TryGiveItemToGameObjectFromPopulationTable(string PopTableName, GameObject Object)
        {
            TryGiveItemToGameObjectFromPopulationTable(PopTableName, Object, 0);
        }
        public static void TryGiveItemToGameObjectFromPopulationTable(string PopTableName, GameObject Object, int BonusModChance)
        {
            Object.ReceiveObjectFromPopulation(PopTableName, BonusModChance: BonusModChance);
        }

    }
}