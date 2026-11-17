
#include <iostream>

using namespace std;

class cls_Person
{
private:
    int  _ID;
    string _FirstName;
    string _LastName;
    string _FullName;
    string _Email;
    string _PhoneNumber;

public:
    // Constractor 
    cls_Person(int Id ,string FirstName, string LastName, string FullName ,string Email, string PhoneNumber)
    { 
        _ID = Id;
        _FirstName = FirstName;
        _LastName = LastName;
        _FullName = FullName;
        _Email = Email;
        _PhoneNumber = PhoneNumber;
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
        _PhoneNumber = Phone;     
    } 
    //Property Get
    string Phone()    
    {
        return _PhoneNumber;   
    }
    string FullName()    
    {
        return _FirstName + " " + _LastName;   
    }
    void SendEmail(string subject ,string message)
    {
        cout << "\nThe Following Message Sent Seccssecfully To Email : "<< _Email<<endl;
        cout << "Subject : " << subject << endl;
        cout << "Message : " << message << endl;
    }
    void SendSMS(string SMS)
    {
        cout << "\nThe Following SMS Sent Seccssecfully To Phone : " << _PhoneNumber << endl;
        cout << endl<< SMS << endl;
    }
    void Print()
    {
        cout << "Info:\n";
        cout <<"_____________________________________\n";
        cout << "Id        : " << _ID << endl;
        cout << "FirstName : " << _FirstName << endl;
        cout << "LastName  : " << _LastName << endl;
        cout << "FullName  : " << FullName() << endl;
        cout << "Email     : " << _Email << endl;
        cout << "Phone     : " << _PhoneNumber << endl;
        cout << "_____________________________________\n";
    }

};
int main()
{
    cls_Person Person1( 10,"Smail", "Elkhattab", "Elkhattab smail", "elhattab@gmail.com", "0655737946");
    Person1.Print();
    Person1.SendEmail("Hi", "Hello ! is that Code Actually Works ?");
    Person1.SendSMS("Hi You Got My SMS ?");

    cout << Person1.FullName();
    system("pause>0");
    return 0;
}
