#include <iostream>
#include <vector>
using namespace std;

int ReadValidNumber() {
    int Number;
    cout << "Please enter a number? ";
    cin >> Number;
    while (cin.fail())  //while cin not a number   
    {
        // user didn't input a number    
        cin.clear();  // clean cin input      
        cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');  //  ignore what in input

        cout << "Invalid Number, Enter a valid one: ";
        cin >> Number;
    }

    return Number;

}
vector <int> readVectorNumbers(vector <int> &vnumbers)  // by ref is necessery
{
    char again = 'y';
    int number = 0;
    do
    {
        vnumbers.push_back(ReadValidNumber());
        cout << "\ndo you want to add more numbers: ";
        cin >> again;
    } while (again == 'y' || again == 'Y');

    return vnumbers;
}
void printVectorValue(vector <int> & vnumbers)
{
    cout << "\nVector Elements:\n" << endl;
    for (int& number : vnumbers)
    {
        cout << number << endl;
    }
}


int main() {
    
    vector <int> nums;
    readVectorNumbers(nums);
    printVectorValue(nums);

    return 0;
}