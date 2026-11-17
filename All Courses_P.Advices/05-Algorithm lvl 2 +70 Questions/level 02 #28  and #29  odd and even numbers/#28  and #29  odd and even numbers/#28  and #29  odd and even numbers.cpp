#include <iostream>
using namespace std;

enum encheck { odd = 1, even = 2, all = 100 };

int readnumber()
{
    int number;
    cout << "enter a number:\n";
    cin >> number;
    return number;
}
encheck num_type(int number)
{
    if (number % 2 == 0)
        return encheck::even;
    else if (number % 2 != 0)
        return encheck::odd;
    else
        return encheck::all;

}
void sumofoddbyforloop(int number)
{
    int sum = 0;
    for (int b = 1; b <= number; b++)
    {
        if (num_type(b) == encheck::even)
            sum += b;
    }
    cout << "the sum of odd number from 1 to " << number << " by using for loop is " << sum << "." << endl;
}
void sumofoddbywhileloop(int number)
{
    int sum = 0;
    int b = 1;

    while (b <= number)
    {
        if (num_type(b) == encheck::even)
            sum = sum += b;
        b++;
    }
    cout << "the sum of odd number from 1 to " << number << " by using while loop is " << sum << "." << endl;
}
int sumofoddbyDOwhileloop(int number)
{
    int sum = 0;
    int b = 1;
    cout << "the sum of odd number from 1 to " << number << " by using DO while is ";
    do
    {

        if (num_type(b) == encheck::even)
        {
            sum += b;
        }
        b++;
    } while (b <= number);
    return sum;
}

int main()
{
    int number = readnumber();
    sumofoddbyforloop(number);
    sumofoddbywhileloop(number);
    cout << sumofoddbyDOwhileloop(number);
}
