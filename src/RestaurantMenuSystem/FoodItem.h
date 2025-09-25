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
    NutritionStats nutrition; // composition

public:
    FoodItem(std::string n, std::string c, double p, int q, NutritionStats ns);

    std::string getName() const;
    std::string getCategory() const;
    int getQuantity() const;
    void reduceQty();
    void display() const;
};

#endif

