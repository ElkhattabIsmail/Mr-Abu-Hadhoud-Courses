#include<iostream>
#include<string>
#include<cstdlib>
using namespace std;

int randomNumber(int from, int to)
{
    //Function to generate a random number

    int  randNum = rand() % (to - from + 1) + from;
    return randNum;
}
void ReadArray(int arr[100], int& arrLength)
{
    cout << "enter a number\n";
    cin >> arrLength;
    for (int i = 0; i < arrLength; i++)
        arr[i] = randomNumber(1, 100);
    cout << endl;
}
void PrintArray(int arr[100], int arrLength)
{
    for (int i = 0; i < arrLength; i++)
        cout << arr[i] << " ";
    cout << endl;
}
void ArrayNumberReversed(int arrSource[100], int arrDestination[100], int arrLength)
{
    int count = 0;
    for (int i = arrLength - 1; i >= 0; i--)
    {
        arrDestination[i] = arrSource[count];
        count++;
    }
    cout << endl;
}


int main()
{
    int arr[100], arrLength;
    ReadArray(arr, arrLength);

    cout << "\nArray 1 elements : \n";
    PrintArray(arr, arrLength);
    int arrcopy[100];

    ArrayNumberReversed(arr, arrcopy, arrLength);


    cout << "\nArray 2 elements after reversing: \n";
    PrintArray(arrcopy, arrLength);
}