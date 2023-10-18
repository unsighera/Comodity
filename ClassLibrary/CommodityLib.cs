using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Diagnostics;

namespace CommodityLib
{
    public static class CommodityLib
    {
        public static Commodity CreateCommodity(string name, double price, double weight, bool fragile, double volume, string shop)
        {
            return new Commodity(name, price, weight, fragile, volume, shop);
        }

        public static Clothes CreateClothes(string shop, string name)
        {
            return new Clothes(shop, name);
        }

        public class Commodity
        {
            public string Name { get; set; }
            public double Price { get; set; }
            public double Weight { get; set; }
            public bool Fragile { get; set; }
            public double Volume { get; set; }
            public string Shop { get; set; }

            public void Overwrite()
            {
                string json = JsonConvert.SerializeObject(this);
                Console.WriteLine(json);
            }

            public Commodity(string name, double price, double weight, bool fragile, double volume, string shop)
            {
                Name = name;
                Price = price;
                Weight = weight;
                Fragile = fragile;
                Volume = volume;
                Shop = shop;
            }

            public Commodity(string shop, string name)
            {
                Name = name;
                Shop = shop;
            }
        }

        public class Clothes : Commodity
        {
            public Clothes(string Shop, string name) : base(Shop, name) { }

        }
    }
}
