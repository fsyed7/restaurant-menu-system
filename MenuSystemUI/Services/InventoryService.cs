using MenuSystemUI.Models;
using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
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
                var response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode) {
                    string json = await response.Content.ReadAsStringAsync();
                    //TODO update to actual deserializer
                    JsonSerializer.Deserialize<Models.Menu>(json);
                    Console.WriteLine("Retrieved menu and food item data successfully.");
                    Console.WriteLine($"Raw JSON Response: {json}");
                    return true;
                } else {
                    Console.WriteLine($"Inventory API returned error: {response.StatusCode}");
                }
            } catch (Exception ex) {
                Console.WriteLine($"Failed to retrieve menus: {ex.Message}");
            }

            return false;
        }

    }
}
