#include <string>
#include <iostream>
using namespace std;

struct stinfo
{
	int age;
	bool has_a_driverlicence;
	bool has_recomendation;
};
stinfo readinfo()
{
	stinfo info;
	cout << "pls enter your age?\n";
	cin >> info.age;
	cout << "do you have a driver licence?\n";
	cin >> info.has_a_driverlicence;
	cout << "do you have a recomendation?\n";
	cin >> info.has_recomendation;
	return info;
}
bool is_accepted(stinfo info)
{
	if (info.has_recomendation)
		return true;
	else
	return (info.age >= 21 && info.has_a_driverlicence);
}
void printinfo(stinfo info)
{
	if (is_accepted(info))
		cout << "\n hired\n";
	else
		cout << "\n rejected\n";
}
int main()
{
	printinfo(readinfo());
	return 0;
}

