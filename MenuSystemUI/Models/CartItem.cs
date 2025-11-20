namespace MenuSystemUI.Models
{
    public class CartItem
    {
        public int FoodId { get; set; }
        public string Name { get; set; } = string.Empty;
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }

        // Optional: summary like "Cheese, Tomato" when we use toppings
        public string? ToppingsSummary { get; set; }

        public double LineTotal => UnitPrice * Quantity;
    }
}
