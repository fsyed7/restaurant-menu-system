using System.Collections.Generic;
using System.Threading.Tasks;
using MenuSystemUI.Models;

namespace MenuSystemUI.Services
{
    public interface IMenuDataService
    {
        Task<List<Menu>> GetMenusAsync();
        Task<FoodItem?> GetFoodByIdAsync(int id);
    }
}
