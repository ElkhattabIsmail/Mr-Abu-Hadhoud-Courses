#pragma once

#include<iostream>
#include<string>
using namespace std;

string ReadText(string text)
{
    string n;
    cout << text << " : ";
    getline(cin, n);
    return n;
}
