namespace TradeAndTravel
{
    using System.Collections.Generic;

    public class Weapon : Item
    {
        private const int WeaponValue = 10;

        public Weapon(string name, Location location = null)
            : base(name, Weapon.WeaponValue, ItemType.Weapon, location)
        {
        }
    }
}
