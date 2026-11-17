// Delete OR Update is the same 

#include <iostream>
#include <fstream>
#include <vector>
#include <string>

using namespace std;

void Load_Data_from_file_TO_Vector(string file_name, vector <string> & Vec_fileContent)
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
void Save_Vector_file(string file_name , vector <string>&Vec_fileContent)
{
    fstream Myfile;
    Myfile.open(file_name, ios::out);  // open file in read mode
    if (Myfile.is_open())
    {
        for (string& line : Vec_fileContent)
        {
            if (line != "")
            {
                Myfile << line << endl;
            }
        }

        Myfile.close();

    }
}
void PrintFileContent(string FileName)
{
    fstream myfile;
    myfile.open(FileName, ios::in);

    if (myfile.is_open())
    {
        string line;
        while (getline(myfile, line))
        {
            cout << line << endl;

        }
        myfile.close();
    } 
}

void Update_Record_From_File( string FileName , string Record , string Update)
{
    vector <string> VEC_filecontent;
    Load_Data_from_file_TO_Vector(FileName, VEC_filecontent);

    for (string & line : VEC_filecontent)
    {
        if ( line == Record )
        {
            line = Update;
        }
    }
    Save_Vector_file(FileName, VEC_filecontent);
}

int main()
{
    cout << "File Content Before Update: \n\n";
    PrintFileContent("Delete_Record.txt");

    Update_Record_From_File("Delete_Record.txt", "int RandomNumber(int From, int To)" , "Smail EL Khattab");

    cout << "\nFile Content after Update: \n\n";
    PrintFileContent("Delete_Record.txt");
}

