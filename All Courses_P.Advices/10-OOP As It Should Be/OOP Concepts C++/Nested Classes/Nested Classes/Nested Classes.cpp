
#include<iostream>
#include<string>
#include "clsPerson.h"
#include "ReadText.cpp"

using namespace std;


int main()

{    
    string FullName = ReadText("Enter Your Full Name Pls");
    string country = ReadText("Enter Your country Name Pls");
    string Building = ReadText("Enter Your Building Number Pls");
    string Street = ReadText("Enter Your Street Name Pls");
    string city = ReadText("Enter Your city Name Pls");

    clsPerson Person1 ( country, Building, Street, city, FullName);

    cout << endl << Person1.FullName();

    Person1.Address.Print();

    system("pause>0");
    return 0;
}