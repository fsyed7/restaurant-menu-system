#include "NutritionStats.h"

NutritionStats::NutritionStats(int cal, double p, double f, double c)
    : calories(cal), protein(p), fat(f), carbs(c) {
}

int NutritionStats::getCalories() const { return calories; }
double NutritionStats::getProtein() const { return protein; }
double NutritionStats::getFat() const { return fat; }
double NutritionStats::getCarbs() const { return carbs; }
