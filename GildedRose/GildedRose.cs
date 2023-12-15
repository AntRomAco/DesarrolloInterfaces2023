using Microsoft.VisualStudio.TestPlatform.ObjectModel.Engine;
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

        private void DecreaseQuality(Item item, int factor = 1)
        {
            if (item.Quality > 0)
            {
                item.Quality -= factor;
            }
        }

        private void IncreaseQuality(Item item, int factor = 1)
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

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                if (item.Name != "Sulfuras, Hand of Ragnaros")
                {
                    item.SellIn -= 1;
                }

                switch (item.Name)
                {
                    case "Aged Brie":
                        IncreaseQuality(item);
                        break;
                    case "Backstage passes to a TAFKAL80ETC concert":
                        if (item.SellIn < 0)
                        {
                            item.Quality = 0;
                        }
                        else if (item.SellIn < 5)
                        {
                            IncreaseQuality(item, 3);
                        }
                        else if (item.SellIn < 10)
                        {
                            IncreaseQuality(item, 2);
                        }
                        else
                        {
                            IncreaseQuality(item);
                        }
                        break;
                    case "Sulfuras, Hand of Ragnaros":
                        break;
                    case "Conjured Mana Cake":
                        DecreaseQuality(item, 2);
                        break;
                    default:
                        DecreaseQuality(item);
                        break;
                }

                if (item.SellIn < 0)
                {
                    switch (item.Name)
                    {
                        case "Aged Brie":
                            IncreaseQuality(item);
                            break;
                        case "Backstage passes to a TAFKAL80ETC concert":
                            item.Quality = 0;
                            break;
                        case "Sulfuras, Hand of Ragnaros":
                            break;
                        default:
                            DecreaseQuality(item);
                            break;
                    }
                }
            }
        }
    }
}