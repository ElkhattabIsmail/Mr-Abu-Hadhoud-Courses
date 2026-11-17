#include <iostream>
#include <cmath>
using namespace std;
void readinfo(float& base, float& h)
{
    cout << "enter  base value of rectangle:\n";
    cin >>base;
    cout << "enter the heigth of rectangle:\n";
    cin >> h;
}
float calculateArea(float base, float h)
{
    float area = (base/2) *h;
    return area;
}
void printArea(float area) //variable from my choice it take a float value as a parameter "dry"
{
    cout << "\nthe total area of triangle is " << area << " meter" << endl;
}

int main()
{
    float base,h;
    readinfo(base, h);
    //calculateArea(leng, width);
    printArea(calculateArea(base, h));
}
