#include <iostream>
using namespace std;
enum enresult { pass = 1, fail = 0 };
int readmark()
{
    int mark;
    cout << "enter your mark pls: \n";
    cin >> mark;
    return mark;

}
enresult checkmark(int mark)
{
    if (mark >= 50)
        return enresult::pass;
    else
        return enresult::fail;
}
void printresult(int mark)
{
    if (checkmark(mark) == enresult::pass)
        cout << "\npass\n";
    else
        cout << "\nfail\n";
}
int main()
{
    printresult(readmark());
}
