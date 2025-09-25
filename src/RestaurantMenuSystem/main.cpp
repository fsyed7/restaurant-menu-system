#include <iostream>
#include "Menu.h"
#include "FoodItem.h"
#include "NutritionStats.h"
using namespace std;

int main() {
    // Create Nutrition Stats
    NutritionStats pastaNutrition(250, 10, 5, 30);
    NutritionStats burgerNutrition(400, 20, 15, 50);

    // Create Food Items
    FoodItem pasta("Pasta", "Main Course", 12.99, 10, pastaNutrition);
    FoodItem burger("Burger", "Fast Food", 9.99, 5, burgerNutrition);

    // Create Menu
    Menu dinnerMenu("Dinner");
    dinnerMenu.addItem(pasta);
    dinnerMenu.addItem(burger);

    // Show Menu
    dinnerMenu.showMenu();

    return 0;
}
