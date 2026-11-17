#pragma once

#include <string>
#include <iostream>
#include "clsDate.h"
#include "clsPeriod.h"

using namespace std;

class clsInputValidate
{

	
public:
	short Day = 1;
	short Month = 1;
    short Year = 1900;
	static bool IsNumberBetween(int num, int from, int to)
	{
		return (num >= from && num <= to);
	}
	static bool IsNumberBetween(double num, double from, double to)
	{
		return (num >= from && num <= to);
	}
	static bool IsShortNumberBetween(short num, short from, short to)
	{
		return (num >= from && num <= to);
	}
	static bool IsDateBetween(clsDate Date, clsDate DateFrom, clsDate DateTo)
	{
		if (clsDate::IsDate1AfterDate2(DateFrom, DateTo))
		{
			clsDate::SwapDates(DateFrom, DateTo);
		}
		return (clsDate::IsDate1AfterDate2(Date, DateFrom) && clsDate::IsDate1BeforeDate2(Date, DateTo));
	}
	static int ReadIntNumber(string ErrorMessage = "Invalid Number, Enter again\n")
	{
		int Number;
		while (!(cin >> Number)) {
			cin.clear();
			cin.ignore(numeric_limits<streamsize>::max(), '\n');
			cout << ErrorMessage;
		}
		return Number;
	}

	static int ReadIntNumberBetween(int From, int To, string ErrorMessage = "Number is not within range, Enter again:\n")
	{
		int Number = ReadIntNumber();

		while (!IsNumberBetween(Number, From, To))
		{
			cout << ErrorMessage;
			Number = ReadIntNumber();
		}
		return Number;
	}

	static double ReadDblNumber(string ErrorMessage = "Invalid Number, Enter again\n")
	{
		double Number;
		while (!(cin >> Number)) {
			cin.clear();
			cin.ignore(numeric_limits<streamsize>::max(), '\n');
			cout << ErrorMessage;
		}
		return Number;
	}

	static double ReadDblNumberBetween(double From, double To, string ErrorMessage = "Number is not within range, Enter again:\n")
	{
		double Number = ReadDblNumber();

		while (!IsNumberBetween(Number, From, To)) {
			cout << ErrorMessage;
			Number = ReadDblNumber();
		}
		return Number;
	}

	static bool IsValideDate(clsDate Date)
	{
		return	clsDate::IsValidDate(Date);
	}
	static string ReadString()
	{
		string str = "";
		getline(cin >> ws, str);
		return str;
	}
	static float ReadFloatNumber()
	{
		float fl = 0;
		cin >> fl;
		return fl;
	}
	static short ReadShortNumber()
	{
		short Sr = 0;
		cin >> Sr;
		return Sr;
	}
	static short ReadShortNumberBetween(short From, short To, string ErrorMessage = "Number is not within range, Enter again:\n")
	{
		short Number = ReadShortNumber();

		while (!IsShortNumberBetween(Number, From, To)) {
			cout << ErrorMessage;
			Number = ReadShortNumber();
		}
		return Number;
	}
};

