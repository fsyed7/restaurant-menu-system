using System.Xml.Linq;

namespace MenuSystemUI.Models
{
    public class FoodItem
    {
        public FoodItem()
        {
            Id = 0;
            Name = "none";
            Category = "category";
            Price = 0;
            Quantity = 0;
            Stats.Calories = 0;
            Description = "description";
            ImagePath = "imagePath";
        }

        public FoodItem(int id, string name, string category, double price, int quantity, int cals, string description, string? imagePath) 
            : base ()
        {
            Id = id;
            Name = name;
            Category = category;
            Price = price;
            Quantity = quantity;
            Stats.Calories = cals;
            Description = description;
            ImagePath = imagePath;
        }

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;

        public virtual double Price { get; set; }

        public int Quantity { get; set; }
        public NutritionStats Stats { get; set; } = new NutritionStats();

        // NEW: description shown on details page
        public string Description { get; set; } = string.Empty;

        // NEW: image path used by menus/details UI
        public string? ImagePath { get; set; }

        public string GetDisplay()
        {
            return $"{Name} ({Category}) - ${Price}\n" +
                   $"Qty: {Quantity}\n" +
                   Stats.GetDisplayStats();
        }

        public virtual string GetCartName()
        {
            return $"{Name} - ${Price}";
        }
    }
}


