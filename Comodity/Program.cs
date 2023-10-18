using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using System.Collections.Generic;
using CommodityLib;
using static CommodityLib.CommodityLib;

class Program
{
    static void Main(string[] args)
    {
        Commodity milk = CommodityLib.CommodityLib.CreateCommodity("Milk", 50, 0.6, false, 0.6, "EuroSpar");
        Commodity cookies = CommodityLib.CommodityLib.CreateCommodity("Cookies", 63, 0.6, true, 0.7, "EuroSpar");
        Commodity bread = CommodityLib.CommodityLib.CreateCommodity("Bread", 28, 0.4, false, 0.5, "EuroSpar");
        Commodity cheese = CommodityLib.CommodityLib.CreateCommodity("Cheese", 150, 1, false, 0.9, "EuroSpar");
        Commodity egg = CommodityLib.CommodityLib.CreateCommodity("Egg", 15, 0.11, true, 0.5, "EuroSpar");
        Commodity juice = CommodityLib.CommodityLib.CreateCommodity("Juice", 102, 0.5, false, 0.4, "EuroSpar");
        Commodity cottageCheese = CommodityLib.CommodityLib.CreateCommodity("Cottage Cheese", 60, 0.3, false, 0.7, "EuroSpar");
        Commodity oil = CommodityLib.CommodityLib.CreateCommodity("Oil", 96, 0.960, true, 0.9, "EuroSpar");
        Commodity tomato = CommodityLib.CommodityLib.CreateCommodity("Tomato", 12, 0.120, true, 0.7, "EuroSpar");
        Commodity potato = CommodityLib.CommodityLib.CreateCommodity("Potato", 9, 0.080, false, 0.5, "EuroSpar");
        Clothes tshirt = CommodityLib.CommodityLib.CreateClothes("ЦУМ", "ГУЧИ ФУТБОЛКА");
        /*
                        ИМЯ_КЛАССА НАЗВАНИЕ_ТВОЕГО_ОБЪЕКТА = НАЗВАНИЕ_ПРОЕКТА . НЕЙМСПЕЙС_ПРОЕКТА ( ПАРАМЕТРЫ КОНСТРУКТОРА ) ;      Dependencies / Link
        */

        List<Commodity> products = new List<Commodity>();
        products.Add(potato);
        products.Add(tomato);
        products.Add(milk);
        products.Add(oil);
        products.Add(cottageCheese);
        products.Add(juice);
        products.Add(egg);
        products.Add(cheese);
        products.Add(bread);
        products.Add(cookies);
        products.Add(tshirt);

        SortByType(products);
        milk.Overwrite();
    }

    static void SortByType(List<Commodity> products)
    {
        var sortedProducts = products.OrderBy(p => p.GetType().Name).ToList();
        var sortedClothes = products.OrderBy(p => p.GetType().Name).ToList();

        foreach (var product in sortedProducts)
        {
            Console.WriteLine("Тут наши продукты:");
            string json = JsonConvert.SerializeObject(product);
            Console.WriteLine(json);
        }

        foreach (var clothes in sortedProducts)
        {
            Console.WriteLine("А тут шмотки из цума:");
            string json1 = JsonConvert.SerializeObject(clothes);
            Console.WriteLine(json1);
        }
    }
}




