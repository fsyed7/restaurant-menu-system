#ifndef FOODITEM_H
#define FOODITEM_H

#include <string>
#include "NutritionStats.h"

class FoodItem {
private:
    std::string name;
    std::string category;
    double price;
    int quantity;
    NutritionStats nutrition;

public:
    // Constructor
    FoodItem(std::string n, std::string c, double p, int q, NutritionStats nut);

    // Getters
    std::string getName() const;
    std::string getCategory() const;
    double getPrice() const;
    int getQuantity() const;

    // Method to reduce stock
    void reduceQty(int amount);
};

#endif
