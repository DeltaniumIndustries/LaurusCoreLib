using System;
using XRL.World;

namespace XRL.World.Parts
{
    [Serializable]
    public class ObsoleteBlueprintConverter : GenericOnEntityCreatedPart
    {

        public readonly string ReplacementBlueprint;

        protected override bool ShouldRun(GameObject entity)
        {
            return true;
        }

        protected override bool IsDebug()
        {
            return false;
        }

        public override bool HandleEvent(AfterObjectCreatedEvent E)
        {
            GameObject entity = ParentObject;
            LL.Info($"{entity.DisplayName} has been created.", LogCategory.Debug);

            if (IsDebug() || ShouldRun(entity))
            {
                LL.Info($"Running replacement logic for '{entity.DisplayName}'. Blueprint marked as OBSOLETE.", LogCategory.System);

                var replacement = GameObject.FindByBlueprint(ReplacementBlueprint);
                if (replacement != null)
                {
                    E.ReplacementObject = replacement;
                    LL.Info($"Replacement object set to '{ReplacementBlueprint}'.", LogCategory.System);
                }
                else
                {
                    LL.Info($"Failed to find replacement blueprint '{ReplacementBlueprint}'.", LogCategory.System);
                }
            }

            if (ParentObject.RemovePart(GetType().Name))
            {
                LL.Info($"Removed part from {entity.DisplayName}.", LogCategory.Debug);
            }
            return base.HandleEvent(E);
        }

        protected override void OnObjectCreated(GameObject entity)
        {
            // No-Op
        }
    }
}
