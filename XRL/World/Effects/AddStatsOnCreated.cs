using System;

namespace XRL.World.Parts
{
    [Serializable]
    public class AddStatsOnCreated : GenericOnEntityCreatedPart
    {

        protected override bool ShouldRun(GameObject entity)
        {
            return true;
        }

        protected override bool IsDebug()
        {
            return true;
        }

        protected override void OnObjectCreated(GameObject entity)
        {

        }
    }
}
