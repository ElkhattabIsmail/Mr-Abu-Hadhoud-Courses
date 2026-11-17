
#include <iostream>
#include <vector>

using namespace std;

int main()
{
	vector <int> numbers{ 1 , 2 , 3 , 4 , 5 ,10};

	cout << "\nusing ranged for loop : \n\n";
	for (const int& num : numbers)
	{
		cout << num << endl;
	}

	//change value befor looping
	numbers.at(0)=10;
	numbers.at(1)=20;
	numbers.at(2)=30;
	numbers.at(3)=40;
	numbers.at(4)=50;
	numbers.at(5)=60;
	cout << "\nupdate vectors : \n\n";
	for (int& num : numbers)
	{
		cout << num << endl;
	}

	cout << numbers.at(4) << endl;
	// or 
	cout << numbers[0] << endl;

	int howmanyelement = 0;
	cout << "\nchoose how many element you want to enter : ";
	cin >> howmanyelement;

	for (int i = 0; i < howmanyelement; i++)
	{
		cout << "enter element " << i + 1 << " : ";
		cin>> numbers.at(i) ;
	}
	cout << "\nelements that you enter are: \n";
	for (int i = 0; i < howmanyelement; i++)
	{
		cout << "enter element " << i + 1 << " : ";
		cout << numbers.at(i)<<endl;
	}
}
