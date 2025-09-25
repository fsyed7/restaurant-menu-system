#include "FoodItem.h"
#include <iostream>
using namespace std;

FoodItem::FoodItem(string n, string c, double p, int q, NutritionStats ns)
    : name(n), category(c), price(p), quantity(q), nutrition(ns) {
}

string FoodItem::getName() const { return name; }
string FoodItem::getCategory() const { return category; }
int FoodItem::getQuantity() const { return quantity; }

void FoodItem::reduceQty() {
    if (quantity > 0) quantity--;
}

void FoodItem::display() const {
    cout << name << " (" << category << ") - $" << price
        << " | Qty: " << quantity
        << " | Calories: " << nutrition.getCalories()
        << " | Protein: " << nutrition.getProtein() << "g"
        << " | Fat: " << nutrition.getFat() << "g"
        << " | Carbs: " << nutrition.getCarbs() << "g"
        << endl;
}
