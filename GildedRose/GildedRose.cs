using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;

        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                ItemUpdater updater = GetUpdater(item);
                updater.UpdateQuality(item);
            }
        }

        private ItemUpdater GetUpdater(Item item)
        {
            switch (item.Name)
            {
                case "+5 Dexterity Vest":
                    return new DexterityVestUpdater();
                case "Aged Brie":
                    return new AgedBrieUpdater();
                case "Elixir of the Mongoose":
                    return new ElixirUpdater();
                case "Sulfuras, Hand of Ragnaros":
                    return new SulfurasUpdater();
                case "Backstage passes to a TAFKAL80ETC concert":
                    return new BackstagePassUpdater();
                case "Conjured Mana Cake":
                    return new ConjuredManaCakeUpdater();
                default:
                    return new DefaultItemUpdater();
            }
        }
    }

    public class DexterityVestUpdater : ItemUpdater
    {
        public override void UpdateQuality(Item item)
        {
            DecreaseQuality(item);
            DecreaseSellIn(item);

            if (item.SellIn < 0)
            {
                DecreaseQuality(item);
            }
        }
    }

    public class AgedBrieUpdater : ItemUpdater
    {
        public override void UpdateQuality(Item item)
        {
            IncreaseQuality(item);
            DecreaseSellIn(item);

            if (item.SellIn < 0)
            {
                IncreaseQuality(item);
            }
        }
    }

    public class ElixirUpdater : ItemUpdater
    {
        public override void UpdateQuality(Item item)
        {
            DecreaseQuality(item);
            DecreaseSellIn(item);

            if (item.SellIn < 0)
            {
                DecreaseQuality(item);
            }
        }
    }

    public class SulfurasUpdater : ItemUpdater
    {
        public override void UpdateQuality(Item item) { }
    }

    public class BackstagePassUpdater : ItemUpdater
    {
        public override void UpdateQuality(Item item)
        {
            IncreaseQuality(item);

            if (item.SellIn <= 10)
            {
                IncreaseQuality(item);
            }

            if (item.SellIn <= 5)
            {
                IncreaseQuality(item);
            }

            DecreaseSellIn(item);

            if (item.SellIn < 0)
            {
                item.Quality = 0;
            }
        }
    }

    public class ConjuredManaCakeUpdater : ItemUpdater
    {
        public override void UpdateQuality(Item item)
        {
            DecreaseQuality(item, 2);
            DecreaseSellIn(item);
        }
    }

    public class DefaultItemUpdater : ItemUpdater
    {
        public override void UpdateQuality(Item item)
        {
            DecreaseQuality(item);
            DecreaseSellIn(item);

            if (item.SellIn < 0)
            {
                DecreaseQuality(item);
            }
        }
    }

    public abstract class ItemUpdater
    {
        protected void IncreaseQuality(Item item, int factor = 1)
        {
            if (item.Quality < 50)
            {
                item.Quality += factor;

                if (item.Quality > 50)
                {
                    item.Quality = 50;
                }
            }
        }

        protected void DecreaseQuality(Item item, int factor = 1)
        {
            if (item.Quality > 0)
            {
                item.Quality -= factor;

                if (item.Quality < 0)
                {
                    item.Quality = 0;
                }
            }
        }

        protected void DecreaseSellIn(Item item)
        {
            if (item.Name != "Sulfuras, Hand of Ragnaros")
            {
                item.SellIn -= 1;
            }
        }

        public abstract void UpdateQuality(Item item);
    }
}