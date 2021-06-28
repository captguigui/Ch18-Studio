using System;
namespace Ch18_Studio
{
    public class Menu
    {    
        public string FoodCatagories { get; set; }

        public Menu(string afood)
        {
            FoodCatagories = afood;
        }
        public static string GetTimeStamp(DateTime value)
        {
            return value.ToString("yyyyMMddHHmm");
        }


        //new food item

    }
}