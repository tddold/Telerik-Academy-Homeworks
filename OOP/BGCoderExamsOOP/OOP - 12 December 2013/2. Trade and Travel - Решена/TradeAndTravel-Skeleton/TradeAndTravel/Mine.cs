namespace TradeAndTravel
{
    public class Mine : GatheringLocation
    {
        private const string MineName = "BobovDol";

        public Mine(string name)
            : base(Mine.MineName, LocationType.Mine, ItemType.Iron, ItemType.Armor)
        {
        }
    }
}
