#include <iostream>
using namespace std;
void read_numbers(int& num1, int& num2)
{
    cout << "enter num 1:\n";
    cin >> num1;
    cout << "enter num 2:\n";
    cin >> num2;
}
void swap_numbers(int& num1, int& num2)
{
    int temp;
    temp=num1;
    num1 = num2;
    num2 = temp;
}
void printnums(int num1, int num2)
{
    cout << num1 << endl;
    cout << num2 << endl;
}
int main()
{
    int num1, num2;
    read_numbers(num1, num2);
    cout << "********\n";
    printnums(num1,num2);
    cout << "********\n";
    swap_numbers(num1, num2);
    printnums(num1, num2);

}
