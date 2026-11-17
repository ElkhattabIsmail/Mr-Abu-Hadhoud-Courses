

//ProgrammingAdvices.com
//Mohammed Abu-Hadhoud
#include <iostream>
#include "clsDate.h"
#include "clsPeriod.h"

using namespace std;

int main()

{
    clsPeriod Period1(clsDate(20, 4, 2000), clsDate(27, 5, 2024));

    // Period1.EndDate = clsDate (15,4,2004);
    

    Period1.Print();

    //Date3.PrintYearCalendar();
    //cout << Date2.IsValid() << endl;

    /*cout << "My Age InDays:" <<
        clsDate::CalculateMyAgeInDays(  clsDate(6, 11, 1977) );*/
        //You can try any method at your own..


    system("pause>0");
    return 0;
};



