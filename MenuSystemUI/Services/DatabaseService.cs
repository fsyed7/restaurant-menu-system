using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace MenuSystemUI.Services
{
    public class DatabaseService
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task GetMenusAndItemsAsync()
        {
            // In future: call Database team's API.
            string apiUrl = ""; // TODO: replace with real endpoint

            if (string.IsNullOrWhiteSpace(apiUrl))
            {
                Console.WriteLine("[DatabaseService] No API configured yet. Using in-memory menus.");
                await Task.CompletedTask;
                return;
            }

            try
            {
                var response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Retrieved menu and food item data successfully.");
                    Console.WriteLine($"Raw JSON Response: {json}");
                }
                else
                {
                    Console.WriteLine($"Database API returned error: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to retrieve menus: {ex.Message}");
            }
        }
    }
}
