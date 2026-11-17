#include <iostream>
#include <array>
using namespace std;

int countUniqueCharacters(const string & str) {
    array<bool, 256> charSet = { false }; // Array to track occurrences of ASCII characters
    int uniqueCount = 0;

    for (char ch : str) {
        if (!charSet[static_cast<unsigned char>(ch)]) {
            charSet[static_cast<unsigned char>(ch)] = true; // Mark character as encountered
            uniqueCount++; // Increment unique count
        }
    }

    return uniqueCount;
}
int CountUniqueCharacters(string& str) {
    bool Aski[256] = { false }; // Array to track occurrences of ASCII characters
    int uniqueCount = 0;

    for (char ch : str) {
        if (!Aski[ch])
        {
            Aski[ch] = true; // Mark character as encountered
            uniqueCount++; // Increment unique count
        }
    }
    return uniqueCount;
}
int main() {
    string input = "Programming"; // Example input
    cout << "Number of unique characters: "
        << CountUniqueCharacters(input)
        << endl;
    //string input = "programming"; // Example input
    //cout << "Number of unique characters: "
    //    << countUniqueCharacters(input)
    //    << endl;
    return 0;
}
