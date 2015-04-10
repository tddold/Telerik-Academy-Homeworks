namespace TradeAndTravel
{
    using System.Collections.Generic;

    public class ExtendedInteractionManager : InteractionManager
    {
        private const string WeaponType = "weapon";
        private const string WoodType = "wood";
        private const string IronType = "iron";
        private const string MineType = "mine";
        private const string ForestType = "forest";
        private const string GatherCommand = "gather";
        private const string CraftCommand = "craft";
        private const string ArmorItemToCraft = "armor";
        private const string WeaponItemToCraft = "weapon";
        private const string MerchantType = "merchant";

        protected override Item CreateItem(string itemTypeString, string itemNameString, Location itemLocation, Item item)
        {
            switch (itemTypeString)
            {
                case WeaponType:
                    {
                        item = new Weapon(itemNameString, itemLocation);
                        break;
                    }

                case WoodType:
                    {
                        item = new Wood(itemNameString, itemLocation);
                        break;
                    }

                case IronType:
                    {
                        item = new Iron(itemNameString, itemLocation);
                        break;
                    }

                default:
                    item = base.CreateItem(itemTypeString, itemNameString, itemLocation, item);
                    break;
            }

            return item;
        }

        protected override Location CreateLocation(string locationTypeString, string locationName)
        {
            Location location = null;

            switch (locationTypeString)
            {
                case MineType:
                    {
                        location = new Mine(locationName);
                        break;
                    }

                case ForestType:
                    {
                        location = new Forest(locationName);
                        break;
                    }

                default:
                    location = base.CreateLocation(locationTypeString, locationName);
                    break;
            }

            return location;
        }

        protected override Person CreatePerson(string personTypeString, string personNameString, Location personLocation)
        {
            Person person = null;

            switch (personTypeString)
            {
                case MerchantType:
                    {
                        person = new Merchant(personNameString, personLocation);
                        break;
                    }

                default:
                    person = base.CreatePerson(personTypeString, personNameString, personLocation);
                    break;
            }

            return person;
        }

        protected override void HandlePersonCommand(string[] commandWords, Person actor)
        {
            switch (commandWords[1])
            {
                case GatherCommand:
                    {
                        this.HandleGatherInteraction(commandWords, actor);
                        break;
                    }

                case CraftCommand:
                    {
                        this.HandleCraftInteraction(commandWords, actor);
                        break;
                    }

                default:
                    base.HandlePersonCommand(commandWords, actor);
                    break;
            }
        }

        private static bool InventoryHasItemType(ItemType requiredItem, List<Item> inventory)
        {
            foreach (var item in inventory)
            {
                if (item.ItemType == requiredItem)
                {
                    return true;
                }
            }

            return false;
        }

        private void HandleGatherInteraction(string[] commandWords, Person actor)
        {
            string itemName = commandWords[2];

            var gatheringLocation = actor.Location as IGatheringLocation;

            if (gatheringLocation != null)
            {
                var requiredItemType = gatheringLocation.RequiredItem;
                var actorInventory = actor.ListInventory();

                bool hasItem = InventoryHasItemType(requiredItemType, actorInventory);

                if (hasItem)
                {
                    this.AddToPerson(actor, gatheringLocation.ProduceItem(itemName));
                }
            }
        }

        private void HandleCraftInteraction(string[] commandWords, Person actor)
        {
            string itemTypeToCraft = commandWords[2];
            string itemName = commandWords[3];

            var inventory = actor.ListInventory();

            if (itemTypeToCraft == ArmorItemToCraft)
            {
                if (InventoryHasItemType(ItemType.Iron, inventory))
                {
                    this.AddToPerson(actor, new Armor(itemName));
                }
            }

            if (itemTypeToCraft == WeaponItemToCraft)
            {
                if (InventoryHasItemType(ItemType.Iron, inventory) && InventoryHasItemType(ItemType.Wood, inventory))
                {
                    this.AddToPerson(actor, new Weapon(itemName));
                }
            }
        }
    }
}
