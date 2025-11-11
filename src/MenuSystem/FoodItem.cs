using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuSystem {
    public class FoodItem {

        protected string name, category;
        protected double price;
        protected int quantity;
        protected NutritionStats stats;
        protected Image image;
        
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
        public FoodItem(FoodItem f) {
            this.name = f.name;
            this.category = f.category;
            this.price = f.price;
            this.quantity = f.quantity;
            this.stats = f.getStats();
            this.image = f.image;
        }
        public void reduceQty() {
            if (this.quantity > 0) this.quantity--;
        }

        public string getName() { return name; }
        virtual public double getPrice() { return price; }
        public int getQuantity() { return quantity; }
        public NutritionStats getStats() { return stats; }
        public Image GetImage() { return image; }

        public void setImage(Image image) {  this.image = image; }

        public string getDisplayNutStats() {
            return this.stats.getDisplayStats();
        }

        public string getDisplay() {
            return name + " (" + category + ") - $" + price
        + "\n| Qty: " + quantity +  "\n" + stats.getDisplayStats();
        
        }
        virtual public string getCartName() {
            return name + " - $" + price;
        }
    }
}
