using System.Collections.Generic;
using System.Linq;
using MenuSystemUI.Models;

namespace MenuSystemUI.Services
{
    public class CartService
    {
        private readonly List<CartItem> _items = new();

        public IReadOnlyList<CartItem> Items => _items;

        public void AddOrUpdate(FoodItem food, int quantity, List<string>? selectedToppings = null)
        {
            if (quantity <= 0) return;

            double unitPrice = food.Price;
            string? toppingsSummary = null;

            // If this item supports toppings and user selected some, add their price
            if (food is FoodItemWithToppings ft &&
                selectedToppings != null &&
                selectedToppings.Any())
            {
                var chosen = ft.Toppings
                    .Where(t => selectedToppings.Contains(t.Name))
                    .ToList();

                toppingsSummary = string.Join(", ", chosen.Select(t => t.Name));
                unitPrice += chosen.Sum(t => t.Price);
            }

            // Same dish with same toppings merges into one line;
            // different toppings become separate cart lines.
            var existing = _items.FirstOrDefault(i =>
                i.FoodId == food.Id &&
                i.ToppingsSummary == toppingsSummary);

            if (existing == null)
            {
                _items.Add(new CartItem
                {
                    FoodId = food.Id,
                    Name = food.Name,
                    UnitPrice = unitPrice,
                    Quantity = quantity,
                    ToppingsSummary = toppingsSummary
                });
            }
            else
            {
                existing.Quantity += quantity;
            }
        }

        public void Clear() => _items.Clear();

        public double GetTotal() => _items.Sum(i => i.LineTotal);
    }
}

