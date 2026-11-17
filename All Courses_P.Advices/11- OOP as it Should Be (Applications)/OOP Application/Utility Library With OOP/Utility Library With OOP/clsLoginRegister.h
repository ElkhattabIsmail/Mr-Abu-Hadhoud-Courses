#pragma once

#include <iostream>
#include "clsScreen.h"
#include <iomanip>
#include <fstream>
#include "clsUser.h"


class clsLoginRegisterScreen :protected clsScreen
{

private:

    static void PrintLoginRegisterRecordLine(clsUser::stLoginRegisterRecord LoginRegisterRecord)
    {

        cout << setw(8) << left << "" << "| " << setw(22) << left << LoginRegisterRecord.FullName;
        cout << "| " << setw(24) << left << LoginRegisterRecord.DateTime;
        cout << "| " << setw(12) << left << LoginRegisterRecord.UserName;
        cout << "| " << setw(12) << left << LoginRegisterRecord.Password;
        cout << "| " << setw(8) << left << LoginRegisterRecord.Permissions << "    |";
    }

public:

    static void ShowLoginRegisterScreen()
    {
        if (!CheckAccessRights(clsUser::enPermissions::pLoginRegister))
        {
            return; // this expression Exit From Function
        }
        vector <clsUser::stLoginRegisterRecord> vLoginRegisterRecord = clsUser::GetLoginRegisterList();

        string Title = "\tLogin Register List Screen";
        string SubTitle = "\t\t(" + to_string(vLoginRegisterRecord.size()) + ") Record(s).";

        _DrawScreenHeader(Title, SubTitle);

        cout << setw(8) << left << "" << "\n\t_______________________________________________________";
        cout << "______________________________________\n" << endl;

        cout << setw(8) << left << "" << "| " << left << setw(22) << "FullName";
        cout << "| " << left << setw(24) << "Date/Time";
        cout << "| " << left << setw(12) << "UserName";
        cout << "| " << left << setw(12) << "Password";
        cout << "| " << left << setw(8) << "Permissions" << " |";;
        cout << setw(8) << left << "" << "\n\t_______________________________________________________";
        cout << "______________________________________\n" << endl;

        if (vLoginRegisterRecord.size() == 0)
            cout << "\t\t\t\tNo Logins Available In the System!";
        else

            for (clsUser::stLoginRegisterRecord Record : vLoginRegisterRecord)
            {

                PrintLoginRegisterRecordLine(Record);
                cout << endl;
            }

        cout << setw(8) << left << "" << "\n\t_______________________________________________________";
        cout << "______________________________________\n" << endl;

    }

};

