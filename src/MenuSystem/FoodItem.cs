using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuSystem {
    public class FoodItem {

        string name, category;
        double price;
        int quantity;
        NutritionStats stats;
        Image image;
        
        public FoodItem() {
            name = "";
            category = "";
            price = 0;
            quantity = 0;
            stats = new NutritionStats();
            
        }

        public FoodItem(string name, string category, double price, int quantity, NutritionStats stats) {
            this.name = name;
            this.category = category;
            this.price = price;
            this.quantity = quantity;
            this.stats = stats;
        }

        public FoodItem(string name, string category, double price, int quantity, int cal, double pro, double fat, double carbs) {
            this.name = name;
            this.category = category;
            this.price = price;
            this.quantity = quantity;
            this.stats = new NutritionStats(cal,pro,fat,carbs);
        }

        public void reduceQty() {
            if (this.quantity > 0) this.quantity--;
        }

        public string getName() { return name; }
        public double getPrice() { return price; }
        public int getQuantity() { return quantity; }
        public NutritionStats getStats() { return stats; }
        public Image GetImage() { return image; }

        public void setImage(Image image) {  this.image = image; }

        public string getDisplayNutStats() {
            return this.stats.getDisplayStats();
        }

        public string getdisplay() {
            return name + " (" + category + ") - $" + price
        + "\n| Qty: " + quantity +  "\n" + stats.getDisplayStats();
        
}

}
}
