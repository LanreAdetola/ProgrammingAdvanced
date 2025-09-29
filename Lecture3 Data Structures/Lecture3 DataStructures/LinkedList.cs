public class LinkedList
{
    public Node Head { get; set; } // first node of the list

    public LinkedList() 
    {
        Head = null; // list is empty at start
    }

    // Method to add a new node at the end (tail)
    public void InsertTail(string value)
    {
        Node newNode = new Node(value);

        if (Head == null)
        {
            Head = newNode; // first node in list
            return;
        }

        Node current = Head;
        while (current.Next != null)
        {
            current = current.Next; // move to the last node
        }

        current.Next = newNode; // link new node at the end
    }

    // Method to display the linked list
    public void PrintList()
    {
        Node current = Head;
        while (current != null)
        {
            Console.Write(current.Data);
            if (current.Next != null)
                Console.Write(" -> "); // visual arrow
            current = current.Next;
        }
        Console.WriteLine();
    }
}
