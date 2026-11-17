
#include <iostream>
using namespace std;

int main()
{
	float toatla_sales;
	cout << "enter the total of sales that you want:\n";
	cin>> toatla_sales;
	if (toatla_sales > 1000000)
	{
		cout << "your commission is:" << toatla_sales * 0.01 << "\n";
	}
	else if (toatla_sales>500000)
	{
		cout << "your commission is: " << toatla_sales * 0.02 << "\n";
	}
	else if (toatla_sales > 100000)
	{
		cout << "your commission is:" << toatla_sales * 0.03 << "\n";
	}
	else if (toatla_sales > 50000 )
	{
		cout << "your commission is:" << toatla_sales * 0.05 << "\n";
	}
	else
	{
		cout << "your total sales without commission: " << toatla_sales;
	}
}
