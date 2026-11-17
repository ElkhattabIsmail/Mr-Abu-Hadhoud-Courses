#include <iostream>
#include <fstream>
#include<string>

using namespace std;

void PrintFileContenet(string FileName) {

	fstream MyFile;

	MyFile.open(FileName, ios::in);//read Modeif (MyFile.is_open())     { 
	string Line;

	while (getline(MyFile, Line))
	{
		cout << Line << endl;
	}
	MyFile.close();
}


// append data on file 
int main()
{
    fstream myfile;

    myfile.open("myfile.txt", ios::out | ios::app);

    if (myfile.is_open())
    {
        

        // important thing
        myfile.close();
    }

	PrintFileContenet("myfile.txt");

}

