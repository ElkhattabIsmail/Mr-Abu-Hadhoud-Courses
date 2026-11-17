
#include <iostream>
using namespace std;

class Cls_Employee
{
private:
        int _ID ;
        string  _FirstName ;
        string  _LastName   ;
        string  _Title      ;
        string  _Email;
        string  _Phone     ;
        string  _Salary     ;
        string  _Department ;
       
        
public:
    Cls_Employee()
    {

    };
    Cls_Employee(int ID, string FirstName, string LastName, string Title, string  Email, string Phone, double Salary, string Department)
    {
        _ID = ID;
        _FirstName = FirstName;
        _LastName = LastName;
        _Title = Title;
        _Email = Email;
        _Phone = Phone;
        _Salary = Salary;
        _Department = Department;
    }
    //Read Only Property
    int ID()
    {
        return _ID;
    } //Property Set
    void setFirstName(string FirstName)
    {
        _FirstName = FirstName;
    } //Property Get

    string FirstName()
    {
        return _FirstName;
    }
    //Property Set
    void setLastName(string LastName)
    {
        _LastName = LastName;
    }
    //Property Get
    string LastName()
    {
        return _LastName;
    }
    //Property Set
    void setEmail(string Email)
    {
        _Email = Email;
    }
    //Property Get
    string Email()
    {
        return _Email;
    }
    //Property Set 
    void setPhone(string Phone)
    {
        _Phone = Phone;
    }
    //Property Get
    string Phone()
    {
        return _Phone;
    }
    string FullName()
    {
        return _FirstName + " " + _LastName;
    }
    void SendEmail(string subject, string message)
    {
        cout << "\nThe Following Message Sent Seccssecfully To Email : " << _Email << endl;
        cout << "Subject : " << subject << endl;
        cout << "Message : " << message << endl;
    }
    void SendSMS(string SMS)
    {
        cout << "\nThe Following SMS Sent Seccssecfully To Phone : " << _Phone << endl;
        cout << endl << SMS << endl;
    }
    void Print()
    {
        cout << "Employee Info:\n";
        cout << "_____________________________________\n";
        cout << "Id        : " << _ID << endl;
        cout << "FirstName : " << _FirstName << endl;
        cout << "LastName  : " << _LastName << endl;
        cout << "Title  : " << _Title << endl;
        cout << "FullName  : " << FullName() << endl;
        cout << "Email     : " << _Email << endl;
        cout << "Phone     : " << _Phone << endl;
        cout << "Departement  : " << _Department << endl;
        cout << "_____________________________________\n";
    }
};

class Cls_User : public Cls_Employee
{

};
int main()
{
    //Cls_Employee Employee1(150, "Smail", "kha", "New Programmer", "smail@gmail.com", "0655475942",6000, "Fib");
    //Employee1.Print();

    //cout <<"\n" << Employee1.ID() << endl;

    //Employee1.SendEmail("Test", "IS that Method Work ?");

    //// You Can Modify Any Data From Set Method
    //Employee1.setEmail("elhattab20@gmail.com");
    Cls_User user1;
    user1.setFirstName("Kabor");
    user1.setLastName("Tibari");
    user1.Print();
}

