#pragma once
#include<iostream>
#include<string>
#include "clsString.h"
#include "clsScreen.h"
#include "clsCurrency.h"
#include <vector>
#include <iomanip>

class clsShowCurrenciesListScreen : protected clsScreen
{
private:

    static void _PrintCurrencyRecordLine(clsCurrency  &Currency)
    {
        cout << setw(8) << left << "" << "| " << setw(28) << left << Currency.Country();
        cout << "| " << setw(10) << left << Currency.CurrencyCode();
        cout << "| " << setw(42) << left << Currency.CurrencyName();
        cout << "| " << setw(10) << left << Currency.Rate();
    }

public:
	static void ShowCurrenciesListScreen()
	{

		vector <clsCurrency> vAllCurrencies = clsCurrency::GetCurrenciesList();

        string Title = "Currencies List Screen";
		string SubTitle = to_string(vAllCurrencies.size()) + " Currency.";
		_DrawScreenHeader(Title, SubTitle);

        cout << setw(8) << left << "" << "\n\t_______________________________________________________";
        cout << "_________________________________________\n" << endl;

        cout << setw(8) << left << "" << "| " << left << setw(28) << "Country";
        cout << "| " << left << setw(10) << "Code";
        cout << "| " << left << setw(42) << "Name";
        cout << "| " << left << setw(10) << "Rate/($)";
        cout << setw(8) << left << "" << "\n\t_______________________________________________________";
        cout << "_________________________________________\n" << endl;

        if (vAllCurrencies.size() == 0)
            cout << "\t\t\t\tNo Clients Available In the System!";
        else

            for (clsCurrency Currecy : vAllCurrencies)
            {

                _PrintCurrencyRecordLine(Currecy);
                cout << endl;
            }

        cout << setw(8) << left << "" << "\n\t_______________________________________________________";
        cout << "_________________________________________\n" << endl;

    }

};

