using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuSystem {
    public class FoodItemwToppings : FoodItem {

        List<Toppings> toppings;
        public FoodItemwToppings() : base() {
            toppings = new List<Toppings>();
        }

        public FoodItemwToppings(string name, string category, double price, int quantity, NutritionStats stats) : base(name, category, price, quantity, stats) {
            toppings = new List<Toppings>();
        }
        public FoodItemwToppings(string name, string category, double price, int quantity, NutritionStats stats, List<Toppings> toppings) : base(name, category, price, quantity, stats) {
            this.toppings = toppings;
        }
        public List<Toppings> getToppings() {
            return toppings;
        }
        public void setToppings(List<Toppings> t) {
            toppings = t;
        }
        public string getDisplay() {
            string s = "";
            foreach(Toppings toppings in toppings) {
                s += toppings.getDisplay();
            }
            return s;
        }
        public double getTotalPrice() {
            double p = price;
            foreach(Toppings toppings in toppings) {
                p += toppings.getPrice();
            }
            return p;
        }
        public void addTopping(Toppings t) {
            toppings.Add(t);
        }
    }
}
