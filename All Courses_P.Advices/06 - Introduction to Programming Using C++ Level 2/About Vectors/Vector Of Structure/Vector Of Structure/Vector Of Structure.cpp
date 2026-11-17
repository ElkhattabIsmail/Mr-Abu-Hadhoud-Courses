
#include <iostream>
#include <string>
#include <vector>
#include <iomanip>

using namespace std;

struct strEmployee
{
    string FirstName = "";
    string LastName = "";
    long salary = 0;
};

void ReadAndFillStructInfo(strEmployee& infos)
{
    cout << "Enter the first name of the employee: ";
    cin>> infos.FirstName;
    cout << "\nEnter the last name of the employee: ";
    cin >> infos.LastName;
    cout << "\nEnter the employee's salary: ";
    cin >> infos.salary;
}

void readEmployeeInfo(vector<strEmployee>& employees)
{
    strEmployee infos;
    char again = 'y';
    while (again == 'y' || again == 'Y')
    {
        ReadAndFillStructInfo(infos);
        employees.push_back(infos);

        cout << "\nDo you want to add more employees? (y/n): ";
        cin >> again;
        cout << endl;
    }
}

void printEmployee(vector<strEmployee>& employees)
{
    cout << "                ----------------------\n";
    cout << "                   Employee Roster\n";
    cout << "                ----------------------\n";
    cout << "--------------------------------------------------\n";                
    cout << "|  First Name   |   Last Name   |      salary    |\n";                
    cout << "--------------------------------------------------\n";
    for (strEmployee& employeeInfo : employees)
    {
        cout << "| " << setw(14) << employeeInfo.FirstName << "| " << setw(14) << employeeInfo.LastName <<
            "| " << setw(14) << employeeInfo.salary <<" |    " << endl;
        cout << endl;
    }
    strEmployee employeeInfo;
    cout << "| " << setw(14) << employeeInfo.FirstName << "| ";
    cout << "--------------------------------------------------\n";
}

int main()
{
    vector<strEmployee> employees;
    readEmployeeInfo(employees);
    printEmployee(employees);

    return 0;
}
