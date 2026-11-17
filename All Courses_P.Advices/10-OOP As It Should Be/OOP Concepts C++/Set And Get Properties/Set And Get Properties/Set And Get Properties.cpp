#include<iostream>

using namespace std; 

class clsPerson
{ 
private: 
string _FirstName; 
string _LastName;

public: 
//Property Set
void setFirstName(string FirstName)
{      
	_FirstName = FirstName;    
} 
//Property Get
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
string FullName()    
{
	return _FirstName + " " + _LastName;  
} 
};

class Cls_Calculation
{
private:
	int _Number1;
	int _Number2;

public:
	void SetNumber1(int Number1)
	{
		_Number1 = Number1;
	}
	int GetNumber1()
	{
		return _Number1;
	}

	void SetNumber2(int Number2)
	{
		_Number2 = Number2;
	}
	int GetNumber2()
	{
		return _Number2;
	}
	int SumOfTwoNumber()
	{
		return _Number1 + _Number2;
	}
};
int main() { 

	Cls_Calculation Calculation;

	Calculation.SetNumber1(7);
	Calculation.SetNumber2(33);

	cout << "Number 1 is : " << Calculation.GetNumber1() << endl;
	cout << "Number 2 is : " << Calculation.GetNumber2() << endl;

	cout << "\nSum Of Two Numbers is : " << Calculation.SumOfTwoNumber() << endl;



	   

	system("pause>0");
	return 0; 
}