#include <iostream>
using namespace std;

int MinDolarsPaperNeeded(int totalamount)
{
    // 33 dolars
    // 107 dolars

    if (totalamount <= 0)
        return 0;
    int DolarsDenomination[6] = { 1 , 5 ,10 ,20 ,50 ,100 };

    int  Remaining = 0, MinPapperNeeded = 0;

    int i = 0;
    if (totalamount > 100) {
        i = 5;
    }
    else if (totalamount > 50) {
        i = 4;
    }
    else if (totalamount > 20) {
        i = 3;
    }
    else if (totalamount > 10) {
        i = 2;
    }
    else {
        i = 1;
    }

    for (int i = 5; i >= 0; i--)
    {
        int Denomination = DolarsDenomination[i];
        if (totalamount < Denomination)
            continue;
        MinPapperNeeded += totalamount / Denomination;
        Remaining = totalamount % Denomination;
        if (Remaining == 0)
            return MinPapperNeeded;
        totalamount -= Denomination;
    }

}

int main()
{
    int totalamount;
    cout << "Enter total amount with Dolars : ";
    cin >> totalamount;

    cout << "Minimum Dolar(s) Paper Needed = " << MinDolarsPaperNeeded(totalamount);
}