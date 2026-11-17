#include<iostream>
#include<string>
using namespace std;

string GetElementArrays(int number)
{
    char charnum;
    string strnum = "";
    char numTOcheck;
    cout << "enter array elements:\n";
    for (int i = 1; i <= number; i++)
    {
        cout << "element[" << i << "]: ";
        cin >> charnum;
        strnum += charnum;
        strnum += " ";
    }
    return strnum;
}
int howmuch_element_Repeated(string number,char repeats)
{
    int count = 0;
    cout << endl;
    int y = number.length() - 1;//11121=5
    for (int i = 0; i <= y; i++)
    {
        if (number[i] == repeats)
            count++;
    }
    return count;
}
int ReadPositiveNumber(string Message)
{
    int Number = 0; do
    {
        cout << Message << endl;
        cin >> Number;
        cout << endl;
    } while (Number <= 0);
    return Number;
}
int main()
{
    int number = ReadPositiveNumber("enter number of elements:");
    string originalArray = GetElementArrays(number);
    originalArray;
    char repeats;
    cout << "\nenter the number you wanna check : ";
    cin>> repeats;
    cout << endl;
    cout<<"Original array: "<< originalArray<<endl;
    cout <<"Number "<< repeats << " repeated " << howmuch_element_Repeated(originalArray, repeats) << " time(s)" << endl;

    
    return 0;
}