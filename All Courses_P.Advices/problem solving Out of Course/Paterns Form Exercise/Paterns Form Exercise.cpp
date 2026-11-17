

#include <iostream>
using namespace std;

// problem #1
//1
//22
//333
//4444
//55555
void pattern1()
{

	for (int i = 1; i <= 5; i++)
	{
		for (int j = 0; j < i; j++)
		{
			cout << i;
		}
		cout << endl;
	}

}
// problem #2
//1
//12
//123
//1234
//12345
void pattern2()
{
	for (int i = 1; i <= 5; i++)
	{
		for (int j = 0; j < i; j++)
		{
			cout << j + 1;
		}
		cout << endl;
	}
}
// problem #3
//1
//2 3
//4 5 6
//7 8 9 10
//11 12 13 14 15
void patt3(int n = 5)
{
	int num = 1;
	for (int i = 1; i <= n; i++)
	{
		for (int j = 0; j < i; j++)
		{
			cout << num << " ";
			num++;
		}
		cout << endl;
	}
}
// problem #4
//1
//2 1
//3 2 1
//4 3 2 1
//5 4 3 2 1
void patt4(int n = 5)
{
	for (int i = 1; i <= n; i++)
	{
		for (int j = i; j > 0; j--)
		{
			cout << j << " ";
		}
		cout << endl;
	}
}
int main()
{


}

