//ProgrammingAdvices.com
//Mohammed Abu-Hadhoud

#include <iostream>
#include "clsQueueLine.h"
#include "clsMystring.h"

using namespace std;

int main()
{
    clsMyString S1;
    cout << S1.Value << endl;
    S1.Value = "smail";
    S1.Value = "smail1";
    S1.Value = "smail2";
    S1.Value = "smail3";
    S1.Undo();
    cout << S1.Value << endl;
    S1.Redo();
    cout << S1.Value << endl;

    //clsQueueLine PayBillsQueue("A0", 13);
    //clsQueueLine SubscriptionsQueue("B0", 5);


    //PayBillsQueue.IssueTicket();
    //PayBillsQueue.IssueTicket();
    //PayBillsQueue.IssueTicket();
    //PayBillsQueue.IssueTicket();
    //PayBillsQueue.IssueTicket();

    //cout << "\nPay Bills Queue Info:\n";
    //PayBillsQueue.PrintInfo();

    //PayBillsQueue.PrintTicketsLineRTL();
    //PayBillsQueue.PrintTicketsLineLTR();



    //PayBillsQueue.PrintAllTickets();

    //PayBillsQueue.ServeNextClient();
    //cout << "\nPay Bills Queue After Serving One client\n";
    //PayBillsQueue.PrintInfo();

    //PayBillsQueue.ServeNextClient();
    //cout << "\nPay Bills Queue After Serving One client\n";
    //PayBillsQueue.PrintInfo();

    //PayBillsQueue.ServeNextClient();
    //cout << "\nPay Bills Queue After Serving One client\n";
    //PayBillsQueue.PrintInfo();

    //PayBillsQueue.ServeNextClient();
    //cout << "\nPay Bills Queue After Serving One client\n";
    //PayBillsQueue.PrintInfo();

    //PayBillsQueue.ServeNextClient();
    //cout << "\nPay Bills Queue After Serving One client\n";
    //PayBillsQueue.PrintInfo();
   
    //PayBillsQueue.ServeNextClient();
    //cout << "\nPay Bills Queue After Serving One client\n";
    //PayBillsQueue.PrintInfo();
    //

   /* PayBillsQueue.ServeNextClient();
    cout << "\nPay Bills Queue After Serving One client\n";
    PayBillsQueue.PrintInfo();*/

    //cout << "\nSubscriptions Queue Info:\n";

    //SubscriptionsQueue.IssueTicket();
    //SubscriptionsQueue.IssueTicket();
    //SubscriptionsQueue.IssueTicket();


    //SubscriptionsQueue.PrintInfo();

    //SubscriptionsQueue.PrintTicketsLineRTL();
    //SubscriptionsQueue.PrintTicketsLineLTR();

    //SubscriptionsQueue.PrintAllTickets();

    //SubscriptionsQueue.ServeNextClient();
    //cout << "\nSubscriptions Queue After Serving One client\n";
    //SubscriptionsQueue.PrintInfo();


    return 0;
}

