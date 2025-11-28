using System.Collections.Generic;

namespace MenuSystemUI.Models
{
    public class Menu
    {
        public string Name { get; set; } = string.Empty;
        public string? ImagePath { get; set; }        // optional: for later use
        public List<FoodItem> Items { get; set; } = new List<FoodItem>();
    }
}
