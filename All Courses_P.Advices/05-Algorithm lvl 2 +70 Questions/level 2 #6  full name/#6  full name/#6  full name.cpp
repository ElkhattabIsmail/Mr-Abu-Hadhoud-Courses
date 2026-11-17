#include <iostream>
#include <string>
using namespace std;
struct fullname
{
    string firstname;
    string lastname;
};
fullname readfullname()
{
    fullname info;
    cout << "entre your first name?\n";
    getline (cin,info.firstname);

    cout << "entre your last name?\n";
    cin >> info.lastname;
    return info;
}
string getfullname(fullname info ,bool rev)
{
    string name;
    if (rev)
        return info.lastname + " " + info.firstname;
    else
    name = info.firstname + " " + info.lastname;
    return name;
}
void printfullname(string name)
{
    cout << "your name is " << name << endl;
}
int main()
{
    printfullname(getfullname(readfullname(), false));
}

