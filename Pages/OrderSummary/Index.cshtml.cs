using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MenuSystemUI.Models;
using MenuSystemUI.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MenuSystemUI.Pages.OrderSummary
{
    public class IndexModel : PageModel
    {
        private readonly CartService _cart;
        private readonly InventoryService _inventory;
        private readonly DatabaseService _database;

        public IReadOnlyList<CartItem> Items { get; private set; } = new List<CartItem>();
        public double Total { get; private set; }

        [TempData]
        public string? Message { get; set; }

        public IndexModel(CartService cart, InventoryService inventory, DatabaseService database)
        {
            _cart = cart;
            _inventory = inventory;
            _database = database;
        }

        public void OnGet()
        {
            Items = _cart.Items;
            Total = _cart.GetTotal();
        }

        public async Task<IActionResult> OnPostPlaceOrderAsync()
        {
            Items = _cart.Items;
            Total = _cart.GetTotal();

            foreach (var item in Items)
            {
                // Update inventory – integration ready
                await _inventory.UpdateStockAsync(item.FoodId, item.Quantity);
            }

            // Example call into DatabaseService (currently logs only)
            await _database.GetMenusAndItemsAsync();

            _cart.Clear();
            Message = "Order placed. Inventory and database services were invoked (integration-ready).";

            return RedirectToPage();
        }

        public IActionResult OnPostClearAsync()
        {
            _cart.Clear();
            return RedirectToPage();
        }
    }
}
