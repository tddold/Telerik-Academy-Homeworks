namespace TradeAndTravel
{
    public class Forest : GatheringLocation
    {
        private const string ForestName = "Cherokee";

        public Forest(string name)
            : base(Forest.ForestName, LocationType.Forest, ItemType.Wood, ItemType.Weapon)
        {
        }
    }
}
