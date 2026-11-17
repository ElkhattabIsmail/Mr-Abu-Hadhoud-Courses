
#include <iostream>
using namespace std;

int main()
{
    int a[2][2] = { {1,2}
                ,{3,4} };

    // to access first element of the second arr
    cout << (a + 1) << endl; // last element in first block
    cout<<(*(a + 1))<< endl;// last element in first block
    cout<<(*a) << endl;
    cout<<( a) << endl;


    cout<<("%u", a[0]);

}

