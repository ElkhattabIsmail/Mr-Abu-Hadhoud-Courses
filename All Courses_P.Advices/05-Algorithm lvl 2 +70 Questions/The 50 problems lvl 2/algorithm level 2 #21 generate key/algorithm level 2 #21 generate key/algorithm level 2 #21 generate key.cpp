#include <string>
#include <iostream>
#include <cstdlib>
using namespace std;
// 65 to 90 print A TO Z
// 97 TO 122 PRINT SMALL a to 
// int c;    convert int to enum
//enCountryChoice Coutnry;
//cin >> c;
//Coutnry = (enCountryChoice)c;
int readNumber(string message)
{
    int number=0;
    do
    {
        cout << message << endl;
        cin >> number;
    } while (number <= 0);
    return number;
}
int randomNumber(int from, int to)
{
    //Function to generate a random number

    int  randNum = rand() % (to - from + 1) + from;
    return randNum;
}
string get16randkey()
{
    string key = "";
    for (int i = 1; i <= 4 ; i++)
    {
        key += char(randomNumber(65, 90));
        key += char(randomNumber(65, 90));
        key += char(randomNumber(65, 90));
        key += char(randomNumber(65, 90));
        if (i == 4)
            continue;
        key += "-";
    }
    return key;
}
string spaceFix(int i)
{

    if (i < 10)
        return " : ";
    else
        return ": ";
}
void printAllKeys(int number)
{
    cout << endl;
    for (int i = 1; i <= number; i++)
    {
        cout << "key[" << i << "]"<< spaceFix(i) << get16randkey() << endl;
        
    }
}

int main()
{
    srand((unsigned)time(NULL));
   
    //cout << get16randkey();
    int number = readNumber("enter a positive number please");
    printAllKeys(number);
    return 0;
}
