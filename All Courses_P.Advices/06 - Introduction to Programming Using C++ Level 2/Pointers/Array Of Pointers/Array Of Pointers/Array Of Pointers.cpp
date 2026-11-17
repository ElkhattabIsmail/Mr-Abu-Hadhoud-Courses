
#include <iostream>

using namespace std;

int readNumber(string text , int count )
{
    int num = 0;
    cout << text <<count <<" : ";
    cin >> num;
    cout << endl;
    return num;
}

void FillArray(int &arrLength ,int arr[100])
{
    int count = 1;
    for (int i = 0; i < arrLength; i++)
    {
        arr[i] = readNumber("enter element ",count);
        count++;
    }
    cout << endl;
}

void printElement(int &arrLength, int arr[100])
{
    int * arrPointer;
    arrPointer = arr;

    cout << "list of values and address of array elements : \n\n";
    for (int i = 0; i < arrLength; i++)
    {
        cout << "array element number "<< i+1 << " = ";
        cout << *(arrPointer+i);
        cout << "\nelment adress = ";
        cout << arrPointer+i<< "\n\n";
    }
}

int main()
{
    int arrLength = 0, arr[100],count=0;
    cout<<"enter the length of array : ";
    cin >> arrLength;

    FillArray(arrLength, arr);
    printElement(arrLength, arr);
}