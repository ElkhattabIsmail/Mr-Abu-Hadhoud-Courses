
#include <iostream>
using namespace std;

#include "ClsDblLinkedList.h"
class Node
{

public:
    int value;
    Node* next;
    Node* prev;

};
int main()
{
    // back to reverse function okey
    clsDblLinkedList <int> Mylist;

   

    
    Mylist.InsertAtBeginning(5);
    Mylist.InsertAtBeginning(4);
    Mylist.InsertAtBeginning(3);
    Mylist.InsertAtBeginning(2);
    Mylist.InsertAtBeginning(1);
  

    Mylist.PrintList();
    
  


    Mylist.InsertAfter(4, 77);
    Mylist.PrintList();
    Mylist.InsertAfter(0, 22);
    Mylist.PrintList();
    system("pause>0");
    return 0;
}

