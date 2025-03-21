using System.Collections.Generic;

namespace XRL.World.ObjectBuilders
{
    public abstract class LaurusAbstractObjectBuilder : IObjectBuilder
    {
        protected static List<GameObject> NO_ITEM_LIST = new();
        
        // Lifecycle hooks that subclasses *must* implement
        protected abstract void OnInitialize();
        protected abstract void OnPreApply(GameObject Object, string Context);
        protected abstract void OnPostApply(GameObject Object, string Context);
        protected abstract List<GameObject> GetItemsToAdd();
        protected abstract void ModifyStats(GameObject Object);

        public sealed override void Initialize()
        {
            base.Initialize();
            OnInitialize();
        }

        public sealed override void Apply(GameObject Object, string Context)
        {
            OnPreApply(Object, Context);
            ModifyStats(Object);
            AddItems(Object, GetItemsToAdd());
            OnPostApply(Object, Context);
        }

        private void AddItems(GameObject Object, List<GameObject> Items)
        {
            foreach (GameObject item in Items)
            {
                Object.ReceiveObject(item);
            }
        }

    }
}
