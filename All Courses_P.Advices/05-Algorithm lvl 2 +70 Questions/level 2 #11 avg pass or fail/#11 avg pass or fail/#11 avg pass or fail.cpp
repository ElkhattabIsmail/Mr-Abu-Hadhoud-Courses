
#include <iostream>
using namespace std;
int main()
{
	int mark1, mark2, mark3;
	cout << "enter your 3 mark pls :\n";
	cin >> mark1 >> mark2 >> mark3;
	int avg=(mark1+mark2+mark3)/3;
	cout <<"your average is:"<< avg << endl;
	if (avg >= 50)
	{
		cout << "pass\n";
	}
	else if (avg <= 0)
	{
		cout << "average must be larg than 0\n";
	}
	else
	{
		cout << "fail\n";
	}
}
