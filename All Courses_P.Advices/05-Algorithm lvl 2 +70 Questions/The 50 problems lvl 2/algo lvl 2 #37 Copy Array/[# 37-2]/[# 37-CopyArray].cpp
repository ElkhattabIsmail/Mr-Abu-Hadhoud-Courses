#include<iostream>
using namespace std;
int randomNumber(int from, int to)
{
	int  randNum = rand() % (to - from + 1) + from;
	return randNum;
}
void fillArrays(int arr[100], int& arrLength)
{
	cout << "\nPlease enter a number? \n";
	cin >> arrLength;
	for (int i = 0; i < arrLength; i++)
	{
		arr[i] = randomNumber(1, 100);
	}
}
void PrintArray(int arr[100], int arrLength) {
	for (int i = 0; i < arrLength; i++)
		cout << arr[i] << " ";
	cout << "\n";
}
void AddArrayElement(int Number, int arr[100], int & arrLength)
{ 
	//its a new element so we need to add the length by 1
	arrLength++;
	arr[arrLength - 1] = Number;
}
void copyArrayUSINGAddArrayElement(int arrsource[100], int arrDistination[100], int arrLength, int &arr2Length) // by ref
{
	for (int i = 0; i < arrLength; i++)
		AddArrayElement(arrsource[i], arrDistination, arr2Length);
}

int main()
{
	srand((unsigned)time(NULL));
	int arr[100], arrLength = 0, arr2Length = 0;
	fillArrays(arr, arrLength);

	int arr2[100];
	copyArrayUSINGAddArrayElement(arr, arr2, arrLength, arr2Length);

	cout << "\nArray 1 elements: ";
	PrintArray(arr, arrLength);
	cout << "\nArray elements after copy: ";
	PrintArray(arr2, arr2Length);

	return 0;
}
