#pragma once
#include <iostream>
#include <string>
#include <vector>

using namespace std;

class ClsString
{
private:
    string _Value;
   
   

public:

   
    // two Constructors
    ClsString(string Value)  // parametrized Constructor 
                             // لا يمكن صنع شيء منه الا عبر وضع حاوية من نوع سترينغ
    {
       // P_arrayOfString = new string[size];  // Dynamically allocate memory
        _Value = Value;
    }
    ClsString() // default Constructor With Parameter But you Must Define an Object to Call it 
    {

    }
    //
     // Destructor
    //~ClsString() 
    //{
    //    delete [] P_arrayOfString; // Deallocate the memory when the object is destroyed
    //}
    void setLength(short Delim)
    {
        _Delim = Delim;
    }
    short getLength()
    {
        return _Length;
    }
    __declspec(property(get = getLength, put = setLength)) short Length;

    //
    void SetDelimeter(string Delim)
    {
        _Delim = Delim;
    }
    string GetDelimeter()
    {
        return _Delim;
    }
    __declspec(property(get = GetDelimeter, put = SetDelimeter)) string Delim;
    //
    void SetVectorValue(vector <string> _vString)
    {
        this->_vString = _vString;
    }
    vector <string> GetVectorValue()
    {
        return this->_vString;
    }
    __declspec(property(get = GetVectorValue, put = SetVectorValue)) vector <string> VectorValue; // combine two functions

    void SetValue(string Value)
    {
        _Value = Value;
    }
    //
    string GetValue()
    {
        return _Value;
    }
    __declspec(property(get = GetValue, put = SetValue)) string Value; // combine two functions

    //fun 1
    static short CountWords(string S1)// this fun sush as is static , so we can use it out of class
                                      // without any problems and by itself
    {
        if (S1 == "")
        {
            return 0;
        }// if empty string no string
        short space = 0;
        for (short i = 0; i < S1.length(); i++)
        {
            if (S1.at(i) == ' ')
            {
                space++;
            }
        }
        if (space == 0)
        {
            return 1;
        } // if string has no spaces we return 1 word
        string Delimeter = " ";
        string Word;
        short position = 0;
        short Count = 0;
        while ( (position = S1.find(Delimeter)) != std::string::npos )
        {
            Word = S1.substr(0, position);

            if (Word != " ")
            {
                Count++;
            }

            S1.erase(0 , position + Delimeter.length());
        }
        
        if (S1 != "")  // Get The Last Word In String
        {
            Count++;
        }
        
        return Count;
    }
    short CountWords()  // هادي الفانكشن تؤثر على الأوبجيكت مباشرة 
    {
        return CountWords(_Value);
    }


    // function 2 to get first letter in each word
    static void PrintFirstLetterOfEachWord(string S1) // you can use this function on another value not in class
    {
        bool isFirstLetter = true;
        cout << "\n First letters of this string :\n";
            for (int i = 0; i < S1.length(); i++)
            {
                if (S1[i] != ' ' && isFirstLetter)
                {
                    cout << S1[i] << endl;
                }
                isFirstLetter = (S1[i] == ' ' ? true : false);
            }
    }
    void PrintFirstLetterOfEachWord()
    {
        return PrintFirstLetterOfEachWord(_Value);
    }

    // fun 3
    static string UpeerFirstLetterOfEachWord(string S1)
    {
        bool isFirstLetter = true;
        for (int i = 0; i < S1.length(); i++)
        {
            if (S1[i] != ' ' && isFirstLetter)
            {
                S1[i] = toupper(S1[i]);
            }
            isFirstLetter = (S1[i] == ' ' ? true : false);
        }
        return S1;
    }
    string UpeerFirstLetterOfEachWord()
    {
        return UpeerFirstLetterOfEachWord(_Value);
    }

    // fun 4
    static string LowerFirstLetterOfEachWord(string S2)
    {
        bool isFirstLetter = true;
        for (int i = 0; i < S2.length(); i++)
        {
            if (S2[i] != ' ' && isFirstLetter)
            {
                S2[i] = tolower(S2[i]);
            }
            isFirstLetter = (S2[i] == ' ' ? true : false);
        }
        return S2;
    }
    string LowerFirstLetterOfEachWord()
    {
        return  LowerFirstLetterOfEachWord(_Value);
    }
    // fun 
    static char InvertLetterCase(char Char1)
    {
          return isupper(Char1) ? tolower(Char1) : toupper(Char1);
    }
    static string InvertAllStringLetterCase(string S1)
    {
        for (int i = 0; i < S1.length(); i++)
        {
            S1[i] = InvertLetterCase(S1[i]);
        }
        return S1;
    }
    string InvertAllStringLetterCase()
    {
        return InvertAllStringLetterCase(_Value);
    }

    // fun 6
    
    static short CountLetters(string S5, short WhatToCount = 1)
    {
        
        // all = 1 , capital = 0 , small = -1 ;
            if (WhatToCount == 1)
            {
                return S5.length();
            }
        short Counter = 0;
        for (int i = 0; i < S5.length(); i++)
        {
            if (WhatToCount == 0 && isupper(S5[i]))
                Counter++;
            if (WhatToCount == -1 && islower(S5[i]))
                Counter++;
        }
        return Counter;
    }
    short CountLetters(short WhatToCount = 1)
    {
        return CountLetters(_Value, WhatToCount);
    }

    // func 8
    static short CountLetter(string S6, char Letter, bool MatchCase = true)
    {
        short Counter = 0;
        for (short i = 0; i <= S6.length(); i++)
        {
            if (MatchCase)
            {
                if (S6[i] == Letter)
                    Counter++;
            }
            else
            {
                    if (tolower(S6[i]) == tolower(Letter))
                        Counter++;
            }
        }
        return Counter;
    }

    short CountLetter(char Letter , bool MatchCase = true)
    {
        return CountLetter(_Value, Letter , MatchCase);
    }
    
    // fun 
    static bool IsVowel(char Ch4)
    {
        Ch4 = tolower(Ch4);
        return ((Ch4 == 'a') || (Ch4 == 'e') || (Ch4 == 'i') || (Ch4 == 'o') || (Ch4
            == 'u'));
    }
    static short CountVowels( string S7)
    {
        short Counter = 0;
        for (short i = 0; i < S7.length(); i++)
        {
            if (IsVowel(S7[i]))
            {
                Counter++;
            }
        }
        return Counter;
    }
    short CountVowels()
    {
        return CountVowels(_Value);
    }
    
    // fun 11
    static void PrintEachWordInStringAndCountThem(string S9 ,string delim = " " ,bool CountWords = false)
    {
        int count = 0;
        cout << "\nYour string words are : \n\n";
        short pos = 0;
        string sWord; // define a string variable
        // use fine() function to get the position
       
            while ((pos = S9.find(delim)) !=
                std::string::npos)
            {
                sWord = S9.substr(0, pos);
                if (sWord != "")
                {
                    count++;
                    cout << sWord << endl;
                }
              
                    // erase() until positon and move to next word
                    S9.erase(0, pos + delim.length());
            }
        
            if (S9 != "")
            {
                // it print last word of the string
                count++;
                cout << S9 << endl;
            }
            if (CountWords)
            {
                cout << "\nNumber of Words is : " << count << endl;
            }
    }
    void PrintEachWordInStringAndCountThem(bool CountWords = false)
    {
        return PrintEachWordInStringAndCountThem(_Value, _Delim ,CountWords);
    }

    // 12
    static vector <string> SplitString(string S9, string Delim = " ")
    {
        vector <string> vString;
        short pos = 0;
        string sWord; // define a string variable
        // use fine() function to get the position
        
            while ((pos = S9.find(Delim)) !=
                std::string::npos)
            {
                
                    sWord = S9.substr(0, pos);
                if (sWord != "")
                {
                    vString.push_back(sWord);
                }
              
                    // erase() until positon and move to next word
                    S9.erase(0, pos + Delim.length());
            }
            if (S9 != "")
            {
                // it print last word of the string
                vString.push_back(S9);
            }
        return vString;
    }
    vector <string> SplitString()
    {
        return SplitString(_Value, _Delim);
    }

    // fun 13
    static void PrintVectorOfString( vector <string> Vstring )
    {
        cout << "Tokens = " << Vstring.size() << endl;
        for (string& s : Vstring)
        {
            cout << s << endl;
        }
    }
    void PrintVectorOfString() // use OverLoading Concept (Different Parameter With same name fun)
    {
        vector <string> _Vstring = SplitString(_Value, _Delim);
        return PrintVectorOfString(_Vstring);
    }

    // fun 14
    static string TrimLeft(string S10)
    {
        for (short i = 0; i < S10.length(); i++)
        {
            if (S10[i] != ' ')
            {
                return S10.substr(i,
                    S10.length() - i);
            }
        }
        return "";
    }
   

    static string TrimRight(string S10)
    {
        for (short i = S10.length() - 1; i >= 0; i --)
        {
            if (S10[i] != ' ')
            {
                return S10.substr(0, i + 1);
            }
        }
        return "";
    }
    
    static string Trim(string S10)
    {
        return TrimLeft(TrimRight(S10));
    }
    string Trim()
    {
        return Trim(_Value);
    }
     // fun 15
    // Join Vector of String with a Delimeter
    static string JoinVectorString(vector <string> vString, string
        Delim)
    {
        string S1 = "";
        for (string& s : vString)
        {
            S1 = S1 + s + Delim;
        }
        return S1.substr(0, S1.length() - Delim.length()); // Cut last Delim
    }
    string JoinVoctorOfString()
    {
        return JoinVectorString(_vString, _Delim);
    }

    // fun 16
    static string JoinStringArray( string arrString[], short Length , string Delim)
    {
       
        string S1 = "";
        for (short i = 0; i < Length; i++)
        {
            S1 = S1 + arrString[i] + Delim;
        }
        return S1.substr(0, S1.length() - Delim.length());
    }
    
    string JoinStringArray()
    {
        return JoinStringArray( P_arrayOfString , _Length , _Delim);
    }
};


