#include<iostream>

using namespace std;

struct str_info
{
	string fullname = "";
	short salary = 0;
};

int main() { 

	str_info info;
	str_info* Pinfo;

	info.fullname = "elkhattab smail";
	info.salary = 15000;

	Pinfo = &info;  //give pinter the address of struct &info

	cout << "call value by using Pointer:\n";
	cout << Pinfo->fullname<<endl;
	cout << Pinfo->salary<< endl<<endl;










	// declare an int pointer
	int* ptrX;

	// declare a float pointer
	float* ptrY; 

	bool* ptrR;
	// dynamically allocate memory
	 
	ptrX = new int; 
	ptrY = new float;
	ptrR = new bool;

	// assigning value to the memory 
	*ptrX = 45; 
	*ptrY = 58.35f;
	*ptrR = true;

	cout << *ptrX << endl;

	cout << *ptrY << endl;

	cout << *ptrR << endl;


	// deallocate the memory

	delete ptrX; 
	delete ptrY;
	delete ptrR;

	return 0;
}