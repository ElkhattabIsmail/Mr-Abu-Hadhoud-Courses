#include <iostream>
#include <string>
#include <vector>
using namespace std;
float readnumber()
{
    int number = 0;
    cout << "enter a number: \n";
    cin >> number;
    return number;
}
//       10.3 
int MYround(float number)
{
    float numberAfterPoint = number - (int)number;
    if (numberAfterPoint > 5)
        return  number + 1;
    else
        return (int)number - 1;
}

int main()
{
    float number = readnumber();
    cout << "MY round : " << MYround(number);
    cout << "\nC++ round : " << round(number);
}

