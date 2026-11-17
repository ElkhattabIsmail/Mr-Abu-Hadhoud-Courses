#pragma once
#include <iostream>

using namespace std;

namespace MyLibrary
{                  // 1234
	int ReversedNumber(int N)
	{
		int SecondNumber = 0, Remainder = 0;

		while (N > 0)
		{
			Remainder = N % 10;
			N = N / 10;
			SecondNumber = SecondNumber * 10 + Remainder;
		}
		return SecondNumber;
	}
}