namespace MenuSystemUI.Models
{
    public class Toppings
    {
        public string Name { get; set; } = string.Empty;
        public double Price { get; set; }
        public int Calories { get; set; }

        public Toppings() { }

        public Toppings(string name, double price, int calories)
        {
            Name = name;
            Price = price;
            Calories = calories;
        }

        public string GetDisplay()
        {
            return $"{Name}\n${Price}\nCalories: {Calories}\n";
        }
    }
}
