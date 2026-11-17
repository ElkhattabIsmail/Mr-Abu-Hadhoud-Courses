// dynamic memory allocation
#include <iostream>
#include <cstring>  // For memset

using namespace std;

void kkkkk()
{
	int num;
	cout << "Enter total number of students: ";
	cin >> num;

	float* ptr;

	// memory allocation of num number of floats
	ptr = new float[num];

	cout << "Enter grades of students." << endl;

	for (int i = 0; i < num; i++) {
		cout << "Student" << i + 1 << ": ";
		cin >> *(ptr + i);
	}
	cout << "\nDisplaying grades of students." << endl;
	for (int i = 0; i < num; i++) {
		cout << "Student" << i + 1 << ": " << *(ptr + i) << endl;
	}
	// ptr memory is released
	delete[] ptr;
}
short first_NonRepeatingChar(string text)
{

	int arr[26] = { 0 };

	//int charCount[] = { 0 }; // Assuming lowercase letters only

	for (char c : text) {
		arr[c - 'a']++;
	}

	for (int i = 0; i < text.length(); i++)
	{
		if (arr[text[i] - 'a'] == 1)
			return i;

	}
		return -1;
	}


int My_first_NonRepeating_Char_UsingPointer (const string& text) 
{
	int size = text.length();
	int iterateSize = size;
	int* TempArray;

	if (size > 26)
	{
		size = 26;
		TempArray = new int[size];
	}
	else
	{
		TempArray = new int[size];
	}

	//   POINTER , VAL , SIZE * SIZE OF ???
	memset(TempArray, 0, size * sizeof(int));  // 26 elements of type int
	
	 // initializing the elements arrays to 0
	//for (int i = 0; i < size; i++)
	//{
	//	*(TempArray + i ) = 0;   // 
	//}

	//memset(TempArray, 0, size * sizeof(int));

	// First pass: Count the frequency of each character
	for (char c : text)
	{
		int idx = c - 'a';
		TempArray[idx]++;
	}

	// Second pass: Find the index of the first non-repeating character
	for (int i = 0; i < iterateSize; i++) {
		char letter = text[i];
		int inxthatequal1 = TempArray[letter - 'a'];
		if (inxthatequal1 == 1) {
			delete[] TempArray; // Free dynamically allocated memory
			return i;
		}
	}

	delete[] TempArray; // Free dynamically allocated memory
	return -1;  // Return -1 if no non-repeating character is found
}
int first_NonRepeating_Char_UsingPointer2(const std::string& text) {
	const int size = text.length();

	// Fixed-size array for lowercase English letters (26 letters)
	int TempArray[26] = { 0 };  // Automatically initialized to 0

	// First pass: Count the frequency of each character
	for (char c : text) {
		TempArray[c - 'a']++;  // Increment the corresponding index based on the character
	}

	// Second pass: Find the index of the first non-repeating character
	for (int i = 0; i < size; i++) {
		if (TempArray[text[i] - 'a'] == 1) {
			return i;  // Return the index of the first non-repeating character
		}
	}

	return -1;  // Return -1 if no non-repeating character is found
}
void fillWithZero(int* ptr, size_t num_elements)
{
	// Manually zero out the memory block by treating it as a block of bytes
	for (size_t i = 0; i < num_elements; i++) {
		*(ptr + i) = 0; // Set each element to 0
	}
}
int main() {

    string text = "kakabbaaaaaaaaaaaaabbbzzzzzzsssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssm";
	cout << My_first_NonRepeating_Char_UsingPointer(text);


	/*example*/
	//int* ptr;
	//ptr = new int[3 , 0];
	//memset(ptr, 0, 3 * sizeof(int));	/**(ptr + 0) = 10;
	//*(ptr + 1) = 20;
	//*(ptr + 2) = 30;*/

	//for (int i = 0; i < 3; i++)
	//{
	//	cout << *(ptr + i) << endl;
	//}

	//int arr[5] = { 1, 2, 3, 4, 5 };

	//// Set all bytes of arr to zero (initialize array to zero)
	//memset(arr, 0, sizeof(arr));

	//for (int i = 0; i < 5; i++) {
	//	std::cout << arr[i] << " ";
	//}


	

	return 0;
}

// Manually fill the array of pointers
// 
// 
//#include <iostream>
//
//int main() {
//	const int size = 5;
//
//	// Array of pointers to int
//	int* arr[size];
//

//	for (int i = 0; i < size; i++) {
//		arr[i] = new int;  // Dynamically allocate memory for each element (pointer)
//		*(arr[i]) = i + 1; // Set the value of the allocated memory (e.g., 1, 2, 3, ...)
//	}
//
//	// Print the values
//	for (int i = 0; i < size; i++) {
//		std::cout << "arr[" << i << "] = " << *(arr[i]) << std::endl;
//	}
//
//	// Clean up the dynamically allocated memory
//	for (int i = 0; i < size; i++) {
//		delete arr[i];  // Free each allocated memory block
//	}