#include<iostream>

using namespace std;

class Cls_Student
{
private:
	string _studentName;
	string _studentlastName;
	string _Address;
	short __Id = 1111;

	
public:
	void setstudentName(string studetname)
	{
		_studentName = studetname;
	}
	string GetstudentName()
	{
		return _studentName;
	}
	// Using Declaration Specefic ( = OR Cout )
	__declspec(property(get = GetstudentName, put = setstudentName)) string StudentName;

	void setstudentLastName(string studetLastname)
	{
		_studentlastName = studetLastname;
	}
	string GetstudentlastName()
	{
		return _studentlastName;
	}
	__declspec(property(get = GetstudentlastName, put = setstudentLastName)) string StudentLastName;

	void setAddress(string Address)
	{
		_Address = Address;
	}
	string GetAddress()
	{
		return _Address;
	}
	__declspec(property(get = GetAddress, put = setAddress)) string StudentAddress;

	
	string studentFullName()
	{
		return "Mr. " + _studentName + " " + _studentlastName;
	}
	short GetId()
	{
		return __Id;
	}

};
int main() {

	Cls_Student Student;

	
	Student.StudentName = "Smai3il";
	cout << "Name = " << Student.StudentName << endl;

	Student.StudentLastName = "ELKHATTAB";
	cout << "Last Name = " << Student.StudentLastName << endl;

	cout << "Full Name = " << Student.studentFullName() << endl;

	Student.StudentAddress = "FBS 508";
	cout << "Address = " << Student.StudentAddress << endl;


	cout << "\nStudent ID = " << Student.GetId() << endl;



	system("pause>0");
	return 0;
}