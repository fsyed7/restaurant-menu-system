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
        public FoodItemwToppings(FoodItemwToppings f) {
            this.name = f.name;
            this.category = f.category;
            this.price = f.price;
            this.quantity = f.quantity;
            this.stats = f.getStats();
            this.image = f.image;
            toppings = new List<Toppings>();
            this.setToppings(f.getToppings());
        }
        public List<Toppings> getToppings() {
            return toppings;
        }
        public void setToppings(List<Toppings> t) {
            toppings.Clear();
            foreach(Toppings top in t) {
                toppings.Add(top);
            }
        }
        /*
        public string getDisplay() {
            string s = "";
            foreach(Toppings toppings in toppings) {
                s += toppings.getDisplay();
            }
            return s;
        }
        */
        override public double getPrice() {
            double p = price;
            foreach(Toppings toppings in toppings) {
                p += toppings.getPrice();
            }
            return p;
        }
        public void addTopping(Toppings t) {
            toppings.Add(t);
        }

        override public string getCartName() {
            string s = name + " - $" + price + "\n";
            if (toppings.Count > 0) { 
                foreach (Toppings t in toppings) {
                    s += " + " + t.getName() + " - $" + t.getPrice() + "\n";
                }
            } else {
                s += " + Nothing\n";
            }
            return s;
        }
    }
}
