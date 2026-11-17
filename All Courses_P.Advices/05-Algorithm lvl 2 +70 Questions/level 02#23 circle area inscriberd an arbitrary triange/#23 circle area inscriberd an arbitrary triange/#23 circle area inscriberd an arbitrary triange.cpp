#include <iostream>
#include <cmath>
using namespace std;
const float pi = 3.141592653589793238;
struct    strinfo
{
    float a;
    float b;
    float c;

};
strinfo readInfo()
{

    strinfo info;
    cout << "enter  the first value\n";
    cin >> info.a;
    cout << "enter  the src value\n";
    cin >> info.b;
    cout << "enter  the 3ed value\n";
    cin >> info.c;

    return info;
}
float calculateArea(strinfo info)
{
    float p = (info.a+ info.b + info.c) / 2;
    float s = (info.a * info.b * info.c) / ((sqrt(p * (p - info.a) * (p - info.b) * (p - info.c) ) )*4);
    float area = pi * pow(s, 2);
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