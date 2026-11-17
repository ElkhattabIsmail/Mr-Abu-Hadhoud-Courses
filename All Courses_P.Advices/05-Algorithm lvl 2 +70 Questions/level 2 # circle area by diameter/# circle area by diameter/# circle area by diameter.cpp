#include <iostream>
#include <cmath>
using namespace std;
const float pi = 3.141592653589793238;
float readInfo()
{
    float d;
    cout << "enter  diameter of circle:\n";
    cin >> d;
    return d;
}
float calculateArea(float d)
{
    float area = (pi*pow(d,2))/4;
    return area;
}
void printArea(float circlearea) //variable from my choice it take a float value as a parameter "dry"
{
    cout << "\nthe total area in this circle is " << circlearea << " meter" << endl;
}

int main()
{
    printArea(calculateArea(readInfo()));
    return 0;
}