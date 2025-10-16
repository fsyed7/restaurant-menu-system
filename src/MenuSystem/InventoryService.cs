using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MenuSystem.Services
{
    public class InventoryService
    {
        private static readonly HttpClient client = new HttpClient();

        // Update stock in the Inventory Management System
        public async Task UpdateStockAsync(int foodId, int quantitySold)
        {
            try
            {
                string json = $"{{\"foodId\": {foodId}, \"quantitySold\": {quantitySold}}}";
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                // Inventory Team’s real endpoint
                string apiUrl = "";

                HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine(" Inventory successfully updated in Inventory Management System!");
                }
                else
                {
                    Console.WriteLine($" Inventory API returned error: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($" Failed to update inventory: {ex.Message}");
            }
        }
    }
}
