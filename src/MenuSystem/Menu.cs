using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuSystem {
    public class Menu {
        string name;
        List<FoodItem> items;
        Image image;
        public Menu() {
            name = "";
            items = new List<FoodItem>();
        }
        public Menu(string name) {
            this.name = name;
            items = new List<FoodItem>();
        }

        public void readMenu() {
            //read name from DB
            string n = "name";
            this.name = n;
            //read Food Items from DB
            FoodItem item = new FoodItem();
            this.add(item);
        }


        public void add(FoodItem f) { items.Add(f); }
        public void remove(FoodItem f) {  items.Remove(f); }
        public void clear() { items.Clear(); }
        public string getName() { return name; }
        public int getSize() { return items.Count; }
        public List<FoodItem> getitems() { return items; }
        public Image getImage() { return image; }

        public void setImage(Image i) { image = i; }
    }
}
