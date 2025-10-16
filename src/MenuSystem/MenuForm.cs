using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuSystem {
    public partial class Menu_Select : Form {
        public Menu_Select() {
            InitializeComponent();
        }

        enum states {menu, food }
        states state;
        List<FoodItem> cart;
      

        public void SwitchState() {
            if (state == states.menu) {
                //switching to food list
                menuListLayout.Visible = false;
                foodMenulayout.Visible = true;
                btnBack.Visible = true;
                btnCheckout.Visible = false;
                state = states.food;

            }else if (state == states.food) {
                //switching to menu list
                foodMenulayout.Visible = false;
                menuListLayout.Visible = true;
                btnBack.Visible = false;
                foodMenulayout.Controls.Clear();
                btnCheckout.Visible = true;
                state = states.menu;
            }
        }
        public void addToCart(FoodItem item) {
            cart.Add(item);
            MessageBox.Show(item.getName() + " has been added to cart");
            updateCart();
        }
        public void updateCart() {
            string carttext = "";
            rTextCart.Text = carttext;
            foreach (FoodItem item in cart) {
                carttext += item.getName() + "\n";
            }
            rTextCart.Text = carttext;
        }
        public void ListFood(FoodItem f) {

            FlowLayoutPanel panel = new FlowLayoutPanel();
            PictureBox pBox = new PictureBox();
            RichTextBox textBox = new RichTextBox();
            Button btnbuy = new Button();
            btnbuy.Size = new Size(100, 100);
            btnbuy.Text = "Add to Cart";
            pBox.SizeMode = PictureBoxSizeMode.Zoom;
            pBox.Image = f.GetImage();
            
            textBox.Text = f.getdisplay();
            panel.Size = new Size(650, 250);
            
            Size ins = new Size(200, 200);
            textBox.Size = ins;
            pBox.Size = ins;
            panel.Controls.Add(pBox);
            panel.Controls.Add(textBox);
            panel.Controls.Add(btnbuy);

            btnbuy.Click += (sender, e) => {
                addToCart(f);
                
            };

            panel.FlowDirection = FlowDirection.LeftToRight;

            foodMenulayout.Controls.Add(panel);
            foodMenulayout.FlowDirection = FlowDirection.TopDown;
        }

        public void ListMenu(Menu m) {
            FlowLayoutPanel panel = new FlowLayoutPanel();
            PictureBox pBox = new PictureBox();
            Label lblname = new Label();
            pBox.SizeMode = PictureBoxSizeMode.Zoom;
            pBox.Image = m.getImage();
            
            
            panel.Size = new Size(400, 300);
            
            
            Size ins = new Size(200, 200);
            
            pBox.Size = ins;
            lblname.Size = new Size(200,50);
            lblname.Font = new Font("Arial", 30);
            lblname.TextAlign = ContentAlignment.MiddleCenter;
            panel.Controls.Add(pBox);
            panel.Controls.Add(lblname);
            panel.FlowDirection = FlowDirection.TopDown;
            lblname.Text = m.getName();
            pBox.Enabled = false;
            lblname.Enabled = false;

            panel.Click += (sender, e) => {
                menuSelected(m);
            };

            menuListLayout.Controls.Add(panel);
            menuListLayout.FlowDirection = FlowDirection.LeftToRight;
            
        }

        public void menuSelected(Menu m) {
            SwitchState();
            foreach(FoodItem f in m.getitems()) {
                ListFood(f);
            }
        }
        
        private void MenuForm_Load(object sender, EventArgs e) {

            
            cart = new List<FoodItem>();
            state = states.menu;
            foodMenulayout.Visible = false;

            // Create Nutrition Stats
            NutritionStats pastaNutrition = new NutritionStats(250, 10, 5, 30);
            NutritionStats burgerNutrition = new NutritionStats(400, 20, 15, 50);
            NutritionStats ajuiceNutrition = new NutritionStats(20,0,0,0);
            NutritionStats popNutrition = new NutritionStats(100, 0, 30, 0);

            // Create Food Items
            FoodItem pasta = new FoodItem("Pasta", "Main Course", 12.99, 10, pastaNutrition);
            FoodItem burger = new FoodItem("Burger", "Fast Food", 9.99, 5, burgerNutrition);
            FoodItem applejuice = new FoodItem("Apple Juice", "Juice", 2.99, 20, ajuiceNutrition);
            FoodItem pop = new FoodItem("Pop", "Soft Drink", 3.99, 3, popNutrition);

            pasta.setImage(Properties.Resources.testImage);
            burger.setImage(Properties.Resources.testImage);
            applejuice.setImage(Properties.Resources.testImage);   
            pop.setImage(Properties.Resources.testImage);  
            // Create Menu
            Menu dinnerMenu = new Menu("Dinner");
            Menu drinksMenu = new Menu("Drinks");
            dinnerMenu.setImage(Properties.Resources.testImage);
            drinksMenu.setImage(Properties.Resources.testImage);

            dinnerMenu.add(pasta);
            dinnerMenu.add(burger);

            drinksMenu.add(applejuice); 
            drinksMenu.add(pop);
            //Show Menus
            ListMenu(dinnerMenu);
            ListMenu(drinksMenu);

        }

        private void menuSelectPanel_Paint(object sender, PaintEventArgs e) {

        }

        private void mainMenuPanel_Click(object sender, EventArgs e) {
            SwitchState();
        }

        private void picmenu1_Click(object sender, EventArgs e) {
            SwitchState();
        }

        private void menuListLayoutPanel_Paint(object sender, PaintEventArgs e) {

        }

        private void btnBack_Click(object sender, EventArgs e) {
            SwitchState();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void rTextCart_TextChanged(object sender, EventArgs e) {

        }

        private void btnCheckout_Click(object sender, EventArgs e) {
            MessageBox.Show("(go to transaction)");
        }
    }
}
