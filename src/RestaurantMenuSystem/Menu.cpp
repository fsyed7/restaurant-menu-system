#include "Menu.h"
#include <iostream>
using namespace std;

Menu::Menu(string t) : type(t) {}

void Menu::addItem(FoodItem f) {
    items.push_back(f);
}

void Menu::showMenu() const {
    cout << "--- " << type << " Menu ---" << endl;
    for (const auto& item : items) {
        item.display();
    }
}
