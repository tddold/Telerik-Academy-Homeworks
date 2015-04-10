namespace TradeAndTravel
{
    public abstract class GatheringLocation : Location, IGatheringLocation
    {
        private ItemType gatheredType;
        private ItemType requiredType;

        public GatheringLocation(string name, LocationType location, ItemType gatheredType, ItemType requiredItem)
            : base(name, location)
        {
            this.GatheredType = gatheredType;
            this.RequiredItem = requiredItem;
        }

        public ItemType GatheredType
        {
            get
            {
                return this.gatheredType;
            }

            private set
            {
                this.gatheredType = value;
            }
        }

        public ItemType RequiredItem
        {
            get
            {
                return this.requiredType;
            }

            private set
            {
                this.requiredType = value;
            }
        }

        public Item ProduceItem(string name)
        {
            if (this.GatheredType == ItemType.Iron)
            {
                return new Iron(name);
            }

            if (this.GatheredType == ItemType.Wood)
            {
                return new Wood(name);
            }

            return null;
        }
    }
}
