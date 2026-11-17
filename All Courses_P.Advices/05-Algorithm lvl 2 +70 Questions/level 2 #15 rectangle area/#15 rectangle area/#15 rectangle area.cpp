#include <iostream>
using namespace std;
void readnums(float& leng, float& width)
{
    cout << "enter length of rectangle:\n";
    cin >> leng;
    cout << "enter width of rectangle:\n";
    cin >> width;
}
float calculateArea(float leng, float  width)
{
    return leng * width;
}
void printArea(float area) //variable from my choice it take a float value as a parameter "dry"
{
    cout << "\nthe total area of that rectangle is " << area<<" meter"<<endl;
}

int main()
{
    float leng, width;
    readnums(leng, width);
    //calculateArea(leng, width);
    printArea(calculateArea(leng, width));
}

