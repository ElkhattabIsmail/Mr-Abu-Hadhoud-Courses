#include <iostream>
#include <cmath>
using namespace std;
const float pi = 3.141592653589793238;
struct    strinfo
{
    float a;
    float b;
};
strinfo readInfo()
{
    
    strinfo info;
    cout << "enter  the first value\n";
    cin >> info.a;           
    cout << "enter  the src value\n";
    cin >> info.b;
    return info;
}
float calculateArea(strinfo info)
{
    float ab = (2 * info.a - info.b) / (2 * info.a + info.b);
    float area = pi*(pow(info.b,2)/4)* ab;
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