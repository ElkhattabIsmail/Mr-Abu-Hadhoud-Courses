using System.Net.NetworkInformation;
using System;

//Real - World Example: Train Stations
//In a train route, each station (node) is connected to both its previous and next station. This allows trains to travel forward and backward along the route.

//Station A: Knows the next station (B) and the previous one (none, since it's the first).

//Station B: Knows both the next station (C) and the previous station (A).

//Station C: Knows the next station (D) and the previous one (B).

//Station D: Knows the previous station (C) and the next one (none, since it's the last).

//Doubly Linked List in C#
//Here’s how you might represent a doubly linked list in C#:

//using System;

class Node
{
    public int Value;
    public Node Next;
    public Node Previous;

    public Node(int value)
    {
        Value = value;
        Next = null;
        Previous = null;
    }
}

class DoublyLinkedList
{
    public Node Head;
    public Node Tail;

    protected int _Size;
    public DoublyLinkedList()
    {
        Head = null;
        Tail = null;
    }
    public void InsertAtBegining(int value)
    {
        Node newNode = new Node(value);
        if (Head == null)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            
            Head.Previous = newNode;
            newNode.Next  = Head;
             Head = newNode;
        }
        _Size++;
    }
    public void AddToEnd(int value)
    {
        Node newNode = new Node(value);
        if (Head == null)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            Tail.Next = newNode;
            newNode.Previous = Tail;
            Tail = newNode;
        }
        _Size++;
    }

    public void PrintForward()
    {
        Node current = Head;
        while (current != null)
        {
            Console.Write(current.Value + " -> ");
            current = current.Next;
        }
        Console.WriteLine("null");
    }

    public void PrintBackward()
    {
        Node current = Tail;
        while (current != null)
        {
            Console.Write(current.Value + " -> ");
            current = current.Previous;
        }
        Console.WriteLine("null");
    }
    public Node Find(int Value)
    {
        if (_Size == 0)
            return null;

        Node Current = Head;
        while (Current != null)
        {
            if (Current.Value  == Value)
                return Current;

            Current = Current.Next ;
        }

        return null;
    }
    public void InsertAfter(Node current, int value)
    {


        /*  1 - Create a new node with the desired value.
             2-Set the next pointer of the new node to the next node of the current node.
             3-Set the previous pointer of the new node to the current node.
             4-Set the next pointer of the current node to the new node.
             5-Set the previous pointer of the next node to the new node(if it exists).
        */

        Node newNode = new Node (value);


        newNode.Next = current.Next;
        newNode.Previous = current;  // put the newNode betwenn the Node after current node and the current node

        if (current.Next != null)  // if current Not the last node
        {
            current.Next.Previous = newNode;
        }
        current.Next = newNode;
        _Size++;

    }
    public void DeleteNode(Node NodeToDelete)
    {
        //  0 -> 1 /*-> 2 ->*/ 20 -> 3 -> null
        Node Current = Head;
        if (Head == null || NodeToDelete == null)
            return;
        if (Head == NodeToDelete)
            Head = NodeToDelete.Next; // Head in this case == To The Second Node.

        if (NodeToDelete.Next != null)  // NodeToDelete Between Two Nodes.
        {
            NodeToDelete.Next.Previous = NodeToDelete.Previous;
        }
        if (NodeToDelete.Previous != null)
        {
            NodeToDelete.Previous.Next = NodeToDelete.Next;
        } 
        _Size--;
    }
}

class Program
{
    static void Main(string[] args)
    {
        DoublyLinkedList list = new DoublyLinkedList();
        list.AddToEnd(1);
        list.AddToEnd(2);
        list.AddToEnd(3);

        list.InsertAtBegining(0);
       
        Console.WriteLine("Print forward:");
        list.PrintForward(); // Output: 1 -> 2 -> 3 -> null

        var Node = list.Find(2);

        list.InsertAfter(Node, 20);

        Console.WriteLine("Print Linked List After Insert 20 After 2:");
        list.PrintForward();

        list.DeleteNode(Node);
        Console.WriteLine("Print Linked List After Delete Node With Value 2:");
        list.PrintForward();

        Console.WriteLine("Print backward:");
        list.PrintBackward(); // Output: 3 -> 2 -> 1 -> null
    }
}

//Explanation:
//Node Class: Each node contains a value, a reference to the next node (Next), and a reference to the previous node (Previous).

//DoublyLinkedList Class: Manages the doubly linked list. It has pointers to the first (Head) and last (Tail) nodes, and methods to add new nodes and print the list in both directions.

//Adding Nodes: The AddToEnd method adds new nodes at the end of the list, updating both the Next and Previous references.

//Printing Nodes: The PrintForward method prints the list from the head to the tail, while the PrintBackward method prints from the tail to the head.

//This example demonstrates how a doubly linked list can be traversed in both directions, much like a train route where each station knows its neighbors in both directions.
