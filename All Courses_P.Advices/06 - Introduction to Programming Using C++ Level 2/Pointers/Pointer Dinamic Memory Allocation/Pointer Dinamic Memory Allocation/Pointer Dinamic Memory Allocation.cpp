#include<iostream>

using namespace std; 

int main() {
	
	// declare an int pointer
	int* ptrX;
	int* ptrNewX;
	float* ptrSUM;
	// declare a float pointer
	float* ptrY; // dynamically allocate memory 

	ptrX = new int;
	ptrNewX = new int;
	ptrY = new float; // assigning value to the memory
	ptrSUM = new float;

	*ptrX = 10;
	*ptrNewX = 80;
	*ptrY = 10.00F; 
	*ptrSUM = *ptrX + *ptrNewX + *ptrY;

	cout << *ptrX << endl;
	cout << *ptrNewX << endl;
	cout << *ptrY << endl; // deallocate the memory
	cout << "sum of all values = " << *ptrSUM << endl;

	delete ptrSUM;
	delete ptrNewX;
	delete ptrX; 
	delete ptrY;

	return 0;
}