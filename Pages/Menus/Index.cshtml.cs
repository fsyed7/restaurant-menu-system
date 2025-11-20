using Microsoft.AspNetCore.Mvc.RazorPages;
using MenuSystemUI.Models;
using MenuSystemUI.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MenuSystemUI.Pages.Menus
{
    public class IndexModel : PageModel
    {
        private readonly IMenuDataService _data;
        private readonly CartService _cart;

        public List<Menu> Menus { get; private set; } = new();
        public string Filter { get; private set; } = "All";

        public IndexModel(IMenuDataService data, CartService cart)
        {
            _data = data;
            _cart = cart;
        }

        // filter comes from query string (?filter=Dinner)
        public async Task OnGetAsync(string? filter)
        {
            Filter = string.IsNullOrWhiteSpace(filter) ? "All" : filter;

            var allMenus = await _data.GetMenusAsync();

            if (Filter == "All")
            {
                Menus = allMenus;
            }
            else
            {
                Menus = allMenus
                    .Where(m => m.Name == Filter)
                    .ToList();
            }
        }

        // Add one of this dish to the cart from the menu page
        public async Task<IActionResult> OnPostAddToCartAsync(int id, string? filter)
        {
            Filter = string.IsNullOrWhiteSpace(filter) ? "All" : filter;

            var food = await _data.GetFoodByIdAsync(id);
            if (food != null)
            {
                _cart.AddOrUpdate(food, 1);   // 1 of this dish
            }

            // reload page with same filter
            return RedirectToPage(new { filter = Filter });
        }
    }
}




