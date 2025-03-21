using LaurusCoreLib.Net.Laurus.Data;
using XRL.World;

namespace LaurusCoreLib.Net.Laurus.Util
{
    public class ItemUtils
    {
        public static void TryGiveItemToGameObject(GameObject Item, GameObject Object)
        {

        }
        public static bool TryGiveItemToGameObjectFromPopulationTable(QudLootTable LootTable, GameObject Object)
        {
            return TryGiveItemToGameObjectFromPopulationTable(LootTable, Object, 0);
        }
        public static bool TryGiveItemToGameObjectFromPopulationTable(QudLootTable LootTable, GameObject Object, int BonusModChance)
        {
            return Object.ReceiveObjectFromPopulation(LootTable.TableName, BonusModChance: BonusModChance);
        }

        public static GameObject GetTieredArmour(int Tier){
            return null;
        }

        public static GameObject GetTieredWeapon(int Tier){
            return null;
        }

    }
}