#include <iostream>

using namespace std;

//Reminder !

//In C++, you cannot directly define a std::string variable
//inside a union because std::string involves dynamic
//memory allocation and deallocation, and unions in 
//C++ have limitations when it comes to non - trivial
//types, which includes types with constructors and destructors.


union MyUnion {
    int intValue;
    float floatValue;
    char charValue;
};

int main() {
    MyUnion myUnion;

    myUnion.intValue = 24;
    std::cout << "Integer value: " << myUnion.intValue << std::endl;

    myUnion.floatValue = 3.14f;
    std::cout << "Float value: " << myUnion.floatValue << std::endl;

    myUnion.charValue = 'A';
    std::cout << "Char value: " << myUnion.charValue << std::endl;

    //MyUnion n2;
    //n2.intValue = 24;
    //std::cout << "\nMy Age: " << myUnion.intValue << std::endl;

    return 0;
}
