#include<iostream>

using namespace std;


class Cls_Calculator
{
private:
	int _Number = 0;
	int _LastResult = 0;
	string _OpType = "";
	int Result = 0;

public:
	
	int Add(int Number)
	{
		_OpType = "Adding";
		_Number = Number;
		Result = _LastResult + Number ;
		_LastResult = Result;

		return Result ;
	}

	int Subtract(int Number)
	{
		_OpType = "Subtracting";
		_Number = Number;
		Result = _LastResult - Number;
		_LastResult = Result;
		return Result;
	}
	int Divide(int Number)
	{
		_OpType = "Dividing";
		if (Number == 0)
		{
			_Number = 1;
			Result = _LastResult / 1;
			_LastResult = Result;
			return Result;
		}
		_Number = Number;
		Result = _LastResult / Number;
		_LastResult = Result;
		return Result;
	}
	int Multiply(int Number)
	{
		_OpType = "Multipling";
		_Number = Number;
		Result = _LastResult * Number;
		_LastResult = Result;
		return Result;
	}
	int Clear()
	{
		_OpType = "Clear";
		Result = 0;
		_Number = 0;
		return Result;
	}

	void PrintResult()
	{
		cout << "Result After " << _OpType <<" "<< _Number << " is: " << Result << endl;
	}

	
	
};
int main() {

	Cls_Calculator Calculation1;
	Calculation1.Clear();

	Calculation1.Add(10);
	Calculation1.PrintResult();

	Calculation1.Add(100);
	Calculation1.PrintResult();

	Calculation1.Subtract(20);
	Calculation1.PrintResult();

	Calculation1.Divide(0);
	Calculation1.PrintResult();

	Calculation1.Divide(2);
	Calculation1.PrintResult();

	Calculation1.Multiply(3);
	Calculation1.PrintResult();

	Calculation1.Clear();
	Calculation1.PrintResult();

	system("pause>0");
	return 0;
}