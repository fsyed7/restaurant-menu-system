using System.Collections.Generic;

namespace MenuSystemUI.Models
{
    public class FoodItemWithToppings : FoodItem
    {
        public List<Toppings> Toppings { get; set; } = new List<Toppings>();

        public FoodItemWithToppings() : base() { }

        public FoodItemWithToppings(
            string name,
            string category,
            double price,
            int quantity,
            NutritionStats stats,
            List<Toppings> toppings)
            : base()
        {
            Name = name;
            Category = category;
            Price = price;        // base price only
            Quantity = quantity;
            Stats = stats;
            Toppings = toppings;
        }
    }
}

