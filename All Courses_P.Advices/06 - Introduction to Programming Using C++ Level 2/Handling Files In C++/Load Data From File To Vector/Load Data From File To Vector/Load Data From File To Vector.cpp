#include <iostream>
#include <fstream>
#include<string>
#include<vector>

using namespace std;

void Load_Data_from_file_TO_Vector(string file_name, vector <string>& Vec_fileContent)
{
	fstream Myfile;
	Myfile.open(file_name, ios::in);   // Read mode IN
	if (Myfile.is_open())
	{
		string line = "";

		while (getline(Myfile, line))
		{
			Vec_fileContent.push_back(line);
		}
		Myfile.close();
	
	}
}

int main()
{
	vector <string> Vec_fileContent;

	Load_Data_from_file_TO_Vector("Myfile02.txt", Vec_fileContent);
	 // ranged loop 

	for (string& line : Vec_fileContent)
	{
		cout << line << endl;
	}
	return 0;
}

