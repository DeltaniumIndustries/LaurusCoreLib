
//<builder Name="ExampleBuilder" Stats="Strength,Hitpoints,MoveSpeed" ChanceOneIn="5" />
using System.Collections.Generic;

namespace XRL.World.ObjectBuilders
{

    public class GenericTieredAddEquipment : LaurusAbstractObjectBuilder
    {

        public int Tier;

        protected override List<GameObject> GetItemsToAdd()
        {
            List<GameObject> Items = new();



            return Items;
        }

        protected override void ModifyStats(GameObject Object)
        {
            
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