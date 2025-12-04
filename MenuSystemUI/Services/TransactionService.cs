using System.Net.Http;
using System.Threading.Tasks;
using System;
using MenuSystemUI.Models;

namespace MenuSystemUI.Services
{
    public class TransactionService
    {

        private readonly HttpClient _http;

        public TransactionService(HttpClient http)
        {
            _http = http;
        }

        public async Task<bool> AddTransactionAsync(IReadOnlyList<CartItem> items)
        {
            string contentstring = "/add_transaction/";
            foreach (CartItem item in items) {
                string safeFood = Uri.EscapeDataString(item.Name);
                string safeSource = Uri.EscapeDataString("menu");
                contentstring += $"{item.UnitPrice}/{safeFood}/{safeSource}/";
            }

            string url = "/transactions"; //TO DO add endpoint
            HttpContent content = new StringContent(contentstring);

            try
            {
                var response = await _http.PostAsync(url,content);
                
                return response.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }
        }
    }
}
