using MenuSystemUI.Models;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MenuSystemUI.Services
{
    public class InventoryService
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task<bool> UpdateStockAsync(int foodId, int quantitySold)
        {
            string apiUrl = ""; // TODO: Inventory endpoint from Inventory team

            if (string.IsNullOrWhiteSpace(apiUrl))
            {
                Console.WriteLine($"[InventoryService] Would update inventory for FoodId={foodId}, Qty={quantitySold} (no API configured yet).");
                await Task.CompletedTask;
                return true;
            }

            try
            {
                string json = $"{{\"foodId\": {foodId}, \"quantitySold\": {quantitySold}}}";
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync(apiUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Inventory successfully updated in Inventory Management System!");
                    return true;
                }

                Console.WriteLine($"Inventory API returned error: {response.StatusCode}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to update inventory: {ex.Message}");
            }

            return false;
        }

        public async Task<bool> getMenu(Models.Menu menu) {
            string apiUrl = ""; // TODO: Inventory endpoint from Inventory team

            if (string.IsNullOrWhiteSpace(apiUrl)) {
                //Console.WriteLine($"[InventoryService] Would update inventory for FoodId={foodId}, Qty={quantitySold} (no API configured yet).");
                await Task.CompletedTask;
                return true;
            }

            try {
                int foodId, cals, quantity;
                string name, category, desc;
                double price;
                string json = $"{{\"foodId\": {foodId}, \"Name\":{name}, \"Category\":{category}, \"Price\":{price}, \"Quantity\":{quantity}, \"NutStatsCal\":{cals}, \"Description\":{desc}}}";
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync(apiUrl, content);

                if (response.IsSuccessStatusCode) {
                    Console.WriteLine("Inventory successfully updated in Inventory Management System!");
                    FoodItem food = new FoodItem(foodId,name,category, price, quantity, cals, desc, "\\src\\testimage.jpg");
                    menu.Items.Add(food);
                    return true;
                }

                Console.WriteLine($"Inventory API returned error: {response.StatusCode}");
            } catch (Exception ex) {
                Console.WriteLine($"Failed to update inventory: {ex.Message}");
            }

            return false;
        }

    }
}
