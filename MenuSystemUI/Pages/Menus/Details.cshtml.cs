using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MenuSystemUI.Models;
using MenuSystemUI.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MenuSystemUI.Pages.Menus
{
    public class DetailsModel : PageModel
    {
        private readonly IMenuDataService _data;
        private readonly CartService _cart;
        private readonly InventoryService _inventory;

        public FoodItem? Food { get; private set; }
        public List<Toppings> Toppings { get; private set; } = new();

        [BindProperty]
        public int Quantity { get; set; } = 1;

        // NEW: names of toppings the user checks off
        [BindProperty]
        public List<string> SelectedToppings { get; set; } = new();

        public DetailsModel(IMenuDataService data, CartService cart, InventoryService inventory)
        {
            _data = data;
            _cart = cart;
            _inventory = inventory;
        }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Food = await _data.GetFoodByIdAsync(id);
            if (Food == null) return NotFound();

            if (Food is FoodItemWithToppings ft)
            {
                Toppings = ft.Toppings;
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAddToCartAsync(int id)
        {
            var food = await _data.GetFoodByIdAsync(id);
            if (food == null) return NotFound();

            // Use SelectedToppings for items that support them
            _cart.AddOrUpdate(food, Quantity, SelectedToppings);

            return RedirectToPage("/OrderSummary/Index");
        }
    }
}

