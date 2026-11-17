#pragma once
#pragma once
#include <iostream>
#include "clsScreen.h"
#include "clsInputValidate.h"
#include <iomanip>
#include "clsShowCurrenciesListScreen.h"
#include "clsShowFindCurrencyScreen.h"
#include "clsUpdateCurrencyScreen.h"
#include "clsShowCurrenciesCalculatorScreen.h"
//#include "clsFindUserScreen.h"




class clsShowCurrencyExchangeScreen : protected clsScreen
{

    private:
        enum enCurrencyExchanges {
            eListCurrencies = 1, eFindCurrency = 2, eUpdateRate = 3,
            eCurrencyCalculator = 4, eMainMenue = 5
        };

        static short ReadManageUsersMenueOption()
        {
            cout << setw(37) << left << "" << "Choose what do you want to do? [1 to 5]? ";
            short Choice = clsInputValidate::ReadShortNumberBetween(1, 5, "Enter Number between 1 to 5? ");
            return Choice;
        }

        static void _GoBackToManageUsersMenue()
        {
            cout << "\n\nPress any key to go back to Manage Users Menue...";
            system("pause>0");
            ShowCurrenciesMenue();
        }

        static void _ShowListCurrenciesScreen()
        {// Staps
            //cout << "\n\nShowListCurrenciesScreen Screen Will Be Here.\n";
            clsShowCurrenciesListScreen::ShowCurrenciesListScreen();
        }

        static void _ShowFindCurrencyScreen()
        {// Staps
            /*cout << "\n\n_ShowFindCurrencyScreen Screen Will Be Here.\n";*/
            clsShowFindCurrencyScreen::ShowFindCurrencyScreen();
        }

        static void _ShowDUpdateRateScreen()
        {// Staps
            //cout << "\n\n_ShowDUpdateRateScreen Screen Will Be Here.\n";
            clsUpdateCurrencyScreen::ShowUpdateMenueScreen();
        }

        static void _ShowCurrenciesCalculatorScreen()
        {// Staps
           //cout << "\n\n_ShowCurrenciesCalculatorScreen Screen Will Be Here.\n";
            clsShowCurrenciesCalculatorScreen::ShowCurrencyCalculatorScreen();
            
        }

        static void _PerformManageUsersMenueOption(enCurrencyExchanges ManageUsersMenueOption)
        {

            switch (ManageUsersMenueOption)
            {
            case enCurrencyExchanges::eListCurrencies:
            {
                system("cls");
                _ShowListCurrenciesScreen();
                _GoBackToManageUsersMenue();
                break;
            }

            case enCurrencyExchanges::eFindCurrency:
            {
                system("cls");
                _ShowFindCurrencyScreen();
                _GoBackToManageUsersMenue();
                break;
            }

            case enCurrencyExchanges::eUpdateRate:
            {
                system("cls");
                _ShowDUpdateRateScreen();
                _GoBackToManageUsersMenue();
                break;
            }

            case enCurrencyExchanges::eCurrencyCalculator:
            {
                system("cls");
                _ShowCurrenciesCalculatorScreen();
                _GoBackToManageUsersMenue();
                break;
            }

         
            case enCurrencyExchanges::eMainMenue:
            {
                //do nothing here the main screen will handle it :-) ;
            }
            }

        }



    public:


        static void ShowCurrenciesMenue()
        {

            //if (!CheckAccessRights(clsUser::enPermissions::pManageUsers))
            //{
            //    return;// this will exit the function and it will not continue
            //}

            system("cls");
            _DrawScreenHeader("Currency Exchange Main Screen");

            cout << setw(37) << left << "" << "===========================================\n";
            cout << setw(37) << left << "" << "\t\t  Currency Main Menue\n";
            cout << setw(37) << left << "" << "===========================================\n";
            cout << setw(37) << left << "" << "\t[1] List Currencies.\n";
            cout << setw(37) << left << "" << "\t[2] find Currency..\n";
            cout << setw(37) << left << "" << "\t[3] Update Rate.\n";
            cout << setw(37) << left << "" << "\t[4] Currency Calculator.\n";
            cout << setw(37) << left << "" << "\t[5] Main Menue.\n";
            cout << setw(37) << left << "" << "===========================================\n";

            _PerformManageUsersMenueOption((enCurrencyExchanges)ReadManageUsersMenueOption());
        }
};

