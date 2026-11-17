// #37 sum until -99.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;

int main()
{
    int num;
    cout << "ENTER THE NUMBER :\n";
    cin >> num;
    int sum = 0;
    while (num != -99)
    {
        sum += num;
        cout << "ENTER THE NUMBER :\n";
        cin >> num;
    }
    cout << "total is :" << sum << endl;
}
