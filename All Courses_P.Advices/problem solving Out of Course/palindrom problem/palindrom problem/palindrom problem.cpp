// palindrom problem.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <vector>

using namespace std;

//void GivetheLargestPalindromInString(string  arrString[5])
//{
//	for (int i = 0; i < arrString->size(); i++)
//	{
//		cout << arrString->size() << endl;
//	}
//}

vector <int> DoubleVector(vector<int>& nums) 
{
	vector <int> ans(nums.size() * 2 );
	for (int i = 0; i < nums.size() ; i++)
	{
		ans[i] = nums[i];
		ans[i + nums.size()] = nums[i];
	}
	return ans;

}

bool IsWord1Long(string word1, string word2)
{
    if (word1.length() > word2.length())
    {
        return true;
    }

    if (word1.length() < word2.length())
    {
        return false;
    }
    else
    {
        return true;
    }
}
string mergeAlternately(string word1, string word2) {

    string word = "";
    int ShortWord = 0;
    int LongWord = 0;

    string strToAppend = "";

    // Get The Short Word
    if (IsWord1Long(word1, word2))
    {
        strToAppend = word1;
        ShortWord = word2.length();
    }
    else
    {
        strToAppend = word2;
        ShortWord = word1.length();
    }

    // Loop With SHortest Word Length
    for (int i = 0; i < ShortWord; i++)
    {
        string MerginTwoLetters = "";
        MerginTwoLetters += word1[i];
        MerginTwoLetters += word2[i];

        word += MerginTwoLetters;
    }
    return word + strToAppend.substr(LongWord - (LongWord - ShortWord));
}

/*Example 1:

Input: word1 = "abc", word2 = "pqr"
Output : "apbqcr"
Explanation : The merged string will be merged as so :
word1:  a   b   c
word2 : p   q   r
merged : a p b q c r


Example 2 :

    Input : word1 = "ab", word2 = "pqrs"
    Output : "apbqrs"
    Explanation : Notice that as word2 is longer, "rs" is appended to the end.
    word1 : a   b
    word2 : p   q   r   s
    merged : a p b q   r   s


Example 3 :

    Input : word1 = "abcd", word2 = "pq"
    Output : "apbqcd"
    Explanation : Notice that as word1 is longer, "cd" is appended to the end.
    word1 : a   b   c   d
    word2 : p   q
    merged : a p b q c   d


    Constraints :

1 <= word1.length, word2.length <= 100
word1 and word2 consist of lowercase English letters.*/
int main()
{
    string word1 = "ab", word2 = "pqrs";

    cout << mergeAlternately(word1, word2);
  
}



