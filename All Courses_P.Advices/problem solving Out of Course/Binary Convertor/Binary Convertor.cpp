#include <iostream>
#include <string>
#include <algorithm>

using namespace std;
string NormalizedBinaryText(string Binary)
{
    // Normalized the binary txt
    while (Binary.length() % 4 != 0)
    {
        Binary = '0' + Binary;
    }
    return Binary;
}
// Function to convert decimal to binary
string decimalToBinary(int decimalNumber) {
    string binary = "";
    while (decimalNumber > 0) {
        binary += to_string(decimalNumber % 2); // mood
        decimalNumber /= 2;
    }
    reverse(binary.begin(), binary.end()); // Reverse to get the correct binary order

    binary = NormalizedBinaryText(binary);

    return binary.empty() ? "0" : binary; // Handle the case for 0
}

// Function to convert binary to decimal
int binaryToDecimal(const string& binaryString) {
    int decimal = 0;
    int base = 1; // 2^0
    for (int i = binaryString.size() - 1; i >= 0; --i) {
        if (binaryString[i] == '1') {
            decimal += base;
        }
        base *= 2; // Increment base by powers of 2
    }
    return decimal;
}

string HexaDecimalToBinary(const string& HexaDecimal)
{
    string Binary = "";

    for (int i = 0; i < HexaDecimal.size(); i++)
    {
        char Letter = tolower(HexaDecimal[i]);
        if (!isdigit(Letter))
        {
            Binary += NormalizedBinaryText(decimalToBinary(Letter - 87)); // a = 10 , b = 11 ... f = 15 and > 10
        }
        else
        {
            Binary += NormalizedBinaryText(decimalToBinary(Letter - '0')); // All Nums Here < 10        
        }
    }
    return Binary;
}

int HexaDecimalTo_Decimal(const string& HexaDecimal)
{
    // 12A4
    if (HexaDecimal == "0")
        return 0;

    int DecimalNumber = 0;
    for (int i = 0; i < HexaDecimal.size(); i++) {

        char Letter = tolower(HexaDecimal[HexaDecimal.size() - (i + 1)]);

        if (!isdigit(Letter))
        {
            if (Letter > 'f' || Letter < 'a')
                return -1;

            Letter = tolower(Letter - 87);
            DecimalNumber += Letter * pow(16, i);
        }
        else
        {
            DecimalNumber += (Letter - '0') * pow(16, i);
        }
    }

    return DecimalNumber;
}
// Main menu function
void showMenu() {
    cout << "Decimal to Binary and Binary to Decimal Converter" << endl;
    while (true) {
        cout << "\nMenu:" << endl;
        cout << "1. Convert Decimal to Binary" << endl;
        cout << "2. Convert Binary to Decimal" << endl;
        cout << "3. Exit" << endl;

        int choice;
        cout << "Enter your choice (1/2/3): ";
        cin >> choice;

        if (choice == 1) {
            int decimalNumber;
            cout << "Enter a decimal number: ";
            cin >> decimalNumber;
            cout << "Binary representation: " << decimalToBinary(decimalNumber) << endl;
        }
        else if (choice == 2) {
            string binaryString;
            cout << "Enter a binary string: ";
            cin >> binaryString;
            cout << "Decimal representation: " << binaryToDecimal(binaryString) << endl;
        }
        else if (choice == 3) {
            cout << "Goodbye!" << endl;
            break;
        }
        else {
            cout << "Invalid choice. Please try again." << endl;
        }
    }
}

// Main function
int main()
{

    int Dec = 15;
    string Binary = decimalToBinary(Dec);
    cout << Dec << " In Binary = " << Binary << endl;

   
    string Hexa = "";
    cout << "enter hexa decimal : ";
    cin >> Hexa;
    
    string HexaNumberToBinary = HexaDecimalToBinary(Hexa);
    cout << "\nHexa To Decimal = " << HexaNumberToBinary << endl;
    /// showMenu(); /
    return 0;
}
