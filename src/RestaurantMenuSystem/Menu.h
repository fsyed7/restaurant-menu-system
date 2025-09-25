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
    Menu(std::string t);
    void addItem(FoodItem f);
    void showMenu() const;
};

#endif
