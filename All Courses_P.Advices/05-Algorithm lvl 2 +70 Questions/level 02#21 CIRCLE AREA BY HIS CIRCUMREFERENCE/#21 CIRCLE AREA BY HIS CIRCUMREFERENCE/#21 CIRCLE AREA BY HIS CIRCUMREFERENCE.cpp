#include <iostream>
#include <cmath>
using namespace std;
const float pi = 3.141592653589793238;
float readInfo()
{
    // A= CONTROVESY IS THE CIRCLE CIRCUMREFERENCE
    float A;
    cout << "enter  the circle circumference\n";
    cin >> A;
    return A;
}
float calculateArea(float A)
{
    float area = pow(A, 2) / (4*pi);
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