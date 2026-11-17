#pragma once
#include "clsScreen.h"
#include "clsCurrency.h"
#include "clsInputValidate.h"

class clsUpdateCurrencyScreen : protected clsScreen
{
private:
	static void _PrintCurrencyCard(clsCurrency Currency)
	{
		cout << "\nCurrency Card : ";
		cout << "\n__________________________________";
		cout << "\nCountry : " << Currency.Country();
		cout << "\nCode : " << Currency.CurrencyCode();
		cout << "\nName : " << Currency.CurrencyName();
		cout << "\nRate/($) : " << Currency.Rate();
		cout << "\n__________________________________\n";
	}
public:
	static void ShowUpdateMenueScreen()
	{
		string Title = "Update Currency Screen";
		_DrawScreenHeader(Title);
		
		cout << "\nPlease Enter Currency Code : ";
		string CurrencyCode = clsInputValidate::ReadString();

		while (!clsCurrency::IsCurrencyExist(CurrencyCode))
		{
			cout << "\nCurrency Does Not Exist, Please Enter Another Currency Code : ";
			CurrencyCode = clsInputValidate::ReadString();
		}
		clsCurrency Currency = clsCurrency::FindByCode(CurrencyCode);
		_PrintCurrencyCard(Currency);

		char answer = 'n';
		cout << "\n\nAre You Sure You Want To Update The Rate of That Currency [y/n] ? ";
		cin >> answer;
		if (toupper(answer) == 'Y' )
		{
			
			cout << "\nUpdate Currency Rate : \n";
			cout << "\nEnter New Currency Rate : ";
			float nowrate = clsInputValidate::ReadFloatNumber();
			Currency.UpdateRate(nowrate);
			_PrintCurrencyCard(Currency);
		}

	}
};

