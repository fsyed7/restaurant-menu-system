namespace MenuSystemUI.Models
{
    public class NutritionStats
    {
        public int Calories { get; set; }
        public double Protein { get; set; }
        public double Fat { get; set; }
        public double Carbs { get; set; }

        public NutritionStats() { }

        public NutritionStats(int calories, double protein, double fat, double carbs)
        {
            Calories = calories;
            Protein = protein;
            Fat = fat;
            Carbs = carbs;
        }

        public string GetDisplayStats()
        {
            return $"Calories: {Calories}g\nProtein: {Protein}g\nFat: {Fat}g\nCarbs: {Carbs}g";
        }
    }
}
