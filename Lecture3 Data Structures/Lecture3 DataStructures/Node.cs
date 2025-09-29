public class Node
{
    public string Data { get; set; }  // the value stored in the node
    public Node Next { get; set; }    // reference to the next node (null if none)

    // Constructor to create a node with data
    public Node(string data)
    {
        Data = data;
        Next = null; // initially no next node
    }
}
