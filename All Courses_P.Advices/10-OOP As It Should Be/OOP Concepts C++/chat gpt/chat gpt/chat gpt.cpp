#include <iostream>
#include <sstream>
#include <iomanip>

struct Date {
    int year;
    int month;
    int day;
};

Date addDaysToDate(Date date, int days) {
    // حساب عدد الأيام المضافة لكل شهر
    int daysPerMonth[] = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

    // إضافة عدد الأيام المحدد إلى التاريخ
    date.day += days;

    // التعامل مع التواريخ الزائدة عن حدود الشهر
    while (date.day > daysPerMonth[date.month - 1]) {
        // احتساب اليوم الزائد
        int extraDays = date.day - daysPerMonth[date.month - 1];

        // التحقق من شهر فبراير (شهر رقم 2) لمعاملة السنة الكبيسة
        if (date.month == 2 && (date.year % 4 == 0 && (date.year % 100 != 0 || date.year % 400 == 0))) {
            if (extraDays > 29) {
                extraDays--;
            }
            else {
                break;
            }
        }

        // التحقق من نهاية السنة والانتقال إلى العام التالي
        if (date.month == 12) {
            date.year++;
            date.month = 1;
        }
        else {
            date.month++;
        }

        date.day = extraDays;
    }

    return date;
}

int main() {
    Date date;
    int days;

    std::cout << "Enter date (YYYY-MM-DD): ";
    std::cin >> date.year;
    std::cin.ignore();
    std::cin >> date.month;
    std::cin.ignore();
    std::cin >> date.day;

    std::cout << "Enter number of days to add: ";
    std::cin >> days;

    Date newDate = addDaysToDate(date, days);

    std::cout << "New date after adding days: " << std::setfill('0')
        << std::setw(4) << newDate.day << "-" << std::setw(2) << newDate.month << "-"
        << std::setw(2) << newDate.year<< std::endl;

    return 0;
}