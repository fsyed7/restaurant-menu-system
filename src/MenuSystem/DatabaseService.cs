using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace MenuSystem.Services
{
    public class DatabaseService
    {
        private static readonly HttpClient client = new HttpClient();

        // Fetch menu and food item data from the Database System
        public async Task GetMenusAndItemsAsync()
        {
            try
            {
                //  Database Team’s real endpoint
                string apiUrl = "";

                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(" Retrieved menu and food item data successfully!");
                    Console.WriteLine($" Raw JSON Response: {json}");
                }
                else
                {
                    Console.WriteLine($" Database API returned error: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($" Failed to retrieve menus: {ex.Message}");
            }
        }
    }
}
