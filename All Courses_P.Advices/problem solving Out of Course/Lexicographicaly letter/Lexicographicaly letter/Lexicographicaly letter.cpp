
#include <iostream>
#include <vector>

using namespace std;

int LetterPosition(char letter, string order)
{
    int count = 0;
    for (int i = 0; i < order.length(); i++)
    {
        count++;
        if (letter == order[i])
            return count;
    }
    return -1;
}
int SmallSize(int a, int b)
{
    return  a < b ? a : b;
}
bool IsSorted(vector <string> vOSring, string order)
{
    int letterposition1 = 0;
    int letterposition2 = 0;
    int ArrLength = vOSring.size();

    if (ArrLength == 0)
        return false;
    if (ArrLength == 1)
        return true;

    for (int i = 0; i < ArrLength -1 ; i++)
    {
       
        string firstword = vOSring[i];
        string nextword = vOSring[i + 1];

        if (firstword == nextword && ArrLength == 2)
            return true;
        // case whene the words are same 
        // move to next word
        if (firstword == nextword)
            continue;

        // get the small length of word as a length
        int leng = SmallSize(firstword.length() , nextword.length());

        for (int j = 0; j < leng; j++)
        {
            char letter1 = firstword[j];
            char letter2 = nextword[j];

            letterposition1 = LetterPosition(letter1, order);
            letterposition2 = LetterPosition(letter2, order);


            if (letterposition1 > letterposition2)
                return false;
        }

        if (nextword.length() < firstword.length())
            return false;

    }
    return true;
}
int main()

{
    vector <string>  vofstring  = {"smail" , "smaik"};
    string order = "abcdefghijklmnopqrstuvwxyz";

    if (IsSorted(vofstring, order))
        cout << "\nis Sorted :-)\n";
    else
        cout << "\nis not Sorted :-(\n";

    return 0;
}