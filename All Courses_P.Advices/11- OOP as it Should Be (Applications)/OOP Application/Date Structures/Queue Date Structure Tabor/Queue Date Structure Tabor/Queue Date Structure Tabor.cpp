// ProgrammingAdvices.com
// Mohammed Abu-Hadhoud

#include <stack>
#include <queue>

#include <iostream>
using namespace std;

int main()
{
    // fifo first in first out tabor
    queue <int> MyQueue;
    // pushing elements into first stack
    MyQueue.push(10);
    MyQueue.push(20);
    MyQueue.push(30);
    MyQueue.push(40);

    cout << "\nCount: " << MyQueue.size();
    cout << "\nFront: " << MyQueue.front();
    cout << "\nBack: " << MyQueue.back() << endl;

    cout << "\nMyQueue = ";
    while (!MyQueue.empty())
    {
        cout << MyQueue.front() << " ";
        MyQueue.pop();

    }

        ////Extension #1
        //cout << "\n\n Item(2) : " << MyQueue.GetItem(2);

        ////Extension #2
        //MyQueue.Reverse();
        //cout << "\n\nQueue after reverse() : \n";
        //MyQueue.Print();

        ////Extension #3
        //MyQueue.UpdateItem(2, 600);
        //cout << "\n\nQueue after updating Item(2) to 600 : \n";
        //MyQueue.Print();

        ////Extension #4
        //MyQueue.InsertAfter(2, 800);
        //cout << "\n\nQueue after Inserting 800 after Item(2) : \n";
        //MyQueue.Print();


        ////Extension #5
        //MyQueue.InsertAtFront(1000);
        //cout << "\n\nQueue after Inserting 1000 at front: \n";
        //MyQueue.Print();

        ////Extension #6
        //MyQueue.InsertAtBack(2000);
        //cout << "\n\nQueue after Inserting 2000 at back: \n";
        //MyQueue.Print();

        ////Extension #7
        //MyQueue.Clear();
        //cout << "\n\nQueue after Clear(): \n";
        //MyQueue.Print();




        system("pause>0");

    }