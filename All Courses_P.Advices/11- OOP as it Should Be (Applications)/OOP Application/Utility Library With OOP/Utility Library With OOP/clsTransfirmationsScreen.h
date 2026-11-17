#pragma once
#include <iostream>
#include "clsScreen.h"
#include "Global.h"
#include "clsPerson.h"
#include "clsBankClient.h"
#include "clsInputValidate.h"

class clsTransferScreen :protected clsScreen
{

private:
    
    static void _PrintClient(clsBankClient Client)
    {

        cout << "\nClient Card:";
        cout << "\n___________________\n";
        cout << "\nFull Name   : " << Client.FullName();
        cout << "\nAcc. Number : " << Client.AccountNumber();
        cout << "\nBalance     : " << Client.AccountBalance;
        cout << "\n___________________\n";

    }

    static float ReadAmount(clsBankClient SourceClient)
    {
        float Amount;

        cout << "\nEnter Transfer Amount? ";

        Amount = clsInputValidate::ReadFloatNumber();

        while (Amount > SourceClient.AccountBalance)
        {
            cout << "\nAmount Exceeds the available Balance, Enter another Amount ? ";
            Amount = clsInputValidate::ReadDblNumber();
        }
        return Amount;
    }
    
    
public:

    static void ShowTransferScreen()
    {

        _DrawScreenHeader("\tTransfer Screen");

        cout << "\nPlease Enter Account Number To Transfer From : ";
        string AccountNumberFrom = clsInputValidate::ReadString();
        while (!clsBankClient::IsClientExist(AccountNumberFrom))
        {
            cout << "\nAccount Number Not Exist Choose Another : ";
            AccountNumberFrom = clsInputValidate::ReadString();
        }
        clsBankClient SourceClient = clsBankClient::Find(AccountNumberFrom);
        _PrintClient(SourceClient);
 


        cout << "\n\nPlease Enter Account Number To Transfer To : ";
        string AccountNumberTo = clsInputValidate::ReadString();
        while (!clsBankClient::IsClientExist(AccountNumberTo) || AccountNumberTo == SourceClient.AccountNumber() )
        {
            cout << "\nInvalid Account Choose Another : ";
            AccountNumberTo = clsInputValidate::ReadString();
        }
        clsBankClient DestinationClient = clsBankClient::Find(AccountNumberTo);
        _PrintClient(DestinationClient);

        float Amount = ReadAmount(SourceClient);
        

        cout << "\nAre you sure you want to perform this operation? y/n? ";
        char Answer = 'n';
        cin >> Answer;
        if (Answer == 'Y' || Answer == 'y')
        {
            if (SourceClient.Transfer(Amount, DestinationClient ,CurrentUser.UserName))
            {
                cout << "\nTransfer done successfully\n";
            }
            else
            {
                cout << "\nTransfer Faild \n";
            }
        }

        _PrintClient(SourceClient);
        _PrintClient(DestinationClient);

        
    }

};

