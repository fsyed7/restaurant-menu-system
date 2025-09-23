#ifndef NUTRITIONSTATS_H
#define NUTRITIONSTATS_H

class NutritionStats {
private:
    int calories;
    double protein;
    double fat;
    double carbs;

public:
    // Constructor
    NutritionStats(int cal, double pro, double f, double carb);

    // Getters
    int getCalories() const;
    double getProtein() const;
    double getFat() const;
    double getCarbs() const;
};

#endif
