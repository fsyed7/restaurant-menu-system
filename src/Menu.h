#ifndef MENU_H
#define MENU_H

#include <string>
#include <vector>
#include "FoodItem.h"

class Menu {
private:
    std::string type;
    std::vector<FoodItem> items;

public:
    // Constructor
    Menu(std::string t);

    // Methods
    void addItem(const FoodItem& item);
    void showMenu() const;
};

#endif
