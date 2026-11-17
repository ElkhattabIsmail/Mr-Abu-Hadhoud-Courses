#include<iostream>
using namespace std;
int ReadPositiveNumber(string Message)
{
	int Number = 0;
	do
	{
		cout << Message << endl;
		cin >> Number;
	} while (Number <= 0);
	return Number;  //12321
}

int numberReversed(int Number)
{
	//12321 for ex
	int Remainder = 0, Number2 = 0;
	while (Number > 0)
	{
		// 5 iterations                        loop 1       loop 2     loop 3   loop 4     loop 5
		Remainder = Number % 10;               // 1           2         3        2           1
		Number = Number / 10;		          // 1232  	     123       12        1           0
		Number2 = Number2 * 10 + Remainder;   // 1           12        123      1232       12321    
		
		
		// first we take the reversed digits as a number
		// not a group of digits!
	}
	return Number2;
}




bool if_palindrome(int number)
{
	return number == numberReversed(number);
}

int main()
{
	int Number = ReadPositiveNumber("Please enter the a number?");
	if (if_palindrome(Number))
		cout << "\nyes is palindrome\n";
	else
		cout << "\nNo it's not a palindrome\n";
}