#include<iostream>
using namespace std; 

int main() {

	void* ptr;  // pointer from type void without value 

	// define values
	float f1 = 10.5;
	int x = 50;
	bool r = true ;

	ptr = &f1;   // point to f1 address
	cout << ptr << endl;   //cout f1 address 
	cout << *(static_cast<float*>(ptr)) << endl;  // cout value of last float point 

	ptr = &x; 
	cout << ptr << endl;
	cout << *(static_cast<int*>(ptr)) << endl;

	ptr = &r;
	cout << ptr << endl;
	cout << *(static_cast<bool*>(ptr));

	return 0;
}