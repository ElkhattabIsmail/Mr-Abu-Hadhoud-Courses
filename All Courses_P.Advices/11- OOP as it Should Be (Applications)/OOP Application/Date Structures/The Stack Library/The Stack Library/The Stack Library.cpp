// ProgrammingAdvices.com
// Mohammed Abu-Hadhoud

#include <iostream>
#include <stack>
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
}
int SmallSize(int a, int b)
{
    return  a < b ? a : b;
}
bool IsSorted(vector <string> arr, string order)
{
    int letterposition1 = 0;
    int letterposition2 = 0;
    int ArrLength = arr.size();
    for (int i = 0; i < ArrLength; i++)
    {
        // get the small length of word as a length
        int word1 = arr[i].length();
        int word2 = arr[i + 1].length();
        int leng = SmallSize(word1, word2);

        for (int j = 0; j < leng ; j++)
        {
            if (arr[i] == arr[i+1])
                break;
               
            letterposition1 = LetterPosition( arr[ i ] [j], order);
            letterposition2 = LetterPosition( arr[i+1] [j], order);

           
            if (letterposition1 > letterposition2)
                return false;
        }

        if (arr[i + 1].length() < arr[i].length())
            return false;
        
    }
    return true;
}
int main()

{ 
    vector <string>  arrofstring = { "bananaa" , "bananaa" };
    string order = "ahlbcdefgijkmnopqustuvwxz";
   cout << arrofstring.size() << endl;

    if (IsSorted(arrofstring, order))
        cout << "\nis Sorted :-)\n";
    else
        cout << "\nis not Sorted :-(\n";

     
    // create a stack of ints
    //stack <int> stkNumbers;

    //// push into stack
    //stkNumbers.push(10);
    //stkNumbers.push(20);
    //stkNumbers.push(30);
    //stkNumbers.push(40);
    //stkNumbers.push(50);

    //// we can access the element by getting the top and popping
    //// until the stack is empty
    //cout << "count=" << stkNumbers.size() << endl;

    //cout << "Numbers are:\n";
    //while (!stkNumbers.empty()) {
    //    // print top element
    //    cout << stkNumbers.top() << "\n";

    //    // pop top element from stack
    //    stkNumbers.pop();
    //}
    //cout << "count=" << stkNumbers.size() << endl;
    system("pause>0");
    return 0;
}