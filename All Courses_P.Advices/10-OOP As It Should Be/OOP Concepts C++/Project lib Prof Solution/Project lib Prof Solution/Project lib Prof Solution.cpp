

#include <iostream>
#include "clsString.h"
using namespace std;
int main()
{
    clsString S1("ismail elkhattab");
    cout << S1.GetValue() <<endl;
    string arrofS[] = { "ismail","elkhattab","salary : 22000" , "f.b.s" ,"ko"};
    short n = size(arrofS);
    cout << clsString::JoinString(arrofS,n, "  |  ");

    clsString S2;

   
}
