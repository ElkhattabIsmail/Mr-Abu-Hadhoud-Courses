using System.Collections.Generic;
using System.Xml.Linq;
using System;

//Real - World Example: Carousel
//Think of a carousel at a carnival. Riders (nodes) go around in a circle, and there's no clear start or end point because the ride continuously loops.

//Horse A: After Horse A comes Horse B.

//Horse B: After Horse B comes Horse C.

//Horse C: After Horse C comes Horse D.

//Horse D: After Horse D, you go back to Horse A.

//This forms a continuous loop, much like a circular linked list.

//Circular Linked List in C#
//Here’s an example in C# that demonstrates a circular linked list:

//csharp
//using System;

class Node
{
    public int Value;
    public Node Next;

    public Node(int value)
    {
        Value = value;
        Next = null;
    }
}

class CircularLinkedList
{
    public Node Head;

    public CircularLinkedList()
    {
        Head = null;
    }

    public void Add(int value)
    {
        Node newNode = new Node(value);
        if (Head == null)
        {
            Head = newNode;
            Head.Next = Head;
        }
        else
        {
            Node current = Head;
            while (current.Next != Head)
            {
                current = current.Next;
            }
            current.Next = newNode;
            newNode.Next = Head;
        }
    }

    public void Print()
    {
        if (Head == null) return;

        Node current = Head;
        int flag = 1;
        do
        {
            Console.Write(current.Value + " -> ");
            current = current.Next;

            if (current == Head && flag != 2)
            {
                Console.Write(current.Value + " (head)  ");
                current = Head.Next;
                flag++;
            }
        } while (current != Head);
        Console.Write(current.Value + " (head)  ");




    }
}

class Program
{
    static void Main(string[] args)
    {
        CircularLinkedList list = new CircularLinkedList();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);

        list.Print(); // Output: 1 -> 2 -> 3 -> 4 -> 1 (head)
    }
}
//Explanation:
//Node Class: Represents each element in the list, containing a value and a reference to the next node.

//CircularLinkedList Class: Manages the circular linked list. It has a Head pointer to the first node.

//Adding Nodes: The Add method adds a new node.If the list is empty, the new node points to itself. Otherwise, the new node is added to the end, and its Next pointer is set to point to the Head.

//Printing Nodes: The Print method traverses the list starting from the Head, printing each node's value until it loops back to the Head.

//In this example, nodes are added to the circular linked list with values 1, 2, 3, and 4. The Print method then outputs the values in a continuous loop: 1-> 2-> 3-> 4-> 1(head).

//10 - 12 - 2024