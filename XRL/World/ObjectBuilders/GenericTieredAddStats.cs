
//<builder Name="ExampleBuilder" Stats="Strength,Hitpoints,MoveSpeed" ChanceOneIn="5" />
using System.Collections.Generic;
using LaurusCoreLib.Net.Laurus.Util;

namespace XRL.World.ObjectBuilders
{

    public class GenericTieredAddStats : LaurusAbstractObjectBuilder
    {

        public int Tier;

        protected override List<GameObject> GetItemsToAdd()
        {
            return NO_ITEM_LIST;
        }

        protected override void ModifyStats(GameObject Object)
        {
            var minBoost = RandomUtils.NextInt(1, 2) * Tier;
            var maxBoost = RandomUtils.NextIntWeighted(3, 6, 4) * Tier;
            StatUtils.BoostAttributes(Object, minBoost, maxBoost);
        }

        protected override void OnInitialize()
        {

        }

        protected override void OnPostApply(GameObject Object, string Context)
        {

        }

        protected override void OnPreApply(GameObject Object, string Context)
        {

        }
    }

}