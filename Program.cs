using System;

namespace TheMall
{
    class Program
    {
        static void Main(string[] args)
        {
            DollarStore Dollarama = new DollarStore();
            FoodStore Cinnabon = new FoodStore();
            DollarItem MultiColorPen = new DollarItem()
            {
                Name = " Multi color pen with 12 colors"
            };
            Dollarama.AddToInventory("mcp", MultiColorPen);
            FoodItem ClassicRoll = new FoodItem()
            {
                Name = "The Classic Roll",
                Price = 3.50,
                Calories = 880
            };
            FoodItem CaramelPecanBon = new FoodItem()
            {
                Name = "Caramel Pecan Bon",
                Price = 6,
                Calories = 1080
            };


            Cinnabon.AddToInventory("tcr", ClassicRoll);
            Cinnabon.AddToInventory("cp", CaramelPecanBon);

            Console.WriteLine(Dollarama.GetFromInventory("mcp").Name);
            Console.WriteLine(Cinnabon.GetFromInventory("tcr").Name);

        }
    }
}
