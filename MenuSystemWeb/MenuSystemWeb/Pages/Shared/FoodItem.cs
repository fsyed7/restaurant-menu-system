namespace MenuSystemWeb.Pages.Shared {
    public class FoodItem {
        string name;
        double price;
        int quantity;
        int cals;
        //Image image;

        public FoodItem() {
            name = "";
            
            price = 0;
            quantity = 0;
            cals = 0;

        }

        public FoodItem(string name, double price, int quantity, int cals) {
            this.name = name;
            
            this.price = price;
            this.quantity = quantity;
            this.cals = cals;
        }

        public void reduceQty() {
            if (this.quantity > 0) this.quantity--;
        }

        public string getName() { return name; }
        public double getPrice() { return price; }
        public int getQuantity() { return quantity; }

        //public Image GetImage() { return image; }
        public string getdisplay() {
            return name + "- $" + price
        + "\n| Qty: " + quantity + "\nCalories " + cals;

        }
    }
}
