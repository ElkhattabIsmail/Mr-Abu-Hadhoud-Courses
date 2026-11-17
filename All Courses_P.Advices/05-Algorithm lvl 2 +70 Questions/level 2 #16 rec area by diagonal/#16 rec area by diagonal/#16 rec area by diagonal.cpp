#include <iostream>
#include <cmath>
using namespace std;
void readnums(float& d, float& a)
{
    cout << "enter  diagonal value of rectangle:\n";
    cin >> d;
    cout << "enter a the side length of rectangle:\n";
    cin >> a;
}
float calculateArea(float d,float a)
{
    float area= a * sqrt(pow(d,2) -pow(a,2));
    return area;
}
void printArea(float area) //variable from my choice it take a float value as a parameter "dry"
{
    cout << "\nthe total area of that rectangle is " << area << " meter" << endl;
}

int main()
{
    float a, d;
    readnums(a, d);
    //calculateArea(leng, width);
    printArea(calculateArea(d, a));
}
