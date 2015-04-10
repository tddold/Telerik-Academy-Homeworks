namespace TradeAndTravel
{
    public class Wood : Item
    {
        private const string CurrentInteractionToCheck = "drop";
        private const int MinimumValueToCheckBy = 0;
        private const int PermanentWoodValue = 0;
        private const int WoodValue = 2;

        public Wood(string name, Location location = null)
            : base(name, Wood.WoodValue, ItemType.Wood, location)
        {
        }

        public override void UpdateWithInteraction(string interaction)
        {
            if (interaction == CurrentInteractionToCheck)
            {
                this.Value--;

                if (this.Value < MinimumValueToCheckBy)
                {
                    this.Value = PermanentWoodValue;
                }
            }

            base.UpdateWithInteraction(interaction);
        }
    }
}
