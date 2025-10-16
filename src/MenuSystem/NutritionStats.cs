using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuSystem {
     public class NutritionStats {

        protected int calories;
        protected double protein;
        protected double fat;
        protected double carbs;

        public NutritionStats() {
            calories = 0;
            protein = 0;
            fat = 0;
            carbs = 0;
        }

        public NutritionStats(int calories, double protein, double fat, double carbs) {
            this.calories = calories;
            this.protein = protein;
            this.fat = fat;
            this.carbs = carbs;
        }

        public int getCalories() { return calories; }
        public double getProtein() {  return protein; }
        public double getFat() { return fat; }
        public double getCarbs() { return carbs; }

        public string getDisplayStats() {
            return
                "| Calories: " + calories
        + "\n| Protein: " + protein + "g"
        + "\n| Fat: " + fat + "g"
        + "\n| Carbs: " + carbs + "g";
        }
    }
}
