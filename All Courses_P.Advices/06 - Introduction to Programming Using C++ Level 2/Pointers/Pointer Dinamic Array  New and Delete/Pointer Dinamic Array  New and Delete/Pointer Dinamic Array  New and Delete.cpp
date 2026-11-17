
#include<iostream>

using namespace std;

int main() { 

	int num;     
	cout << "Enter total number of students: ";     
	cin >> num;

	
	float * ptr; // memory allocation of num number of floats


	ptr = new float[num];  

	// read grades from user
	cout << "Enter grades of students." << endl;

	for (int i = 0; i < num; i++) {
		cout << "Student" << i + 1 << ": ";         
		cin >> *(ptr + i);     
	}    

	// print grades that user enter
	cout << "\nDisplaying grades of students." << endl;

	for (int i = 0; i < num; i++) {         
		cout << "Student" << i + 1 << ": " << *(ptr + i) << endl ;    
	} 
	// ptr memory is released

	delete[] ptr;

	return 0;

}