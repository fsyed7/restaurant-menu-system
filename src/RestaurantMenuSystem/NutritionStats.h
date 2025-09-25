#ifndef NUTRITIONSTATS_H
#define NUTRITIONSTATS_H

class NutritionStats {
private:
    int calories;
    double protein;
    double fat;
    double carbs;

public:
    NutritionStats(int cal, double p, double f, double c);

    int getCalories() const;
    double getProtein() const;
    double getFat() const;
    double getCarbs() const;
};

#endif

