using XRL.World.Parts;

//<builder Name="ExampleBuilder" Stats="Strength,Hitpoints,MoveSpeed" ChanceOneIn="5" />
namespace XRL.World.ObjectBuilders
{

    public class GenericStatsOnCreated : IObjectBuilder
    {

        public int Tier;

        public override void Apply(GameObject Object, string Context)
        {
            var minBoost = RandomUtils.NextInt(1, 2) * Tier;
            var maxBoost = RandomUtils.NextIntWeighted(3, 6, 4) * Tier;
            StatUtils.BoostAttributes(Object, minBoost, maxBoost);
        }

    }

}