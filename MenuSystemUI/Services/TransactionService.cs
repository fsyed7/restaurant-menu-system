using System.Net.Http;
using System.Threading.Tasks;
using System;

namespace MenuSystemUI.Services
{
    public class TransactionService
    {

        private readonly HttpClient _http;

        public TransactionService(HttpClient http)
        {
            _http = http;
        }

        public async Task<bool> AddTransactionAsync(double price, string foodId)
        {
            string safeFoodId = Uri.EscapeDataString(foodId);
            string safeSource = Uri.EscapeDataString("menu");

            string url = $"/add_transaction/{price}/{safeFoodId}/{safeSource}";

            try
            {
                var response = await _http.GetAsync(url);
                return response.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }
        }
    }
}
