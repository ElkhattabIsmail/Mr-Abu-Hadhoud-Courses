
#include <iostream>
#include <fstream>
using namespace std;
                        // write data on file
int main()
{
    fstream myfile;

    myfile.open("myfile.txt",ios::out);

    if (myfile.is_open())
    {
        myfile << "hello world!\n";
        myfile << "write what you want on file\n";
        myfile << "write what you want on file\n";
        // important thing
        myfile.close();
    }

}
