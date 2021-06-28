using System;
namespace Ch18_Studio
{
    public class MenuItem
    {
        public string Food { get; set; }
        public string FoodDescription { get; set; }
        public double FoodPrice { get; set; }

        public MenuItem(string afood, string aFoodDescription, double aFoodPrice)
        {
            Food = afood;
            FoodDescription = aFoodDescription;
            FoodPrice = aFoodPrice;
        }

    }
}
