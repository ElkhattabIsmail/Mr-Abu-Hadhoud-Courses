#include <iostream>
using namespace std;

class clsA
{

public:
    int var;
    static int counter;

    clsA()
    {
        counter++;
    }

    void Print()
    {
        cout << "\nvar     = " << var << endl;
        cout << "counter = " << counter << endl;
    }
    static int Function1()
    {
        return 10;
    }

    int Function2()
    {
        return 20;
    }
};

int clsA::counter = 0; //static variable initialisation outside the class



int main()
{

    //The following line calls static function directly via class no throught the object
    //At class level you can call only static methods and static members
    cout << clsA::Function1() << endl;

    //static methods can also be called throught the object.
    clsA A1, A2, A3;
    cout << A1.Function1() << endl;
    cout << A1.Function2() << endl;
    cout << A2.Function1() << endl;
    

    A1.var = 10;
    A2.var = 20;
    A3.var = 30;

    A1.Print();
    A2.Print();
    A3.Print();


    A1.counter = 500;

    cout << "\nafter chaning the static member counter in one object:\n";

    A1.Print();
    A2.Print();
    A3.Print();


}
