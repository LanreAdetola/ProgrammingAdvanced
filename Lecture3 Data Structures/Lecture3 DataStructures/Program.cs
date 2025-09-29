using System;

class Program
{
    static void Main()
    {
        // Create a new linked list
        LinkedList myList = new LinkedList();

        // Add nodes
        myList.InsertTail("A");
        myList.InsertTail("B");
        myList.InsertTail("C");
        myList.InsertTail("D");

        // Print the list
        Console.WriteLine("My Linked List:");
        myList.PrintList(); // Output: A -> B -> C -> D
    }
}
