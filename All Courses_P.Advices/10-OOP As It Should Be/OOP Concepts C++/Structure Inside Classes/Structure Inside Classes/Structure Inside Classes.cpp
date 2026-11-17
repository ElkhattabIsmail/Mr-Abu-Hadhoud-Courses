//ProgrammingAdivces.com
//Mohammed Abu-Hadhoud
#include<iostream>
using namespace std;

class clsPerson {

    struct stAddress
    {
        string _AddressLine1;
        string _AddressLine2;
        string _City;
        string _Country;
    };

public:
    string PFullName ;
    /*void setPFullName(string FullName)
    {
        PFullName = FullName;
    }
    string FullName(string FullName)
    {
        return FullName;
    }*/
    stAddress Address;

    clsPerson(string AddressLine1 , string AddressLine2 ,string City,string Country) // constructor 
    {
        Address._AddressLine1 = AddressLine1;
        Address._AddressLine2 = AddressLine2;
        Address._City = City;
        Address._Country = Country;
       
    }
  
    void PrintAddress()
    {
        cout << "\nAddress:\n";
        cout << Address._AddressLine1 << endl;
        cout << Address._AddressLine2 << endl;
        cout << Address._City << endl;
        cout << Address._Country << endl;
    }
    
};

int main()

{
    
    clsPerson Person1( "508","FBS","fkih ben saleh","Morrocco");
    Person1.PrintAddress();
    
    
    system("pause>0");
    return 0;
}