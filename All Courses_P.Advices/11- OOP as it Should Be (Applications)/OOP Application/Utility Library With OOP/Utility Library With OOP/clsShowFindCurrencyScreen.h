#pragma once
#include "clsScreen.h"
#include "clsCurrency.h"
#include "clsInputValidate.h"




class clsShowFindCurrencyScreen : protected clsScreen
{
private:
	static void _PrintCurrency(clsCurrency Currency)
	{
		cout << "\nCurrency Card:\n";
		cout << "_____________________________\n";
		cout << "\nCountry    : " << Currency.Country();
		cout << "\nCode       : " << Currency.CurrencyCode();
		cout << "\nName       : " << Currency.CurrencyName();
		cout << "\nRate(1$) = : " << Currency.Rate();

		cout << "\n_____________________________\n";

	}

	static void _ShowResults(clsCurrency Currency)
	{
		if (!Currency.IsEmpty())
		{
			cout << "\nCurrency Found :-)\n";
			_PrintCurrency(Currency);
		}
		else
		{
			cout << "\nCurrency Was not Found :-(\n";
		}
	}
public:
	static void ShowFindCurrencyScreen()
	{
		char Answer = 'Y';
		do
		{
			system("cls");
			_DrawScreenHeader("\t  Find Currency Screen");

			cout << "\nFind By: [1] Code or [2] Country ? ";
			short Ans = 1;

			cin >> Ans;

			if (Ans == 1)
			{
				string CurrencyCode;
				cout << "\nPlease Enter CurrencyCode: ";
				CurrencyCode = clsInputValidate::ReadString();
				clsCurrency Currency = clsCurrency::FindByCode(CurrencyCode);
				_ShowResults(Currency);
			}
			else
			{
				string Country;
				cout << "\nPlease Enter Country Name: ";
				Country = clsInputValidate::ReadString();
				clsCurrency Currency = clsCurrency::FindByCountry(Country);
				_ShowResults(Currency);
			}
			cout << "\nDo you Want to Find More Currencies ? ";
			cin >> Answer;
		} while (Answer == 'Y' || Answer == 'y');

	};
};
