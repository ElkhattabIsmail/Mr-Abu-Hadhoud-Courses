
#include <iostream>
#include <string>
using namespace std;

string readname()
{
    string name;
    cout << "enter your name: \n";
    getline(cin, name);
    return name;
}
void printname(string name)
{
    cout << "\nyour name is: " << name;
}

int main()
{
    string Name = readname();
    printname(Name);
}

