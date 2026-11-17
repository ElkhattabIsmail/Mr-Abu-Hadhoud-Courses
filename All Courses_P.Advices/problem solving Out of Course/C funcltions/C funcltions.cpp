
#include <iostream>
#include <string>
#include <iomanip>
using namespace std;

//char* ft_strcpy(char* dest, char* src) {
//    int i = 0;
//    while (src[i] != '\0') {
//        dest[i] = src[i];
//        i++;
//    }
//    dest[i] = '\0';
//    return dest;
//}
char* ft_strcpy(char* dest, const char* src) 
{
    int i = 0;
    while (src[i] != '\0') {
        dest[i] = src[i];
        i++;
    }
    dest[i] = '\0';
    return dest;
}



char* ft_strncpy(char* dest, const char* src, unsigned int n) {
    unsigned int i;
    for (i = 0; i < n && src[i] != '\0'; i++) {
        dest[i] = src[i];
    }
    for (; i < n; i++) {
        dest[i] = '\0';
    }
    return dest;
}
bool ft_str_is_alpha(const string & str) {
    for (char ch : str) {
        if (!isalpha(static_cast<unsigned char>(ch))) {
            return false;
        }
    }
    return true;
}
bool ft_str_is_numeric(const string & str) {
    for (char ch : str) {
        if (!isdigit(static_cast<unsigned char>(ch))) {
            return false;
        }
    }
    return true;
}
bool ft_str_is_lowercase(const string & str) {
    for (char ch : str) {
        if (!islower(static_cast<unsigned char>(ch))) {
            return false;
        }
    }
    return true;
}
bool ft_str_is_uppercase(const string & str) {
    for (char ch : str) {
        if (!isupper(static_cast<unsigned char>(ch))) {
            return false;
        }
    }
    return true;
}
bool ft_str_is_printable(const string & str) {
    for (char ch : str) {
        if (!isprint(static_cast<unsigned char>(ch))) {
            return false;
        }
    }
    return true;
}
string ft_strupcase(string str) {
    for (char& ch : str) {
        ch = toupper(static_cast<unsigned char>(ch));
    }
    return str;
}
string ft_strlowcase(string str) {
    for (char& ch : str) {
        ch = tolower(static_cast<unsigned char>(ch));
    }
    return str;
}
string ft_strcapitalize(string str) {
    bool capitalize = true;
    for (char& ch : str) {
        if (isalnum(static_cast<unsigned char>(ch))) {
            if (capitalize) {
                ch = toupper(static_cast<unsigned char>(ch));
                capitalize = false;
            }
            else {
                ch = tolower(static_cast<unsigned char>(ch));
            }
        }
        else {
            capitalize = true;
        }
    }
    return str;
}
size_t ft_strlcpy(char* dest, const char* src, size_t size) {
    size_t i = 0;
    while (i + 1 < size && src[i] != '\0') {
        dest[i] = src[i];
        i++;
    }
    if (size > 0) {
        dest[i] = '\0';
    }
    while (src[i] != '\0') {
        i++;
    }
    return i;
}
void ft_putstr_non_printable(const string & str) {
    for (char ch : str) {
        if (isprint(static_cast<unsigned char>(ch))) {
            cout << ch;
        }
        else {
            cout << "\\x" << hex << setfill('0')
                << setw(2) << static_cast<int>(static_cast<unsigned char>(ch));
        }
    }
    cout << endl;
}




void ft_print_memory(const void* addr, size_t size) {
    const unsigned char* memory = static_cast<const unsigned char*>(addr);
    for (size_t i = 0; i < size; i += 16) {
        // Print memory address
        cout << setw(16) << setfill('0') << hex
            << reinterpret_cast<size_t>(memory + i) << ": ";

        // Print hexadecimal content
        for (size_t j = 0; j < 16; j++) {
            if (i + j < size) {
                cout << setw(2) << static_cast<int>(memory[i + j]) << " ";
            }
            else {
                cout << "   ";
            }
        }

        // Print printable characters
        cout << " ";
        for (size_t j = 0; j < 16 && i + j < size; j++) {
            char ch = memory[i + j];
            cout << (isprint(static_cast<unsigned char>(ch)) ? ch : '.');
        }
        cout << endl;
    }
}
int main()
{

    return 0;
}
//ft_strcpy:
//
//Reproduce the behavior of strcpy without using library functions.
//Prototype : char* ft_strcpy(char* dest, char* src);
//ft_strncpy:
//
//Reproduce the behavior of strncpy.
//Prototype : char* ft_strncpy(char* dest, char* src, unsigned int n);
//ft_str_is_alpha:
//
//Check if a string contains only alphabetic characters.
//Prototype : int ft_str_is_alpha(char* str);
//ft_str_is_numeric:
//
//Check if a string contains only numeric characters.
//Prototype : int ft_str_is_numeric(char* str);
//ft_str_is_lowercase:
//
//Check if a string contains only lowercase alphabetic characters.
//Prototype : int ft_str_is_lowercase(char* str);
//ft_str_is_uppercase:
//
//Check if a string contains only uppercase alphabetic characters.
//Prototype : int ft_str_is_uppercase(char* str);
//ft_str_is_printable:
//
//Check if a string contains only printable characters.
//Prototype : int ft_str_is_printable(char* str);
//ft_strupcase:
//
//Convert all letters in a string to uppercase.
//Prototype : char* ft_strupcase(char* str);
//ft_strlowcase:
//
//Convert all letters in a string to lowercase.
//Prototype : char* ft_strlowcase(char* str);
//ft_strcapitalize:
//
//Capitalize the first letter of each word in a string.
//Prototype : char* ft_strcapitalize(char* str);
//ft_strlcpy:
//
//Reproduce the behavior of strlcpy.
//Prototype : unsigned int ft_strlcpy(char* dest, char* src, unsigned int size);
//ft_putstr_non_printable:
//
//Print a string, replacing non - printable characters with hexadecimal representations.
//Prototype : void ft_putstr_non_printable(char* str);
//ft_print_memory:
//
//Print the memory area in a specific format, including hexadecimal and printable representations.
//Prototype : void* ft_print_memory(void* addr, unsigned int size);
//ft_strcpy:
//
//c
//Copier le code

//ft_strncpy:
//
//c
//Copier le code
//char* ft_strncpy(char* dest, char* src, unsigned int n) {
//    unsigned int i;
//    for (i = 0; i < n && src[i] != '\0'; i++) {
//        dest[i] = src[i];
//    }
//    for (; i < n; i++) {
//        dest[i] = '\0';
//    }
//    return dest;
//}
//ft_str_is_alpha:
//
//c
//Copier le code
//int ft_str_is_alpha(char* str) {
//    int i = 0;
//    while (str[i]) {
//        if ((str[i] < 'A' || str[i] > 'Z') && (str[i] < 'a' || str[i] > 'z'))
//            return 0;
//        i++;
//    }
//    return 1;
//}
//ft_str_is_numeric:
//
//c
//Copier le code
//int ft_str_is_numeric(char* str) {
//    int i = 0;
//    while (str[i]) {
//        if (str[i] < '0' || str[i] > '9')
//            return 0;
//        i++;
//    }
//    return 1;
//}
//ft_str_is_lowercase:
//
//c
//Copier le code
//int ft_str_is_lowercase(char* str) {
//    int i = 0;
//    while (str[i]) {
//        if (str[i] < 'a' || str[i] > 'z')
//            return 0;
//        i++;
//    }
//    return 1;
//}
//ft_str_is_uppercase:
//
//c
//Copier le code
//int ft_str_is_uppercase(char* str) {
//    int i = 0;
//    while (str[i]) {
//        if (str[i] < 'A' || str[i] > 'Z')
//            return 0;
//        i++;
//    }
//    return 1;
//}
//ft_str_is_printable:
//
//c
//Copier le code
//int ft_str_is_printable(char* str) {
//    int i = 0;
//    while (str[i]) {
//        if (str[i] < 32 || str[i] > 126)
//            return 0;
//        i++;
//    }
//    return 1;
//}
//ft_strupcase:
//
//c
//Copier le code
//char* ft_strupcase(char* str) {
//    int i = 0;
//    while (str[i]) {
//        if (str[i] >= 'a' && str[i] <= 'z')
//            str[i] -= 32;
//        i++;
//    }
//    return str;
//}
//ft_strlowcase:
//
//c
//Copier le code
//char* ft_strlowcase(char* str) {
//    int i = 0;
//    while (str[i]) {
//        if (str[i] >= 'A' && str[i] <= 'Z')
//            str[i] += 32;
//        i++;
//    }
//    return str;
//}
//ft_strcapitalize:
//
//c
//Copier le code
//char* ft_strcapitalize(char* str) {
//    int i = 0;
//    int capitalize = 1;
//    while (str[i]) {
//        if ((str[i] >= 'a' && str[i] <= 'z') && capitalize) {
//            str[i] -= 32;
//            capitalize = 0;
//        }
//        else if (str[i] >= 'A' && str[i] <= 'Z' && !capitalize) {
//            str[i] += 32;
//        }
//        else if (!(str[i] >= '0' && str[i] <= '9') &&
//            !(str[i] >= 'A' && str[i] <= 'Z') &&
//            !(str[i] >= 'a' && str[i] <= 'z')) {
//            capitalize = 1;
//        }
//        i++;
//    }
//    return str;
//}
//ft_strlcpy:
//
//c
//Copier le code
//unsigned int ft_strlcpy(char* dest, char* src, unsigned int size) {
//    unsigned int i = 0;
//    while (i + 1 < size && src[i]) {
//        dest[i] = src[i];
//        i++;
//    }
//    if (size > 0)
//        dest[i] = '\0';
//    while (src[i])
//        i++;
//    return i;
//}
//ft_putstr_non_printable:
//
//c
//Copier le code
//#include <unistd.h>
//
//void ft_putchar(char c) {
//    write(1, &c, 1);
//}
//
//void ft_putstr_non_printable(char* str) {
//    int i = 0;
//    char* hex = "0123456789abcdef";
//    while (str[i]) {
//        if (str[i] < 32 || str[i] > 126) {
//            ft_putchar('\\');
//            ft_putchar(hex[(unsigned char)str[i] / 16]);
//            ft_putchar(hex[(unsigned char)str[i] % 16]);
//        }
//        else {
//            ft_putchar(str[i]);
//        }
//        i++;
//    }
//}
//ft_print_memory: