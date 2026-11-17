#include <string>
#include <iostream>
using namespace std;
enum enchecknum { odd =1 , even =2 };

int readnumber()
{
    int num;
    cout << "enter a number pls:\n";
    cin >> num;
    while (num <= 0)
    {
        cout << "*************************************\n";
        cout << "enter A POSITIVE number please !\n";
        cout << "try to enter a number grater than 0 ?\n";
        cout << "*************************************\n";
        cout << "\nenter a number pls:\n";
        cin >> num;
    }
    return num;
}
 enchecknum checknumber(int num)
 {
    if (num % 2 == 0)
        return enchecknum::even;
    else
        return enchecknum::odd;
}
 void printnumbertype(enchecknum checknum)
 {
     if (checknum == enchecknum::odd)
         cout << "\n it's a odd number \n";
     else
         cout << "\nit's a even number\n";
 }
int main()
{
    printnumbertype(checknumber(readnumber()));
}
