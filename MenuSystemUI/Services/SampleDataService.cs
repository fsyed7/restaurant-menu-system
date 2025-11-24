using System.Collections.Generic;
using System.Threading.Tasks;
using MenuSystemUI.Models;

namespace MenuSystemUI.Services
{
    public class SampleDataService : IMenuDataService
    {
        public List<Menu> Menus { get; } = new();

        public SampleDataService()
        {
            // --- Nutrition stats ---
            var pastaStats = new NutritionStats(250, 10, 5, 30);
            var burgerStats = new NutritionStats(400, 20, 15, 50);
            var juiceStats = new NutritionStats(20, 0, 0, 0);
            var popStats = new NutritionStats(100, 0, 30, 0);

            // --- Toppings for burger ---
            var burgerTops = new List<Toppings>
            {
                new Toppings("Cheese",  2.00, 50),
                new Toppings("Tomato",  1.00, 10),
                new Toppings("Lettuce", 0.50, 10),
                new Toppings("Ketchup", 0.25, 20),
            };

            // --- Food items ---
            var pasta = new FoodItem
            {
                Id = 1,
                Name = "Pasta Alfredo",
                Category = "Main Course",
                Price = 12.99,
                Quantity = 10,
                Stats = pastaStats,
                ImagePath = "/images/pasta.jpg",
                Description = "Creamy Alfredo pasta with parmesan and fresh herbs."
            };

            var burger = new FoodItemWithToppings(
                name: "Signature Burger",
                category: "Grill & Burger",
                price: 9.99,
                quantity: 5,
                stats: burgerStats,
                toppings: burgerTops)
            {
                Id = 2,
                ImagePath = "/images/burger-hero.jpg",
                Description = "Juicy double-patty burger with customizable toppings."
            };

            var appleJuice = new FoodItem
            {
                Id = 3,
                Name = "Apple Juice",
                Category = "Juice",
                Price = 2.99,
                Quantity = 20,
                Stats = juiceStats,
                ImagePath = "/images/apple-juice.jpg",
                Description = "Freshly pressed apple juice served chilled."
            };

            var pop = new FoodItem
            {
                Id = 4,
                Name = "Sparkling Pop",
                Category = "Soft Drink",
                Price = 3.99,
                Quantity = 3,
                Stats = popStats,
                ImagePath = "/images/pop.jpg",
                Description = "Sparkling soft drink with a fruity twist."
            };

            // --- Menus ---
            var dinnerMenu = new Menu { Name = "Dinner" };
            dinnerMenu.Items.Add(pasta);
            dinnerMenu.Items.Add(burger);

            var drinksMenu = new Menu { Name = "Drinks" };
            drinksMenu.Items.Add(appleJuice);
            drinksMenu.Items.Add(pop);

            Menus.Add(dinnerMenu);
            Menus.Add(drinksMenu);
        }

        // IMenuDataService

        public Task<List<Menu>> GetMenusAsync() =>
            Task.FromResult(Menus);

        public Task<FoodItem?> GetFoodByIdAsync(int id)
        {
            foreach (var menu in Menus)
            {
                foreach (var item in menu.Items)
                {
                    if (item.Id == id)
                        return Task.FromResult<FoodItem?>(item);
                }
            }
            return Task.FromResult<FoodItem?>(null);
        }
    }
}

