using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuSystem {
    public class Toppings {

        string name;
        double price;
        int cals;

        public Toppings() {
            name = "";
            price = 0;
            cals = 0;
        }

        public Toppings(string name, double price, int cals) {
            this.name = name;
            this.price = price;
            this.cals = cals;
        }

        public double getPrice() {
            return price;
        }

        public string getDisplay() {
            return name + "\n$" + price + "\nCalories: " + cals + "\n";
        }
    }
}
